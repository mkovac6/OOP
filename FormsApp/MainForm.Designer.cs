﻿
namespace FormsApp
{
    partial class MainForm
    {//glavni prozor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveSelection = new System.Windows.Forms.Button();
            this.cbTeams = new System.Windows.Forms.ComboBox();
            this.pnlAll = new System.Windows.Forms.FlowLayoutPanel();
            this.cmsSendToFavourites = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToFavouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFav = new System.Windows.Forms.FlowLayoutPanel();
            this.cmsSendToAll = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeFromFavouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveFavourites = new System.Windows.Forms.Button();
            this.btnTopScorers = new System.Windows.Forms.Button();
            this.btnYellowCards = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.pnlRankings = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.msSettings = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.cmsSendToFavourites.SuspendLayout();
            this.cmsSendToAll.SuspendLayout();
            this.msSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSaveSelection
            // 
            resources.ApplyResources(this.btnSaveSelection, "btnSaveSelection");
            this.btnSaveSelection.Name = "btnSaveSelection";
            this.btnSaveSelection.UseVisualStyleBackColor = true;
            this.btnSaveSelection.Click += new System.EventHandler(this.btnSaveSelection_Click);
            // 
            // cbTeams
            // 
            resources.ApplyResources(this.cbTeams, "cbTeams");
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Name = "cbTeams";
            // 
            // pnlAll
            // 
            this.pnlAll.AllowDrop = true;
            resources.ApplyResources(this.pnlAll, "pnlAll");
            this.pnlAll.ContextMenuStrip = this.cmsSendToFavourites;
            this.pnlAll.Name = "pnlAll";
            this.pnlAll.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlAll_DragDrop);
            this.pnlAll.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlAll_DragEnter);
            // 
            // cmsSendToFavourites
            // 
            this.cmsSendToFavourites.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsSendToFavourites.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToFavouritesToolStripMenuItem});
            this.cmsSendToFavourites.Name = "cmsSendToFavourites";
            resources.ApplyResources(this.cmsSendToFavourites, "cmsSendToFavourites");
            // 
            // addToFavouritesToolStripMenuItem
            // 
            this.addToFavouritesToolStripMenuItem.Name = "addToFavouritesToolStripMenuItem";
            resources.ApplyResources(this.addToFavouritesToolStripMenuItem, "addToFavouritesToolStripMenuItem");
            this.addToFavouritesToolStripMenuItem.Click += new System.EventHandler(this.addToFavouritesToolStripMenuItem_Click);
            // 
            // pnlFav
            // 
            this.pnlFav.AllowDrop = true;
            resources.ApplyResources(this.pnlFav, "pnlFav");
            this.pnlFav.ContextMenuStrip = this.cmsSendToAll;
            this.pnlFav.Name = "pnlFav";
            this.pnlFav.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlFav_DragDrop);
            this.pnlFav.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlFav_DragEnter);
            // 
            // cmsSendToAll
            // 
            this.cmsSendToAll.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsSendToAll.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeFromFavouritesToolStripMenuItem});
            this.cmsSendToAll.Name = "cmsSendToAll";
            resources.ApplyResources(this.cmsSendToAll, "cmsSendToAll");
            // 
            // removeFromFavouritesToolStripMenuItem
            // 
            this.removeFromFavouritesToolStripMenuItem.Name = "removeFromFavouritesToolStripMenuItem";
            resources.ApplyResources(this.removeFromFavouritesToolStripMenuItem, "removeFromFavouritesToolStripMenuItem");
            this.removeFromFavouritesToolStripMenuItem.Click += new System.EventHandler(this.removeFromFavouritesToolStripMenuItem_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnSaveFavourites
            // 
            resources.ApplyResources(this.btnSaveFavourites, "btnSaveFavourites");
            this.btnSaveFavourites.Name = "btnSaveFavourites";
            this.btnSaveFavourites.UseVisualStyleBackColor = true;
            this.btnSaveFavourites.Click += new System.EventHandler(this.btnSaveFavourites_Click);
            // 
            // btnTopScorers
            // 
            resources.ApplyResources(this.btnTopScorers, "btnTopScorers");
            this.btnTopScorers.Name = "btnTopScorers";
            this.btnTopScorers.UseVisualStyleBackColor = true;
            this.btnTopScorers.Click += new System.EventHandler(this.btnTopScorers_Click);
            // 
            // btnYellowCards
            // 
            resources.ApplyResources(this.btnYellowCards, "btnYellowCards");
            this.btnYellowCards.Name = "btnYellowCards";
            this.btnYellowCards.UseVisualStyleBackColor = true;
            this.btnYellowCards.Click += new System.EventHandler(this.btnYellowCards_Click);
            // 
            // btnAttendance
            // 
            resources.ApplyResources(this.btnAttendance, "btnAttendance");
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // pnlRankings
            // 
            resources.ApplyResources(this.pnlRankings, "pnlRankings");
            this.pnlRankings.Name = "pnlRankings";
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument
            // 
            this.printDocument.DocumentName = "Football Ranking";
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // msSettings
            // 
            this.msSettings.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            resources.ApplyResources(this.msSettings, "msSettings");
            this.msSettings.Name = "msSettings";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.msSettings);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pnlRankings);
            this.Controls.Add(this.btnAttendance);
            this.Controls.Add(this.btnYellowCards);
            this.Controls.Add(this.btnTopScorers);
            this.Controls.Add(this.btnSaveFavourites);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlFav);
            this.Controls.Add(this.pnlAll);
            this.Controls.Add(this.cbTeams);
            this.Controls.Add(this.btnSaveSelection);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msSettings;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.cmsSendToFavourites.ResumeLayout(false);
            this.cmsSendToAll.ResumeLayout(false);
            this.msSettings.ResumeLayout(false);
            this.msSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveSelection;
        private System.Windows.Forms.ComboBox cbTeams;
        private System.Windows.Forms.FlowLayoutPanel pnlAll;
        private System.Windows.Forms.FlowLayoutPanel pnlFav;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip cmsSendToFavourites;
        private System.Windows.Forms.ToolStripMenuItem addToFavouritesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsSendToAll;
        private System.Windows.Forms.ToolStripMenuItem removeFromFavouritesToolStripMenuItem;
        private System.Windows.Forms.Button btnSaveFavourites;
        private System.Windows.Forms.Button btnTopScorers;
        private System.Windows.Forms.Button btnYellowCards;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.FlowLayoutPanel pnlRankings;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.MenuStrip msSettings;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.Label label4;
    }
}

