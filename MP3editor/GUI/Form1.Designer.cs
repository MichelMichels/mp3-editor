namespace GUI
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
            this.selectMP3Button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.versionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.unsynchronizationTextBox = new System.Windows.Forms.TextBox();
            this.extendedHeaderTextBox = new System.Windows.Forms.TextBox();
            this.experimentalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tagSizeTextBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.longIdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.frameID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectMP3Button
            // 
            this.selectMP3Button.Location = new System.Drawing.Point(592, 722);
            this.selectMP3Button.Margin = new System.Windows.Forms.Padding(0);
            this.selectMP3Button.Name = "selectMP3Button";
            this.selectMP3Button.Size = new System.Drawing.Size(321, 35);
            this.selectMP3Button.TabIndex = 0;
            this.selectMP3Button.Text = "Select MP3 file";
            this.selectMP3Button.UseVisualStyleBackColor = true;
            this.selectMP3Button.Click += new System.EventHandler(this.selectMP3Button_click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID3 version";
            // 
            // versionTextBox
            // 
            this.versionTextBox.Location = new System.Drawing.Point(180, 18);
            this.versionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.versionTextBox.Name = "versionTextBox";
            this.versionTextBox.ReadOnly = true;
            this.versionTextBox.Size = new System.Drawing.Size(229, 26);
            this.versionTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unsynchronization";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Extended header";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Experimental";
            // 
            // unsynchronizationTextBox
            // 
            this.unsynchronizationTextBox.Location = new System.Drawing.Point(180, 54);
            this.unsynchronizationTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.unsynchronizationTextBox.Name = "unsynchronizationTextBox";
            this.unsynchronizationTextBox.ReadOnly = true;
            this.unsynchronizationTextBox.Size = new System.Drawing.Size(229, 26);
            this.unsynchronizationTextBox.TabIndex = 7;
            // 
            // extendedHeaderTextBox
            // 
            this.extendedHeaderTextBox.Location = new System.Drawing.Point(606, 18);
            this.extendedHeaderTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.extendedHeaderTextBox.Name = "extendedHeaderTextBox";
            this.extendedHeaderTextBox.ReadOnly = true;
            this.extendedHeaderTextBox.Size = new System.Drawing.Size(306, 26);
            this.extendedHeaderTextBox.TabIndex = 8;
            // 
            // experimentalTextBox
            // 
            this.experimentalTextBox.Location = new System.Drawing.Point(605, 54);
            this.experimentalTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.experimentalTextBox.Name = "experimentalTextBox";
            this.experimentalTextBox.ReadOnly = true;
            this.experimentalTextBox.Size = new System.Drawing.Size(306, 26);
            this.experimentalTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID3 tag size";
            // 
            // tagSizeTextBox
            // 
            this.tagSizeTextBox.Location = new System.Drawing.Point(180, 90);
            this.tagSizeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tagSizeTextBox.Name = "tagSizeTextBox";
            this.tagSizeTextBox.ReadOnly = true;
            this.tagSizeTextBox.Size = new System.Drawing.Size(229, 26);
            this.tagSizeTextBox.TabIndex = 11;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.longIdColumn,
            this.data,
            this.frameID});
            this.listView1.Location = new System.Drawing.Point(22, 139);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(889, 288);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // longIdColumn
            // 
            this.longIdColumn.Text = "Long ID";
            this.longIdColumn.Width = 192;
            // 
            // data
            // 
            this.data.Text = "Data";
            this.data.Width = 262;
            // 
            // frameID
            // 
            this.frameID.Text = "ID";
            this.frameID.Width = 53;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(22, 433);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(889, 269);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(457, 26);
            this.textBox1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Artist";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 771);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tagSizeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.experimentalTextBox);
            this.Controls.Add(this.extendedHeaderTextBox);
            this.Controls.Add(this.unsynchronizationTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.versionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectMP3Button);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "ID3 Info";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectMP3Button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox versionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox unsynchronizationTextBox;
        private System.Windows.Forms.TextBox extendedHeaderTextBox;
        private System.Windows.Forms.TextBox experimentalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tagSizeTextBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader frameID;
        private System.Windows.Forms.ColumnHeader data;
        private System.Windows.Forms.ColumnHeader longIdColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}

