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
            this.SuspendLayout();
            // 
            // selectMP3Button
            // 
            this.selectMP3Button.Location = new System.Drawing.Point(9, 229);
            this.selectMP3Button.Margin = new System.Windows.Forms.Padding(0);
            this.selectMP3Button.Name = "selectMP3Button";
            this.selectMP3Button.Size = new System.Drawing.Size(221, 23);
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
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID3 version";
            // 
            // versionTextBox
            // 
            this.versionTextBox.Location = new System.Drawing.Point(120, 12);
            this.versionTextBox.Name = "versionTextBox";
            this.versionTextBox.ReadOnly = true;
            this.versionTextBox.Size = new System.Drawing.Size(110, 20);
            this.versionTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unsynchronization";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Extended header";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Experimental";
            // 
            // unsynchronizationTextBox
            // 
            this.unsynchronizationTextBox.Location = new System.Drawing.Point(120, 38);
            this.unsynchronizationTextBox.Name = "unsynchronizationTextBox";
            this.unsynchronizationTextBox.ReadOnly = true;
            this.unsynchronizationTextBox.Size = new System.Drawing.Size(110, 20);
            this.unsynchronizationTextBox.TabIndex = 7;
            // 
            // extendedHeaderTextBox
            // 
            this.extendedHeaderTextBox.Location = new System.Drawing.Point(120, 64);
            this.extendedHeaderTextBox.Name = "extendedHeaderTextBox";
            this.extendedHeaderTextBox.ReadOnly = true;
            this.extendedHeaderTextBox.Size = new System.Drawing.Size(110, 20);
            this.extendedHeaderTextBox.TabIndex = 8;
            // 
            // experimentalTextBox
            // 
            this.experimentalTextBox.Location = new System.Drawing.Point(120, 90);
            this.experimentalTextBox.Name = "experimentalTextBox";
            this.experimentalTextBox.ReadOnly = true;
            this.experimentalTextBox.Size = new System.Drawing.Size(110, 20);
            this.experimentalTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID3 tag size";
            // 
            // tagSizeTextBox
            // 
            this.tagSizeTextBox.Location = new System.Drawing.Point(120, 116);
            this.tagSizeTextBox.Name = "tagSizeTextBox";
            this.tagSizeTextBox.ReadOnly = true;
            this.tagSizeTextBox.Size = new System.Drawing.Size(110, 20);
            this.tagSizeTextBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 261);
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
            this.Name = "Form1";
            this.Text = "ID3 Info";
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
    }
}

