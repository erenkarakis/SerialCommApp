namespace Ground_Control
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_bat_percent = new System.Windows.Forms.Label();
            this.bat_level2 = new System.Windows.Forms.PictureBox();
            this.txt_voltage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bat_level = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cpb = new CircularProgressBar.CircularProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.ConnectionPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_baudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_ports = new System.Windows.Forms.ComboBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.data_chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.data_chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.otherPanelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iPCamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rawDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendDataToBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bat_level2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat_level)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.ConnectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_chart2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(930, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(954, 299);
            this.dataGridView1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.txt_bat_percent);
            this.panel2.Controls.Add(this.bat_level2);
            this.panel2.Controls.Add(this.txt_voltage);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.bat_level);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(623, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 300);
            this.panel2.TabIndex = 26;
            // 
            // txt_bat_percent
            // 
            this.txt_bat_percent.AutoSize = true;
            this.txt_bat_percent.BackColor = System.Drawing.Color.Transparent;
            this.txt_bat_percent.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_bat_percent.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txt_bat_percent.Location = new System.Drawing.Point(136, 195);
            this.txt_bat_percent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_bat_percent.Name = "txt_bat_percent";
            this.txt_bat_percent.Size = new System.Drawing.Size(30, 22);
            this.txt_bat_percent.TabIndex = 11;
            this.txt_bat_percent.Text = "%0";
            // 
            // bat_level2
            // 
            this.bat_level2.BackColor = System.Drawing.Color.DodgerBlue;
            this.bat_level2.Location = new System.Drawing.Point(234, 237);
            this.bat_level2.Name = "bat_level2";
            this.bat_level2.Size = new System.Drawing.Size(20, 35);
            this.bat_level2.TabIndex = 10;
            this.bat_level2.TabStop = false;
            // 
            // txt_voltage
            // 
            this.txt_voltage.AutoSize = true;
            this.txt_voltage.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_voltage.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txt_voltage.Location = new System.Drawing.Point(178, 106);
            this.txt_voltage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_voltage.Name = "txt_voltage";
            this.txt_voltage.Size = new System.Drawing.Size(34, 22);
            this.txt_voltage.TabIndex = 9;
            this.txt_voltage.Text = "0 V";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(86, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Voltage:";
            // 
            // bat_level
            // 
            this.bat_level.BackColor = System.Drawing.Color.DodgerBlue;
            this.bat_level.Location = new System.Drawing.Point(57, 224);
            this.bat_level.Name = "bat_level";
            this.bat_level.Size = new System.Drawing.Size(10, 60);
            this.bat_level.TabIndex = 6;
            this.bat_level.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Location = new System.Drawing.Point(234, 236);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 35);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(57, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 60);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(104, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Battery";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.cpb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(317, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 300);
            this.panel1.TabIndex = 25;
            // 
            // cpb
            // 
            this.cpb.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpb.AnimationSpeed = 500;
            this.cpb.BackColor = System.Drawing.Color.Transparent;
            this.cpb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cpb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpb.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cpb.InnerMargin = 2;
            this.cpb.InnerWidth = -1;
            this.cpb.Location = new System.Drawing.Point(44, 55);
            this.cpb.MarqueeAnimationSpeed = 2000;
            this.cpb.Name = "cpb";
            this.cpb.OuterColor = System.Drawing.Color.Gray;
            this.cpb.OuterMargin = -25;
            this.cpb.OuterWidth = 26;
            this.cpb.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.cpb.ProgressWidth = 40;
            this.cpb.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cpb.Size = new System.Drawing.Size(200, 200);
            this.cpb.StartAngle = 90;
            this.cpb.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpb.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpb.SubscriptText = "";
            this.cpb.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpb.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpb.SuperscriptText = "";
            this.cpb.TabIndex = 4;
            this.cpb.Text = "00 km/h";
            this.cpb.TextMargin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.cpb.Value = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(106, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Speed";
            // 
            // ConnectionPanel
            // 
            this.ConnectionPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConnectionPanel.Controls.Add(this.label2);
            this.ConnectionPanel.Controls.Add(this.label1);
            this.ConnectionPanel.Controls.Add(this.combo_baudRate);
            this.ConnectionPanel.Controls.Add(this.label3);
            this.ConnectionPanel.Controls.Add(this.combo_ports);
            this.ConnectionPanel.Controls.Add(this.btn_connect);
            this.ConnectionPanel.Location = new System.Drawing.Point(11, 45);
            this.ConnectionPanel.Name = "ConnectionPanel";
            this.ConnectionPanel.Size = new System.Drawing.Size(300, 300);
            this.ConnectionPanel.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(26, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud Rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(73, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // combo_baudRate
            // 
            this.combo_baudRate.BackColor = System.Drawing.Color.DodgerBlue;
            this.combo_baudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_baudRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_baudRate.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_baudRate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.combo_baudRate.FormattingEnabled = true;
            this.combo_baudRate.Location = new System.Drawing.Point(126, 139);
            this.combo_baudRate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.combo_baudRate.Name = "combo_baudRate";
            this.combo_baudRate.Size = new System.Drawing.Size(161, 26);
            this.combo_baudRate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(45, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Connection Panel";
            // 
            // combo_ports
            // 
            this.combo_ports.BackColor = System.Drawing.Color.DodgerBlue;
            this.combo_ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_ports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_ports.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_ports.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.combo_ports.FormattingEnabled = true;
            this.combo_ports.Location = new System.Drawing.Point(126, 84);
            this.combo_ports.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.combo_ports.Name = "combo_ports";
            this.combo_ports.Size = new System.Drawing.Size(161, 26);
            this.combo_ports.TabIndex = 1;
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_connect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_connect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_connect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_connect.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_connect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_connect.Location = new System.Drawing.Point(70, 215);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(160, 40);
            this.btn_connect.TabIndex = 4;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // data_chart1
            // 
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DodgerBlue;
            chartArea3.AxisX.LineColor = System.Drawing.Color.LightGray;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.LightGray;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.DodgerBlue;
            chartArea3.AxisY.LineColor = System.Drawing.Color.LightGray;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.LightGray;
            chartArea3.AxisY.TitleForeColor = System.Drawing.Color.DodgerBlue;
            chartArea3.Name = "ChartArea1";
            this.data_chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.data_chart1.Legends.Add(legend3);
            this.data_chart1.Location = new System.Drawing.Point(1234, 353);
            this.data_chart1.Name = "data_chart1";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.DodgerBlue;
            series3.Legend = "Legend1";
            series3.Name = " ";
            this.data_chart1.Series.Add(series3);
            this.data_chart1.Size = new System.Drawing.Size(650, 250);
            this.data_chart1.TabIndex = 30;
            this.data_chart1.Text = "chart1";
            // 
            // data_chart2
            // 
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DodgerBlue;
            chartArea4.AxisX.LineColor = System.Drawing.Color.LightGray;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea4.AxisX.MajorTickMark.LineColor = System.Drawing.Color.LightGray;
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.DodgerBlue;
            chartArea4.AxisY.LineColor = System.Drawing.Color.LightGray;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea4.AxisY.MajorTickMark.LineColor = System.Drawing.Color.LightGray;
            chartArea4.AxisY.TitleForeColor = System.Drawing.Color.DodgerBlue;
            chartArea4.Name = "ChartArea1";
            this.data_chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.data_chart2.Legends.Add(legend4);
            this.data_chart2.Location = new System.Drawing.Point(1234, 609);
            this.data_chart2.Name = "data_chart2";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.DodgerBlue;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.data_chart2.Series.Add(series4);
            this.data_chart2.Size = new System.Drawing.Size(650, 250);
            this.data_chart2.TabIndex = 31;
            this.data_chart2.Text = "chart2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otherPanelsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1884, 29);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // otherPanelsToolStripMenuItem
            // 
            this.otherPanelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iPCamToolStripMenuItem,
            this.rawDataToolStripMenuItem,
            this.sendDataToBoardToolStripMenuItem});
            this.otherPanelsToolStripMenuItem.Name = "otherPanelsToolStripMenuItem";
            this.otherPanelsToolStripMenuItem.Size = new System.Drawing.Size(114, 25);
            this.otherPanelsToolStripMenuItem.Text = "Other Panels";
            // 
            // iPCamToolStripMenuItem
            // 
            this.iPCamToolStripMenuItem.Name = "iPCamToolStripMenuItem";
            this.iPCamToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.iPCamToolStripMenuItem.Text = "IP Cam";
            this.iPCamToolStripMenuItem.Click += new System.EventHandler(this.iPCamToolStripMenuItem_Click);
            // 
            // rawDataToolStripMenuItem
            // 
            this.rawDataToolStripMenuItem.Name = "rawDataToolStripMenuItem";
            this.rawDataToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.rawDataToolStripMenuItem.Text = "Raw Data";
            // 
            // sendDataToBoardToolStripMenuItem
            // 
            this.sendDataToBoardToolStripMenuItem.Name = "sendDataToBoardToolStripMenuItem";
            this.sendDataToBoardToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.sendDataToBoardToolStripMenuItem.Text = "Send Data To Board";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 911);
            this.Controls.Add(this.data_chart2);
            this.Controls.Add(this.data_chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConnectionPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bat_level2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat_level)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ConnectionPanel.ResumeLayout(false);
            this.ConnectionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_chart2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txt_bat_percent;
        private System.Windows.Forms.PictureBox bat_level2;
        private System.Windows.Forms.Label txt_voltage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox bat_level;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel ConnectionPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_baudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_ports;
        private System.Windows.Forms.Button btn_connect;
        private CircularProgressBar.CircularProgressBar cpb;
        private System.Windows.Forms.DataVisualization.Charting.Chart data_chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart data_chart2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem otherPanelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iPCamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rawDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendDataToBoardToolStripMenuItem;
    }
}

