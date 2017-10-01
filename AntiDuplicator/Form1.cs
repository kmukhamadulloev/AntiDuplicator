using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace AntiDuplicator
{
    public partial class ad : Form
    {
        public string appName = "AntiDuplicator";

        private class FileEntry
        {
            public string name;
            public string size;
            public string hash;
            public string date;
            public string path;
            public string color;

            public FileEntry(string name, string size, string hash, string date, string path)
            {
                this.name = name;
                this.size = size;
                this.hash = hash;
                this.date = date;
                this.path = path;
                this.color = "white";
            }

            public bool isEqualName(FileEntry fe)
            {
                return this.name == fe.name;
            }

            public bool isEqualHash(FileEntry fe)
            {
                return this.hash == fe.hash;
            }

            public string compareWith(FileEntry fe)
            {
                if (this.isEqualName(fe) && this.isEqualHash(fe))
                {
                    this.color = "red";
                    return this.color;
                }

                if (this.isEqualName(fe))
                {
                    this.color = "yellow";
                    return this.color;
                }

                if (this.isEqualHash(fe))
                {
                    this.color = "orange";
                    return this.color;
                }

                return null;
            }
        }

        private class ScanProgress
        {
            public int current;
            public int total;
            public string status;

            public ScanProgress(int current, int total, string status)
            {
                this.current = current;
                this.total = total;
                this.status = status;
            }

            public ScanProgress(int current, int total)
            {
                this.current = current;
                this.total = total;
                this.status = "";
            }
        }

        public ad()
        {
            InitializeComponent();

            this.Text = appName;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            addScanPath.ShowDialog();
            scanPath.Text = addScanPath.SelectedPath.ToString();
        }

        private void scanAction_Click(object sender, EventArgs e)
        {
            if (scanPath.Text == "")
            {
                MessageBox.Show("There is no path, please set path");
            }
            else
            {
                scanProcess.RunWorkerAsync();
            }
            /*List<List<string>> number = new List<List<string>>();
            for (int j = 0; j < 10; j++)
            {
                number.Add(new List<string>());
                number[j].Add("low: 10");
                number[j].Add("high: 20");
                MessageBox.Show(number[j][1].ToString());
            }*/
        }

        private void scanProcess_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = (BackgroundWorker)sender;
            string[] scannedFilePath = Directory.GetFiles(scanPath.Text, "*.*", SearchOption.AllDirectories);
            var entries = new List<FileEntry>();

            for (int i = 0; i <= scannedFilePath.Length - 1; i++ )
            {
                string scannedFile = scannedFilePath[i];
                string scannedFileName = Path.GetFileName(scannedFile);
                FileInfo scannedFileInfo = new FileInfo(scannedFile);
                int scannedFileSize = Convert.ToInt32(scannedFileInfo.Length / 1024);
                string scannedFileMD5Hash = "";
                byte[] inputBytes;
                using (var md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(scannedFile))
                    {
                        inputBytes = md5.ComputeHash(stream);
                        StringBuilder strMd5 = new StringBuilder();
                        for (int j = 0; j < inputBytes.Length; j++)
                        {
                            strMd5.Append(inputBytes[j].ToString("x2"));
                        }

                        scannedFileMD5Hash = strMd5.ToString();
                    }
                }
                string scannedFileDate = File.GetCreationTime(scannedFile).ToString();

                FileEntry fData = new FileEntry(scannedFileName, scannedFileSize.ToString(), scannedFileMD5Hash, scannedFileDate, scannedFilePath[i]);
                foreach (var en in entries)
                {
                    if (fData.compareWith(en) != null) break;
                };

                entries.Add(fData);

                int length = scannedFilePath.Length - 1;
                var progress = new ScanProgress(i, length);
                bw.ReportProgress((i * 100) / length, progress);
            }

            // MessageBox.Show(outputData.Count.ToString());
            
            // var scanResult = outputData.ToArray();
            // e.Result = scanResult;
            e.Result = entries;
        }

        private void scanProcess_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ScanProgress state = (ScanProgress)e.UserState;

            this.Text = String.Format(
                "{0} | Progress: {1} / {2} ({3}%)",
                appName,
                state.current,
                state.total,
                e.ProgressPercentage
            );
        }

        private void scanProcess_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ad.ActiveForm.Text = appName;

            // var outData = (List<string>[])e.Result;
            var outData = (List<FileEntry>)e.Result;

            for (int i = 0; i < outData.Count; i++)
            {
                // filesGrid.Rows.Add(outData[i][0], outData[i][1], outData[i][2], outData[i][3], outData[i][4]);
                filesGrid.Rows.Add(outData[i].name, outData[i].size, outData[i].hash, outData[i].date, outData[i].path);
                for (int cellNum = 0; cellNum < filesGrid.Rows[i].Cells.Count; cellNum++)
                {
                    filesGrid.Rows[i].Cells[cellNum].Style.BackColor = Color.FromName(outData[i].color);
                }
            }
        }
    }
}
