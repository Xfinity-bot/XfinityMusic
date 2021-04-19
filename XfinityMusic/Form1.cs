using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace XfinityMusic
{
    public partial class musicPLayer : Form
    {
        public musicPLayer()
        {
            InitializeComponent();
            volBar.Value = 50;
        }
        String[]  files;
        List<string> pathm = new List<string>();

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void btn_PlayPause_Click(object sender, EventArgs e)
        {
            if (3 == (int)player.playState)
            {

                player.Ctlcontrols.pause();
                btn_PlayPause.Image = Image.FromFile("./Resources/play-button.png");

            }
            else
            {
                btn_PlayPause.Image = Image.FromFile("./Resources/pause.png");

                player.Ctlcontrols.play();
            }

        }
       

        private void btn_next_Click(object sender, EventArgs e)
        {

            if (queue.SelectedIndex < queue.Items.Count - 1)
            {
                queue.SelectedIndex = queue.SelectedIndex + 1;
            }
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            if (queue.SelectedIndex > 0)
            {
                queue.SelectedIndex = queue.SelectedIndex - 1;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {


                pBar.Value = (int)player.Ctlcontrols.currentPosition;
                pBar.Maximum = (int)player.Ctlcontrols.currentItem.duration;


                try
                {    //var hold= player.Ctlcontrols.currentPosition+1;

                    lb_CurPos.Text = player.Ctlcontrols.currentPositionString;
                    //lb_CurPos.Text = hold.ToString();
                    var holde = player.Ctlcontrols.currentItem.duration - 1;
                    //lb_EndTime.Text = holde.ToString();
                    lb_EndTime.Text = player.Ctlcontrols.currentItem.durationString;
                }
                catch
                {

                }
            }

        }
        
        private void volBar_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = volBar.Value;
            lb_CurVol.Text = player.settings.volume.ToString() + "%";
        }

        private void queue_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = pathm[queue.SelectedIndex];
            player.Ctlcontrols.play();
            btn_PlayPause.Image = Image.FromFile("./Resources/pause.png");

        }

        private void pBar_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / pBar.Width;
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Audio|*.wav;*.aac;*.mp3;*.flac;*.WMV;*.MP3";

            ofd.Multiselect = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                pathm.AddRange(ofd.FileNames);
                for (int x = 0; x < files.Length; x++)
                {
                    queue.Items.Add(Path.GetFileName(files[x]));
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            queue.Items.Clear();
            pathm.Clear();
        }

        private void musicPLayer_Load(object sender, EventArgs e)
        {
            String uname = System.Windows.Forms.SystemInformation.UserName;

            String musicfpath = "C:\\Users\\" + uname + "\\Music";
            String[] filePaths = Directory.GetFiles(musicfpath, "*.mp3*");
            String xp = Directory.GetCurrentDirectory();
            //queue.Items.Add(xp);
            for (int x = 0; x < filePaths.Length; x++)
            {


                queue.Items.Add(Path.GetFileName(filePaths[x]));
                pathm.Add(filePaths[x]);

                //paths.Append(filePaths[x]);
            }
        }
    }
}
