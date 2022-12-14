using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using rtChart;
using System.Collections.Generic;
using Ground_Control.Classes;
using System.Linq;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Ground_Control
{
    public partial class Form1 : Form

    {

        bool isConnected = false;
        String[] ports;
        SerialPort port;
        String[] baud_rates = { "4800", "9600", "14400", "19200", "38400", "57600", "115200" };

        public delegate void portDelegate(string sData);

        kayChart serial_data_chart;

        public List<ArduinoData> arduinoDatas;

        double lat, longt;

        public Form1()
        {
            InitializeComponent();

            ReturnDefault();
            DisableComponents();
            GetAvailablePorts();
            InitCircularProgressBar();
            InitMap();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arduinoDatas = new List<ArduinoData>();

            serial_data_chart = new kayChart(data_chart1, 300);
            serial_data_chart.serieName = " ";
        }

        void Battery(double bat_voltage = 7.3, double bat_max_voltage = 7.4, double bat_min_voltage = 6.0)
        {

            double used = bat_voltage - bat_min_voltage;
            double useable_battery = bat_max_voltage - bat_min_voltage;

            // For calculate battery symbol blue area width
            double x = (200 * used) / useable_battery;
            double rounded = Math.Round(x, 0);
            int result = Int32.Parse(rounded.ToString());

            // For the % percantage
            double percantage = x / 2;
            double percantage_rounded = Math.Round(percantage, 0);
            int percantage_result = Int32.Parse(percantage_rounded.ToString());
            txt_bat_percent.Text = "%" + percantage_result.ToString();

            //Console.WriteLine("Result:" + result.ToString());

            if (result > 180)
            {
                bat_level2.Width = result - 180;  //bat_level -> Blue area inside the battery sign
                bat_level.Width = 180;
            }
            else if (result <= 180)
            {
                bat_level2.Width = 0;
                bat_level.Width = result;
            }

            txt_voltage.Text = bat_voltage.ToString() + "V";

        }

        public void GetAvailablePorts()
        {
            try
            {
                ports = SerialPort.GetPortNames();

                foreach (string port in ports)
                {
                    Console.WriteLine(port);
                    combo_ports.Items.Add(port);

                    if (ports[0] != null)
                    {
                        combo_ports.SelectedItem = ports[0];
                        btn_connect.Enabled = true;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("PORT ERROR: " + e.Message);
            }
        }

        private void ConnectArduino()
        {
            isConnected = true;
            string selected_port = combo_ports.Text.ToString();
            int selected_baudRate = Int32.Parse(combo_baudRate.Text);
            
            try
            {
                port = new SerialPort(selected_port, selected_baudRate, Parity.None, 8, StopBits.One);
                port.DataReceived += Port_DataReceived;
                port.Open();
                port.Write("/STRC");

                isConnected = true;
                btn_connect.Text = "Disconnect";
                btn_connect.BackColor = Color.Coral;
                EnableComponents();
            }
            catch (Exception e)
            {
                Console.WriteLine("CONNECTION ERROR: " + e.Message);
            }
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
            {
                
                try
                {
                    port.ReadTimeout = 2000;
                    string str_data = port.ReadLine();
                    this.BeginInvoke((new portDelegate(ReceiveData)), str_data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        private void DisconnectArduino()
        {
            isConnected = false;
            try
            {
                port.Write("/STPC\n");
                port.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("DISCONNECT ERROR: " + e.Message);
            }

            isConnected = false;
            btn_connect.Text = "Connect";
            btn_connect.BackColor = Color.DodgerBlue;
            DisableComponents();
        }

        private void TransmitData(string data = "")
        {
            try
            {
                port.Write("/DATA" + data + "\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("DATA SENDING ERROR: " + e.Message);
            }
        }

        private void ReceiveData(String sData)
        {
            string fixed_data = sData.Replace(".", ",");
            string[] splitted_data = fixed_data.Split('*');

            double bat_value = 0D;

            //string fixed_data = sData.Replace(".", ",");
            //UpdateCPBValues(sData);
            //Console.WriteLine(Double.Parse(fixed_data));

            Console.WriteLine(splitted_data.Length);


            try
            {
                bat_value = Double.Parse(splitted_data[0]);
                Battery(bat_value);
                serial_data_chart.TriggeredUpdate(bat_value);
            }
            catch (Exception e)
            {
                Console.WriteLine("DATA CHART PARSE ERROR: " + e.Message);
            }


            ArduinoData d = new ArduinoData()
            {
                Battery = bat_value,
                Altitude = Int32.Parse(splitted_data[1]),
                Latitude = Double.Parse(splitted_data[2]),
                Longitude = Double.Parse(splitted_data[3]),
                Humidity = Int32.Parse(splitted_data[4]),
                Temperature = Double.Parse(splitted_data[5])
            };

            arduinoDatas.Insert(0, d);

            dataGridView.DataSource = null;
            dataGridView.Rows.Clear();
            dataGridView.DataSource = arduinoDatas;

            //dataGridView.Update();

            //Console.WriteLine("ARDUINO DATAS: " + arduinoDatas.Count().ToString());
        }

        public void ReturnDefault()
        {
            combo_baudRate.Items.Clear();
            combo_ports.Items.Clear();
            btn_connect.Enabled = false;

            foreach (string baud_rate in baud_rates)
            {
                combo_baudRate.Items.Add(baud_rate);
            }

            combo_baudRate.SelectedItem = "9600";

            UpdateCPBValues("0");

        }

        void InitCircularProgressBar()
        {
            cpb.Minimum = 0;
            cpb.Maximum = 200;
            cpb.Value = 0;
            cpb.Update();
        }

        void UpdateCPBValues(string data)
        {
            cpb.Value = Int32.Parse(data);
            cpb.Text = data + " " + "km/h";
            cpb.Update();
        }

        public void DisableComponents()
        {

        }

        public void EnableComponents()
        {

        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                DisconnectArduino();
            }

            else if (!isConnected || port != null || combo_baudRate.Text != "")
            {
                ConnectArduino();
            }
        }

        private void iPCamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IP_Cam ip_cam_form = new IP_Cam();
            ip_cam_form.Show();
        }

        private void btn_refreshPorts_Click(object sender, EventArgs e)
        {
            GetAvailablePorts();
        }

        public void InitMap()
        {
            map.MapProvider = GMapProviders.GoogleMap;
            map.DragButton = MouseButtons.Left;
            lat = 39.925262;
            longt = 32.836912;
            UpdatePositionOnMap(lat, longt);
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 18;
        }

        public void UpdatePositionOnMap(double latitude, double longitude)
        {
            map.Position = new PointLatLng(latitude, longitude);
            PointLatLng point = new PointLatLng(latitude, longitude);
            map.Overlays.Clear(); //If you delete this row previous markers won't be deleted.
            map.Refresh(); //This can be useless idk :D
            AddMarkerToMap(point);
        }

        public void AddMarkerToMap(PointLatLng point)
        {
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);
            GMapOverlay overlay = new GMapOverlay("overlay");
            overlay.Markers.Add(marker);
            map.Overlays.Add(overlay);
        }
    }
}
