using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class MusicPlayer : Form
    {
        public MusicPlayer()
        {
            InitializeComponent();
        }
        //Create global variables of string type array to save the titles or name of the song and path of it
        string[] paths, files;

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {

            //select song
            OpenFileDialog ofd = new OpenFileDialog();
            // select multiple files
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; // save the names of songs in files array
                paths  = ofd.FileNames; //save the path of songs ia path of array
                //display the  music in listbox
                for (int i = 0; i < files.Length; i++)
                {

                    listBoxSongs.Items.Add(files[i]); // display songs in list box
                }
            }
            
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // play music
            if (listBoxSongs.SelectedIndex == null)
            {
                axWindowsMediaPlayerMusic.URL = paths[0];
            } // preventing error that occures index must be  not "-1" when trying do delete soundtrack form library
            else if( listBoxSongs.SelectedIndex != -1)
            {
                axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedItem != null)
            {
                int selectedIndex = listBoxSongs.SelectedIndex;
                var result = MessageBox.Show("Are you sure you want to delete soundtrack?",
                                         "Deleting Soundtrack",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    listBoxSongs.Items.RemoveAt(selectedIndex);
                    List<string> tempPaths = paths.ToList();
                    tempPaths.RemoveAt(selectedIndex);
                    paths = tempPaths.ToArray();
                    axWindowsMediaPlayerMusic.close();
                }
            }

            else
            {
                MessageBox.Show("Please select a soundtrack to delete.");
            }
        }

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
