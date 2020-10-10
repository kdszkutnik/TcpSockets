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
            this.buttonServerTcp = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxVideo1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideo1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonServerTcp
            // 
            this.buttonServerTcp.Location = new System.Drawing.Point(12, 11);
            this.buttonServerTcp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonServerTcp.Name = "buttonServerTcp";
            this.buttonServerTcp.Size = new System.Drawing.Size(184, 44);
            this.buttonServerTcp.TabIndex = 11;
            this.buttonServerTcp.Text = "Run TCP server";
            this.buttonServerTcp.UseVisualStyleBackColor = true;
            this.buttonServerTcp.Click += new System.EventHandler(this.buttonServerTcp_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 358);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(754, 26);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(143, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxVideo1);
            this.groupBox1.Location = new System.Drawing.Point(222, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(180, 142);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video";
            // 
            // pictureBoxVideo1
            // 
            this.pictureBoxVideo1.Location = new System.Drawing.Point(7, 22);
            this.pictureBoxVideo1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxVideo1.Name = "pictureBoxVideo1";
            this.pictureBoxVideo1.Size = new System.Drawing.Size(167, 113);
            this.pictureBoxVideo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVideo1.TabIndex = 0;
            this.pictureBoxVideo1.TabStop = false;
            // 
            // TcpServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 384);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonServerTcp);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TcpServer";
            this.Text = "TcpServer";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonServerTcp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxVideo1;
    }
}

