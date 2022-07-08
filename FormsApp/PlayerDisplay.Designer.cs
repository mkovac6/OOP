
namespace FormsApp
{
    partial class PlayerDisplay
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.lblCaptaincy = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.cmsChangeImage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changePlayerImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectForTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.cmsChangeImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(55, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(50, 94);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(46, 17);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "label1";
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Image = global::FormsApp.Properties.Resources.Favorite_16x;
            this.lblIcon.Location = new System.Drawing.Point(22, 124);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(16, 17);
            this.lblIcon.TabIndex = 2;
            this.lblIcon.Text = "_";
            this.lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaptaincy
            // 
            this.lblCaptaincy.AutoSize = true;
            this.lblCaptaincy.Location = new System.Drawing.Point(3, 55);
            this.lblCaptaincy.Name = "lblCaptaincy";
            this.lblCaptaincy.Size = new System.Drawing.Size(46, 17);
            this.lblCaptaincy.TabIndex = 3;
            this.lblCaptaincy.Text = "label1";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(3, 27);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(46, 17);
            this.lblNumber.TabIndex = 4;
            this.lblNumber.Text = "label1";
            // 
            // pbIcon
            // 
            this.pbIcon.Location = new System.Drawing.Point(158, 52);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(100, 104);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 5;
            this.pbIcon.TabStop = false;
            // 
            // cmsChangeImage
            // 
            this.cmsChangeImage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsChangeImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePlayerImageToolStripMenuItem,
            this.selectForTransferToolStripMenuItem});
            this.cmsChangeImage.Name = "cmsChangeImage";
            this.cmsChangeImage.Size = new System.Drawing.Size(220, 52);
            // 
            // changePlayerImageToolStripMenuItem
            // 
            this.changePlayerImageToolStripMenuItem.Name = "changePlayerImageToolStripMenuItem";
            this.changePlayerImageToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.changePlayerImageToolStripMenuItem.Text = "Change player image";
            this.changePlayerImageToolStripMenuItem.Click += new System.EventHandler(this.changePlayerImageToolStripMenuItem_Click);
            // 
            // selectForTransferToolStripMenuItem
            // 
            this.selectForTransferToolStripMenuItem.Name = "selectForTransferToolStripMenuItem";
            this.selectForTransferToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.selectForTransferToolStripMenuItem.Text = "Select for transfer";
            this.selectForTransferToolStripMenuItem.Click += new System.EventHandler(this.selectForTransferToolStripMenuItem_Click);
            // 
            // PlayerDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ContextMenuStrip = this.cmsChangeImage;
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblCaptaincy);
            this.Controls.Add(this.lblIcon);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblName);
            this.Name = "PlayerDisplay";
            this.Size = new System.Drawing.Size(261, 159);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerDisplay_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.cmsChangeImage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblCaptaincy;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.ContextMenuStrip cmsChangeImage;
        private System.Windows.Forms.ToolStripMenuItem changePlayerImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectForTransferToolStripMenuItem;
    }
}
