namespace MusicApp
{
    partial class MusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.btnSelectSongs = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayerMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnDelete = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Turquoise;
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Controls.Add(this.lblLogo);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(871, 43);
            this.TopPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(827, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(21, 9);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(123, 22);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Music Player";
            this.lblLogo.Click += new System.EventHandler(this.lblLogo_Click);
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBoxSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.ItemHeight = 20;
            this.listBoxSongs.Location = new System.Drawing.Point(674, 49);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(191, 304);
            this.listBoxSongs.TabIndex = 1;
            this.listBoxSongs.SelectedIndexChanged += new System.EventHandler(this.listBoxSongs_SelectedIndexChanged);
            // 
            // btnSelectSongs
            // 
            this.btnSelectSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSelectSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSongs.ForeColor = System.Drawing.Color.White;
            this.btnSelectSongs.Location = new System.Drawing.Point(674, 370);
            this.btnSelectSongs.Name = "btnSelectSongs";
            this.btnSelectSongs.Size = new System.Drawing.Size(191, 49);
            this.btnSelectSongs.TabIndex = 2;
            this.btnSelectSongs.Text = "Select Songs";
            this.btnSelectSongs.UseVisualStyleBackColor = false;
            this.btnSelectSongs.Click += new System.EventHandler(this.btnSelectSongs_Click);
            // 
            // axWindowsMediaPlayerMusic
            // 
            this.axWindowsMediaPlayerMusic.Enabled = true;
            this.axWindowsMediaPlayerMusic.Location = new System.Drawing.Point(0, 34);
            this.axWindowsMediaPlayerMusic.Name = "axWindowsMediaPlayerMusic";
            this.axWindowsMediaPlayerMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerMusic.OcxState")));
            this.axWindowsMediaPlayerMusic.Size = new System.Drawing.Size(504, 291);
            this.axWindowsMediaPlayerMusic.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(674, 425);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(191, 51);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(871, 507);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.axWindowsMediaPlayerMusic);
            this.Controls.Add(this.btnSelectSongs);
            this.Controls.Add(this.listBoxSongs);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusicPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlayer";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMusic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBoxSongs;
        private System.Windows.Forms.Button btnSelectSongs;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerMusic;
        private System.Windows.Forms.Button btnDelete;
    }
}

