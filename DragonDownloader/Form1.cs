using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            tbSaveTo.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += Bw_DoWork;
            bw.RunWorkerCompleted += Bw_RunWorkerCompleted;
            bw.RunWorkerAsync();
            panel1.Enabled = false;

        }

        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            panel1.Invoke((MethodInvoker)delegate { panel1.Enabled = true; }); 
        }

        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            //int start = 0;
            //int end = 0;
            //if (!int.TryParse(tbStart.Text, out start))
            //    MessageBox.Show("Start value must be filled correctly");
            //if(!int.TryParse(tbEnd.Text, out end))
            //     MessageBox.Show("Start value must be filled correctly");

            progressBar1.Invoke((MethodInvoker)delegate { progressBar1.Maximum = int.Parse(mtbEnd.Text); });
            try
            {
                using (WebClient wc = new WebClient())
                {
                    for (int cont = int.Parse(mtbStart.Text); cont < int.Parse(mtbEnd.Text); cont++)
                    {
                        var address = tbURL.Text.Replace("@", $"{cont.ToString(mtbformat.Text)}");
                        var path = Path.Combine(tbSaveTo.Text, $"{cont.ToString(mtbformat.Text)}.{tbFile.Text}");
                        try
                        {
                            wc.DownloadFile(address, path);

                        progressBar1.Invoke((MethodInvoker)delegate { progressBar1.Value = cont; });
                            
                        }
                        catch(Exception ex)
                        {

                        }
                    }
                }
            }
            catch(Exception ex)
            { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
