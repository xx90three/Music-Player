namespace MusicPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btn_stop = new System.Windows.Forms.Button();
            this.track_list = new System.Windows.Forms.ListBox();
            this.pic_art = new System.Windows.Forms.PictureBox();
            this.track_volume = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.lbl_track_start = new System.Windows.Forms.Label();
            this.lbl_track_end = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(12, 393);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(66, 45);
            this.btn_play.TabIndex = 0;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(84, 393);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(66, 45);
            this.btn_pause.TabIndex = 1;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Location = new System.Drawing.Point(228, 393);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(66, 45);
            this.btn_previous.TabIndex = 2;
            this.btn_previous.Text = "Previous";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(300, 393);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(66, 45);
            this.btn_next.TabIndex = 3;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(372, 393);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(66, 45);
            this.btn_open.TabIndex = 4;
            this.btn_open.Text = "Open Files";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(9, 375);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(560, 12);
            this.progressBar.TabIndex = 5;
            this.progressBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progressBar_MouseDown);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(156, 393);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(66, 45);
            this.btn_stop.TabIndex = 6;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // track_list
            // 
            this.track_list.BackColor = System.Drawing.Color.LightGray;
            this.track_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.track_list.ForeColor = System.Drawing.Color.Black;
            this.track_list.FormattingEnabled = true;
            this.track_list.Location = new System.Drawing.Point(338, 12);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(234, 325);
            this.track_list.TabIndex = 7;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // pic_art
            // 
            this.pic_art.Image = global::MusicPlayer.Properties.Resources.d0c891q2gbrrtanuj0a0m42tpt_f79d79d1dc6f3a7458e923a930189e3e;
            this.pic_art.Location = new System.Drawing.Point(50, 74);
            this.pic_art.Name = "pic_art";
            this.pic_art.Size = new System.Drawing.Size(229, 227);
            this.pic_art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_art.TabIndex = 8;
            this.pic_art.TabStop = false;
            // 
            // track_volume
            // 
            this.track_volume.Location = new System.Drawing.Point(444, 407);
            this.track_volume.Maximum = 100;
            this.track_volume.Name = "track_volume";
            this.track_volume.Size = new System.Drawing.Size(128, 45);
            this.track_volume.TabIndex = 10;
            this.track_volume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.track_volume.Scroll += new System.EventHandler(this.track_volume_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Volume";
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_volume.Location = new System.Drawing.Point(544, 393);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(28, 13);
            this.lbl_volume.TabIndex = 12;
            this.lbl_volume.Text = "100";
            // 
            // lbl_track_start
            // 
            this.lbl_track_start.AutoSize = true;
            this.lbl_track_start.Location = new System.Drawing.Point(12, 356);
            this.lbl_track_start.Name = "lbl_track_start";
            this.lbl_track_start.Size = new System.Drawing.Size(34, 13);
            this.lbl_track_start.TabIndex = 13;
            this.lbl_track_start.Text = "00:00";
            // 
            // lbl_track_end
            // 
            this.lbl_track_end.AutoSize = true;
            this.lbl_track_end.Location = new System.Drawing.Point(538, 356);
            this.lbl_track_end.Name = "lbl_track_end";
            this.lbl_track_end.Size = new System.Drawing.Size(34, 13);
            this.lbl_track_end.TabIndex = 14;
            this.lbl_track_end.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Player
            // 
            this.Player.Dock = System.Windows.Forms.DockStyle.Top;
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(0, 0);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(584, 32);
            this.Player.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 369);
            this.panel1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.lbl_track_end);
            this.Controls.Add(this.lbl_track_start);
            this.Controls.Add(this.lbl_volume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.track_volume);
            this.Controls.Add(this.pic_art);
            this.Controls.Add(this.track_list);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Player);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player";
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.PictureBox pic_art;
        private System.Windows.Forms.TrackBar track_volume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.Label lbl_track_start;
        private System.Windows.Forms.Label lbl_track_end;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.Panel panel1;
    }
}

