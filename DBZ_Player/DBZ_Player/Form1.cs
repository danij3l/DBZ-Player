using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBZ_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        string[] files, paths;

        private void Playlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Play the song 
            wmp.URL = paths[Playlist.SelectedIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Save only the names
                files = openFileDialog1.SafeFileNames;
                // Save the full paths
                paths = openFileDialog1.FileNames;

                for (int i = 0; i < files.Length; i++)
                {
                    // Add songs to the listbox(Playlist)
                    Playlist.Items.Add(files[i]);
                }
            }
        }

        private void TableLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        // todos:::
        // add remove song from playlist button

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
