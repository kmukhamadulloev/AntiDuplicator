using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntiDuplicator
{
    public partial class Form1 : Form
    {
        public string appName;
        public string scanPath;
        public string actionName;

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
                this.name = size;
                this.name = hash;
                this.name = date;
                this.name = path;
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

            public bool isEqualPath(FileEntry fe)
            {
                return this.path == fe.path;
            }

            public string compareWith(FileEntry fe)
            {
                if (this.isEqualPath(fe) && this.isEqualHash(fe) && this.isEqualName(fe))
                {
                    this.color = "green";
                    return this.color;
                }
                else if (this.isEqualName(fe) && this.isEqualHash(fe))
                {
                    this.color = "red";
                    return this.color;
                } else if (this.isEqualHash(fe))
                {
                    this.color = "orange";
                    return this.color;
                } else if (this.isEqualName(fe))
                {
                    this.color = "yellow";
                    return this.color;
                }

                return null;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            appName = this.Text;
        }

        private void setPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setScanPath.ShowDialog();
            scanPath = setScanPath.SelectedPath.ToString();
        }

        private void scanForFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (scanPath != null && scanPath != "")
            {
                if (!backActions.IsBusy)
                {
                    backActions.RunWorkerAsync();
                    actionName = "scan";
                }
                else
                {
                    MessageBox.Show("Please wait, till analyser complete its job!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please set scan directory!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                setPathToolStripMenuItem_Click(sender, e);
            }
        }

        private void backActions_DoWork(object sender, DoWorkEventArgs e)
        {
            switch(actionName)
            {
                case "scan":
                    
                    break;
                case "duplicates":

                    break;
                case "delete":
                    MessageBox.Show(actionName);
                    break;
                case "search":
                    MessageBox.Show(actionName);
                    break;
                default :
                    MessageBox.Show("No Action defined", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
