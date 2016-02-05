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

        private void selectMP3Button_click (object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // song var
                ID3Tag tag = new ID3Tag();
                
                // Get filename of selected file
                string fileName = openFileDialog1.FileName;

                // Write first bytes
                tag = logic.GetID3Tag(fileName);

                tag.PrintFrames();

                // Write in GUI
                versionTextBox.Text = $"ID3v2.{tag.Header.MajorVersion}.{tag.Header.RevisionNumber}";
                unsynchronizationTextBox.Text = $"{tag.Header.UnsynchronisationFlag}";
                extendedHeaderTextBox.Text = $"{tag.Header.ExtendedHeaderFlag}";
                experimentalTextBox.Text = $"{tag.Header.ExperimentalIndicatorFlag}";
                tagSizeTextBox.Text = $"{tag.Header.TagSize} bytes";

            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
