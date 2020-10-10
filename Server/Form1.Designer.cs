namespace Project1
{
    partial class TcpServer
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
            this.comboBoxCameras = new System.Windows.Forms.ComboBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxVideo1 = new System.Windows.Forms.PictureBox();
            this.buttonTakePicture = new System.Windows.Forms.Button();
            this.buttonReceiveImage = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxVideo2 = new System.Windows.Forms.PictureBox();
            this.buttonServerTcp = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideo1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideo2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCameras
            // 
            this.comboBoxCameras.FormattingEnabled = true;
            this.comboBoxCameras.Location = new System.Drawing.Point(9, 10);
            this.comboBoxCameras.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCameras.Name = "comboBoxCameras";
            this.comboBoxCameras.Size = new System.Drawing.Size(140, 21);
            this.comboBoxCameras.TabIndex = 2;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(10, 35);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(138, 19);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(9, 58);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(138, 19);
            this.buttonStop.TabIndex = 4;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxVideo1);
            this.groupBox1.Location = new System.Drawing.Point(153, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(135, 115);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video";
            // 
            // pictureBoxVideo1
            // 
            this.pictureBoxVideo1.Location = new System.Drawing.Point(5, 18);
            this.pictureBoxVideo1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxVideo1.Name = "pictureBoxVideo1";
            this.pictureBoxVideo1.Size = new System.Drawing.Size(125, 92);
            this.pictureBoxVideo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVideo1.TabIndex = 0;
            this.pictureBoxVideo1.TabStop = false;
            // 
            // buttonTakePicture
            // 
            this.buttonTakePicture.Location = new System.Drawing.Point(10, 82);
            this.buttonTakePicture.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTakePicture.Name = "buttonTakePicture";
            this.buttonTakePicture.Size = new System.Drawing.Size(138, 19);
            this.buttonTakePicture.TabIndex = 6;
            this.buttonTakePicture.Text = "Take picture";
            this.buttonTakePicture.UseVisualStyleBackColor = true;
            this.buttonTakePicture.Click += new System.EventHandler(this.buttonTakePicture_Click);
            // 
            // buttonReceiveImage
            // 
            this.buttonReceiveImage.Location = new System.Drawing.Point(10, 106);
            this.buttonReceiveImage.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReceiveImage.Name = "buttonReceiveImage";
            this.buttonReceiveImage.Size = new System.Drawing.Size(138, 19);
            this.buttonReceiveImage.TabIndex = 7;
            this.buttonReceiveImage.Text = "Copy picture";
            this.buttonReceiveImage.UseVisualStyleBackColor = true;
            this.buttonReceiveImage.Click += new System.EventHandler(this.buttonReceiveImage_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBoxVideo2);
            this.groupBox2.Location = new System.Drawing.Point(292, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(145, 115);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Video 2";
            // 
            // pictureBoxVideo2
            // 
            this.pictureBoxVideo2.Location = new System.Drawing.Point(4, 18);
            this.pictureBoxVideo2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxVideo2.Name = "pictureBoxVideo2";
            this.pictureBoxVideo2.Size = new System.Drawing.Size(136, 92);
            this.pictureBoxVideo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVideo2.TabIndex = 0;
            this.pictureBoxVideo2.TabStop = false;
            // 
            // buttonServerTcp
            // 
            this.buttonServerTcp.Location = new System.Drawing.Point(9, 146);
            this.buttonServerTcp.Margin = new System.Windows.Forms.Padding(2);
            this.buttonServerTcp.Name = "buttonServerTcp";
            this.buttonServerTcp.Size = new System.Drawing.Size(138, 19);
            this.buttonServerTcp.TabIndex = 11;
            this.buttonServerTcp.Text = "Run TCP server";
            this.buttonServerTcp.UseVisualStyleBackColor = true;
            this.buttonServerTcp.Click += new System.EventHandler(this.buttonServerTcp_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 346);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(601, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel";
            // 
            // TcpServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 368);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonServerTcp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonReceiveImage);
            this.Controls.Add(this.buttonTakePicture);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.comboBoxCameras);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TcpServer";
            this.Text = "TcpServer";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideo1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideo2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxCameras;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxVideo1;
        private System.Windows.Forms.Button buttonTakePicture;
        private System.Windows.Forms.Button buttonReceiveImage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBoxVideo2;
        private System.Windows.Forms.Button buttonServerTcp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

