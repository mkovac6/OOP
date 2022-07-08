
namespace FormsApp
{
    partial class PopupForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeadline = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbChamp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbEn = new System.Windows.Forms.RadioButton();
            this.rbCro = new System.Windows.Forms.RadioButton();
            this.gbLangauge = new System.Windows.Forms.GroupBox();
            this.chbIsOnline = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.gbLangauge.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeadline
            // 
            this.lblHeadline.AutoSize = true;
            this.lblHeadline.Location = new System.Drawing.Point(175, 22);
            this.lblHeadline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeadline.Name = "lblHeadline";
            this.lblHeadline.Size = new System.Drawing.Size(57, 13);
            this.lblHeadline.TabIndex = 0;
            this.lblHeadline.Text = "Hello user!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(85, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please choose wanted championship and language:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select championship:";
            // 
            // cbChamp
            // 
            this.cbChamp.FormattingEnabled = true;
            this.cbChamp.Items.AddRange(new object[] {
            "Men\'s World Football Championship 2018",
            "Women\'s World Football Championship 2019"});
            this.cbChamp.Location = new System.Drawing.Point(88, 102);
            this.cbChamp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbChamp.Name = "cbChamp";
            this.cbChamp.Size = new System.Drawing.Size(239, 21);
            this.cbChamp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preferred language:";
            // 
            // rbEn
            // 
            this.rbEn.AutoSize = true;
            this.rbEn.Location = new System.Drawing.Point(21, 37);
            this.rbEn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbEn.Name = "rbEn";
            this.rbEn.Size = new System.Drawing.Size(59, 17);
            this.rbEn.TabIndex = 5;
            this.rbEn.TabStop = true;
            this.rbEn.Tag = "en";
            this.rbEn.Text = "English";
            this.rbEn.UseVisualStyleBackColor = true;
            // 
            // rbCro
            // 
            this.rbCro.AutoSize = true;
            this.rbCro.Location = new System.Drawing.Point(143, 37);
            this.rbCro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbCro.Name = "rbCro";
            this.rbCro.Size = new System.Drawing.Size(64, 17);
            this.rbCro.TabIndex = 6;
            this.rbCro.TabStop = true;
            this.rbCro.Tag = "hr";
            this.rbCro.Text = "Croatian";
            this.rbCro.UseVisualStyleBackColor = true;
            this.rbCro.CheckedChanged += new System.EventHandler(this.rbCro_CheckedChanged);
            // 
            // gbLangauge
            // 
            this.gbLangauge.Controls.Add(this.rbEn);
            this.gbLangauge.Controls.Add(this.rbCro);
            this.gbLangauge.Location = new System.Drawing.Point(88, 162);
            this.gbLangauge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbLangauge.Name = "gbLangauge";
            this.gbLangauge.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbLangauge.Size = new System.Drawing.Size(238, 81);
            this.gbLangauge.TabIndex = 7;
            this.gbLangauge.TabStop = false;
            // 
            // chbIsOnline
            // 
            this.chbIsOnline.AutoSize = true;
            this.chbIsOnline.Location = new System.Drawing.Point(140, 258);
            this.chbIsOnline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbIsOnline.Name = "chbIsOnline";
            this.chbIsOnline.Size = new System.Drawing.Size(130, 17);
            this.chbIsOnline.TabIndex = 9;
            this.chbIsOnline.Text = "Search online for data";
            this.chbIsOnline.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(119, 294);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(187, 35);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Next";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // PopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(412, 340);
            this.ControlBox = false;
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.chbIsOnline);
            this.Controls.Add(this.gbLangauge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbChamp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeadline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PopupForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Config";
            this.gbLangauge.ResumeLayout(false);
            this.gbLangauge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeadline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbChamp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbEn;
        private System.Windows.Forms.RadioButton rbCro;
        private System.Windows.Forms.GroupBox gbLangauge;
        private System.Windows.Forms.CheckBox chbIsOnline;
        private System.Windows.Forms.Button btnOk;
    }
}