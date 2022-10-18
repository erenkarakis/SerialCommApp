namespace Ground_Control
{
    partial class IP_Cam
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtbox_cam_address = new System.Windows.Forms.TextBox();
            this.btn_connectVideo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.video_panel = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.video_panel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.txtbox_cam_address);
            this.panel3.Controls.Add(this.btn_connectVideo);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.video_panel);
            this.panel3.Location = new System.Drawing.Point(54, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(620, 620);
            this.panel3.TabIndex = 28;
            // 
            // txtbox_cam_address
            // 
            this.txtbox_cam_address.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtbox_cam_address.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbox_cam_address.ForeColor = System.Drawing.Color.White;
            this.txtbox_cam_address.Location = new System.Drawing.Point(181, 570);
            this.txtbox_cam_address.Name = "txtbox_cam_address";
            this.txtbox_cam_address.Size = new System.Drawing.Size(400, 26);
            this.txtbox_cam_address.TabIndex = 7;
            // 
            // btn_connectVideo
            // 
            this.btn_connectVideo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_connectVideo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_connectVideo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_connectVideo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_connectVideo.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_connectVideo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_connectVideo.Location = new System.Drawing.Point(16, 563);
            this.btn_connectVideo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_connectVideo.Name = "btn_connectVideo";
            this.btn_connectVideo.Size = new System.Drawing.Size(160, 40);
            this.btn_connectVideo.TabIndex = 6;
            this.btn_connectVideo.Text = "Connect";
            this.btn_connectVideo.UseVisualStyleBackColor = false;
            this.btn_connectVideo.Click += new System.EventHandler(this.btn_connectVideo_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(260, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Live Video";
            // 
            // video_panel
            // 
            this.video_panel.Location = new System.Drawing.Point(65, 57);
            this.video_panel.Name = "video_panel";
            this.video_panel.Padding = new System.Windows.Forms.Padding(150);
            this.video_panel.Size = new System.Drawing.Size(500, 500);
            this.video_panel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.video_panel.TabIndex = 0;
            this.video_panel.TabStop = false;
            // 
            // IP_Cam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 711);
            this.Controls.Add(this.panel3);
            this.Name = "IP_Cam";
            this.Text = "IP_Cam";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.video_panel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtbox_cam_address;
        private System.Windows.Forms.Button btn_connectVideo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox video_panel;
    }
}