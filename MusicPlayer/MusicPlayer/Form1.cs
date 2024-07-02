using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            track_volume.Value = 50;
            lbl_volume.Text = "50";
        }

        string[] paths, files;

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player.URL = paths[track_list.SelectedIndex];
            Player.Ctlcontrols.play();
            try
            {
                var file = TagLib.File.Create(paths[track_list.SelectedIndex]);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                pic_art.Image = Image.FromStream(new MemoryStream(bin));
            }
            catch { }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
            progressBar.Value = 0;
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex < track_list.Items.Count -1)
            {
                track_list.SelectedIndex = track_list.SelectedIndex + 1;
            }
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            if(track_list.SelectedIndex>0)
            {
                track_list.SelectedIndex = track_list.SelectedIndex - 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar.Maximum = (int)Player.Ctlcontrols.currentItem.duration;
                progressBar.Value = (int)Player.Ctlcontrols.currentPosition;

                try
                {
                    lbl_track_start.Text = Player.Ctlcontrols.currentPositionString;
                    lbl_track_end.Text = Player.Ctlcontrols.currentItem.durationString.ToString();
                }
                catch
                {

                }
            }
        }

        private void track_volume_Scroll(object sender, EventArgs e)
        {
            Player.settings.volume = track_volume.Value;    
            lbl_volume.Text = track_volume.Value.ToString();
        }

        private void progressBar_MouseDown(object sender, MouseEventArgs e)
        {
            Player.Ctlcontrols.currentPosition = Player.currentMedia.duration * e.X / progressBar.Width;
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = openFileDialog.FileNames;
                paths = openFileDialog.FileNames;
                for (int x = 0; x < files.Length; x++)
                {
                    track_list.Items.Add(files[x]);
                }
            }
        }
    }
}
