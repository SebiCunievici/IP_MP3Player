namespace MP3Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAvr = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeny = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSebi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPopa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.VideoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.listSongs = new System.Windows.Forms.ListBox();
            this.btnLoadSongs = new System.Windows.Forms.Button();
            this.tabPlaylist1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.boxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1561, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnMenu
            // 
            this.btnMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAbout,
            this.btnExit});
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(60, 24);
            this.btnMenu.Text = "Menu";
            // 
            // btnAbout
            // 
            this.btnAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAvr,
            this.btnDeny,
            this.btnSebi,
            this.btnPopa});
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(224, 26);
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnAvr
            // 
            this.btnAvr.Name = "btnAvr";
            this.btnAvr.Size = new System.Drawing.Size(256, 26);
            this.btnAvr.Text = "Avramescu Andrei";
            this.btnAvr.Click += new System.EventHandler(this.btnAvr_Click);
            // 
            // btnDeny
            // 
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(256, 26);
            this.btnDeny.Text = "Ciobanu Maria-Denisa";
            this.btnDeny.Click += new System.EventHandler(this.btnDeny_Click);
            // 
            // btnSebi
            // 
            this.btnSebi.Name = "btnSebi";
            this.btnSebi.Size = new System.Drawing.Size(256, 26);
            this.btnSebi.Text = "Cunievici Petru Sebastian";
            this.btnSebi.Click += new System.EventHandler(this.btnSebi_Click);
            // 
            // btnPopa
            // 
            this.btnPopa.Name = "btnPopa";
            this.btnPopa.Size = new System.Drawing.Size(256, 26);
            this.btnPopa.Text = "Popa Alexandru Șerban";
            this.btnPopa.Click += new System.EventHandler(this.btnPopa_Click);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(224, 26);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // VideoPlayer
            // 
            this.VideoPlayer.Enabled = true;
            this.VideoPlayer.Location = new System.Drawing.Point(12, 31);
            this.VideoPlayer.Name = "VideoPlayer";
            this.VideoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoPlayer.OcxState")));
            this.VideoPlayer.Size = new System.Drawing.Size(881, 520);
            this.VideoPlayer.TabIndex = 3;
            this.VideoPlayer.Enter += new System.EventHandler(this.VideoPlayer_Enter);
            // 
            // listSongs
            // 
            this.listSongs.FormattingEnabled = true;
            this.listSongs.ItemHeight = 16;
            this.listSongs.Location = new System.Drawing.Point(1224, 40);
            this.listSongs.Name = "listSongs";
            this.listSongs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listSongs.Size = new System.Drawing.Size(281, 564);
            this.listSongs.TabIndex = 4;
            this.listSongs.SelectedIndexChanged += new System.EventHandler(this.listSongs_SelectedIndexChanged);
            // 
            // btnLoadSongs
            // 
            this.btnLoadSongs.Location = new System.Drawing.Point(1224, 620);
            this.btnLoadSongs.Name = "btnLoadSongs";
            this.btnLoadSongs.Size = new System.Drawing.Size(281, 60);
            this.btnLoadSongs.TabIndex = 5;
            this.btnLoadSongs.Text = "Load files";
            this.btnLoadSongs.UseVisualStyleBackColor = true;
            this.btnLoadSongs.Click += new System.EventHandler(this.btnLoadSongs_Click);
            // 
            // tabPlaylist1
            // 
            this.tabPlaylist1.Location = new System.Drawing.Point(4, 25);
            this.tabPlaylist1.Name = "tabPlaylist1";
            this.tabPlaylist1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlaylist1.Size = new System.Drawing.Size(658, 84);
            this.tabPlaylist1.TabIndex = 0;
            this.tabPlaylist1.Text = "Playlist 1";
            this.tabPlaylist1.UseVisualStyleBackColor = true;
            this.tabPlaylist1.Click += new System.EventHandler(this.tabPlaylist1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPlaylist1);
            this.tabControl1.Location = new System.Drawing.Point(12, 727);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(666, 113);
            this.tabControl1.TabIndex = 6;
            // 
            // boxSearch
            // 
            this.boxSearch.Location = new System.Drawing.Point(723, 752);
            this.boxSearch.Name = "boxSearch";
            this.boxSearch.Size = new System.Drawing.Size(193, 22);
            this.boxSearch.TabIndex = 7;
            this.boxSearch.TextChanged += new System.EventHandler(this.boxSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(743, 788);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 48);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search in the current playlist";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1099, 757);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(130, 62);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(1235, 757);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(132, 62);
            this.btnPrevious.TabIndex = 10;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(1373, 757);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(132, 62);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove Song";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(13, 692);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(71, 17);
            this.lblFileName.TabIndex = 12;
            this.lblFileName.Text = "File Name";
            this.lblFileName.Click += new System.EventHandler(this.lblFileName_Click);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(1089, 692);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(82, 17);
            this.lblDuration.TabIndex = 13;
            this.lblDuration.Text = "Duration : 0";
            this.lblDuration.Click += new System.EventHandler(this.lblDuration_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(963, 757);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(130, 62);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Create new playlist";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 1055);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.boxSearch);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnLoadSongs);
            this.Controls.Add(this.listSongs);
            this.Controls.Add(this.VideoPlayer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MP3Player";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnMenu;
        private System.Windows.Forms.ToolStripMenuItem btnAbout;
        private System.Windows.Forms.ToolStripMenuItem btnAvr;
        private System.Windows.Forms.ToolStripMenuItem btnDeny;
        private System.Windows.Forms.ToolStripMenuItem btnSebi;
        private System.Windows.Forms.ToolStripMenuItem btnPopa;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private AxWMPLib.AxWindowsMediaPlayer VideoPlayer;
        private System.Windows.Forms.ListBox listSongs;
        private System.Windows.Forms.Button btnLoadSongs;
        private System.Windows.Forms.TabPage tabPlaylist1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox boxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Button btnCreate;
    }
}

