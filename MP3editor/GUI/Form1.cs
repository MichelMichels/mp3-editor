using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicImplementation;
using DataEntities;

namespace GUI
{
    public partial class Form1 : Form
    {
        Logic logic = new Logic();

        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void PrintInfo(ID3Tag tag)
        {
            // Iterate all the frames
            foreach (ID3Frame frame in tag.Frames)
            {
                // Row item
                if (frame.ID == "TALB")
                {
                    albumTextBox.Text = frame.GetDataString();
                } else if (frame.ID == "TIT2")
                {
                    songTextBox.Text = frame.GetDataString();
                } else if (frame.ID == "TPE2")
                {
                    artistTextBox.Text = frame.GetDataString();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // song var
                ID3Tag tag = new ID3Tag();

                // Get filename of selected file
                string fileName = openFileDialog1.FileName;

                // Write first bytes
                tag = logic.GetID3Tag(fileName);

                if (tag.Header.TagSize != 0)
                {
                    // Print in GUI
                    PrintInfo(tag);
                } else
                {
                    ClearTextBoxes();
                    MessageBox.Show("The selected file has no valid ID3 tag.");
                }
           }
        }

        private void ClearTextBoxes()
        {
            artistTextBox.Clear();
            albumTextBox.Clear();
            songTextBox.Clear();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
