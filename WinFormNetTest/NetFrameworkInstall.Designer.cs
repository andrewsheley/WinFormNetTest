namespace WinFormNetTest
{
    partial class NetFrameworkInstall
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
            this.lblMsgText = new System.Windows.Forms.Label();
            this.lnkNETFramework = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lnkHelp = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMsgText
            // 
            this.lblMsgText.AutoSize = true;
            this.lblMsgText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgText.Location = new System.Drawing.Point(107, 9);
            this.lblMsgText.Name = "lblMsgText";
            this.lblMsgText.Size = new System.Drawing.Size(51, 20);
            this.lblMsgText.TabIndex = 0;
            this.lblMsgText.Text = "label1";
            // 
            // lnkNETFramework
            // 
            this.lnkNETFramework.AutoSize = true;
            this.lnkNETFramework.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkNETFramework.Location = new System.Drawing.Point(13, 240);
            this.lnkNETFramework.Name = "lnkNETFramework";
            this.lnkNETFramework.Size = new System.Drawing.Size(72, 17);
            this.lnkNETFramework.TabIndex = 1;
            this.lnkNETFramework.TabStop = true;
            this.lnkNETFramework.Text = "linkLabel1";
            this.lnkNETFramework.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNETFramework_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormNetTest.Properties.Resources.exclimationpoint;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lnkHelp
            // 
            this.lnkHelp.AutoSize = true;
            this.lnkHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkHelp.Location = new System.Drawing.Point(741, 244);
            this.lnkHelp.Name = "lnkHelp";
            this.lnkHelp.Size = new System.Drawing.Size(37, 17);
            this.lnkHelp.TabIndex = 3;
            this.lnkHelp.TabStop = true;
            this.lnkHelp.Text = "Help";
            // 
            // NetFrameworkInstall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 278);
            this.Controls.Add(this.lnkHelp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lnkNETFramework);
            this.Controls.Add(this.lblMsgText);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NetFrameworkInstall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".NET Framework Install";
            this.Load += new System.EventHandler(this.NetFrameworkInstall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsgText;
        private System.Windows.Forms.LinkLabel lnkNETFramework;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lnkHelp;
    }
}