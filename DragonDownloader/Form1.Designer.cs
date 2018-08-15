using System;
using System.Drawing;

namespace Downloader
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.BackColor = Color.FromArgb(246, 246, 246);
            this.tbURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSaveTo = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.mtbStart = new System.Windows.Forms.MaskedTextBox();
            this.mtbEnd = new System.Windows.Forms.MaskedTextBox();
            this.mtbformat = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(53, 7);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(531, 20);
            this.tbURL.TabIndex = 0;
            this.tbURL.BackColor = Color.White;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Format:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Start:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "End:";
            // 
            // tbSaveTo
            // 
            this.tbSaveTo.Location = new System.Drawing.Point(74, 47);
            this.tbSaveTo.Name = "tbSaveTo";
            this.tbSaveTo.Size = new System.Drawing.Size(362, 20);
            this.tbSaveTo.TabIndex = 8;
            this.tbSaveTo.BackColor = Color.White;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Save to:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Download";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(23, 126);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(536, 23);
            this.progressBar1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Extension:";
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(398, 21);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(119, 20);
            this.tbFile.TabIndex = 13;
            this.tbFile.Text = "jpg";
            this.tbFile.BackColor = Color.White;
            // 
            // mtbStart
            // 
            this.mtbStart.Location = new System.Drawing.Point(74, 21);
            this.mtbStart.Mask = "0000000";
            this.mtbStart.Name = "mtbStart";
            this.mtbStart.Size = new System.Drawing.Size(47, 20);
            this.mtbStart.TabIndex = 15;
            // 
            // mtbEnd
            // 
            this.mtbEnd.Location = new System.Drawing.Point(173, 21);
            this.mtbEnd.Mask = "0000000";
            this.mtbEnd.Name = "mtbEnd";
            this.mtbEnd.Size = new System.Drawing.Size(47, 20);
            this.mtbEnd.TabIndex = 16;
            // 
            // mtbformat
            // 
            this.mtbformat.Location = new System.Drawing.Point(274, 21);
            this.mtbformat.Mask = "000000000";
            this.mtbformat.Name = "mtbformat";
            this.mtbformat.Size = new System.Drawing.Size(47, 20);
            this.mtbformat.TabIndex = 17;
            this.mtbformat.Text = "0000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbStart);
            this.groupBox1.Controls.Add(this.mtbformat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mtbEnd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbSaveTo);
            this.groupBox1.Controls.Add(this.tbFile);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(34, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 83);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.tbURL);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-11, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 122);
            this.panel1.TabIndex = 19;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 155);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(536, 95);
            this.listBox1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 286);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DragonDownloader";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

    

        #endregion

        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSaveTo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.MaskedTextBox mtbStart;
        private System.Windows.Forms.MaskedTextBox mtbEnd;
        private System.Windows.Forms.MaskedTextBox mtbformat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

