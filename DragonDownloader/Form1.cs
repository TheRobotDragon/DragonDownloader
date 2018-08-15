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
        //for MacOs version to keep it correctly. No fixed VErsion on Mono
        void Handle_SizeChanged(object sender, EventArgs e)
        {
            Size = originalSize;
        }
        Size originalSize = new Size();
        public Form1()
        {
            InitializeComponent();
            originalSize = Size;
            this.SizeChanged += Handle_SizeChanged;
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
                        var file = $"{cont.ToString(mtbformat.Text)}.{tbFile.Text}";
                        var path = Path.Combine(tbSaveTo.Text, file);
                        try
                        {
                            wc.DownloadFile(address, path);

                        progressBar1.Invoke((MethodInvoker)delegate { progressBar1.Value = cont; });

                            listBox1.Items.Add($"File {file} was downloaded.");
                        }
                        catch(HttpListenerException exhttp)
                        {
                            listBox1.Items.Add($"Download Error - {exhttp.Message}");
                        }
                        catch(Exception ex)
                        {
                            listBox1.Items.Add($"Unexpected Error - {ex.Message}");
                        }
                    }
                }
            }
            catch(Exception ex)
            { 
                listBox1.Items.Add($"Unexpected Error - {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
