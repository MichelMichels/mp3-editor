﻿using System;
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

                // Write in GUI
                WriteInfo(tag);
            }
        }

        private void WriteInfo(ID3Tag tag)
        {
            // Clear listview box
            listView1.Items.Clear();

            versionTextBox.Text = $"ID3v2.{tag.Header.MajorVersion}.{tag.Header.RevisionNumber}";
            unsynchronizationTextBox.Text = $"{tag.Header.UnsynchronisationFlag}";
            extendedHeaderTextBox.Text = $"{tag.Header.ExtendedHeaderFlag}";
            experimentalTextBox.Text = $"{tag.Header.ExperimentalIndicatorFlag}";
            tagSizeTextBox.Text = $"{tag.Header.TagSize} bytes";


            foreach (ID3Frame frame in tag.Frames)
            {
                // Row item
                string[] frameString = { frame.LongID != null ? frame.LongID : "", frame.GetDataString(), frame.ID };
                var lvi = new ListViewItem(frameString);
                listView1.Items.Add(lvi);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
