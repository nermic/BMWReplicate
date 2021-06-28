using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMWReplicate
{
    public partial class frmReplicate : Form
    {
        public frmReplicate()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBrowseSource_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = folderBrowserDialogSource.ShowDialog(); 
            if (result == DialogResult.OK) 
            {
                string file = folderBrowserDialogSource.SelectedPath;
                try
                {
                    txtSource.Text = file;
                }
                catch (IOException)
                {
                }
            }

        }

        private void btnBrowseDestination_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = folderBrowserDialogDestination.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = folderBrowserDialogDestination.SelectedPath;
                try
                {
                    txtDestination.Text = file;
                }
                catch (IOException)
                {
                }
            }
        }

        private void btnReplicate_Click(object sender, EventArgs e)
        {
            // Invoke FindFiles() recursive function
            if (string.IsNullOrEmpty(txtSource.Text))
            {
                MessageBox.Show("Please select a Source folder");
                return;
            }
            if (string.IsNullOrEmpty(txtDestination.Text))
            {
                MessageBox.Show("Please select a Destination folder");
                return;
            }
            string SourcePath = txtSource.Text;
            string DestinationPath = txtDestination.Text;

            ReplicateFiles(SourcePath, DestinationPath, chkIncludeSub.Checked);
        }

        private bool ReplicateFiles(string SourcePath, string DestinationPath, bool includeSubs)
        {
            //// Loop thru each file in the current directory and print it's name
            ////System.IO.StreamWriter writer = new System.IO.StreamWriter(@"C:\Thabo\BMW\logFile.txt"); //open the file for writing.
            //foreach (string fileName in Directory.GetFiles(SourcePath))
            //{
            //    Console.WriteLine(fileName);
            //    using (StreamWriter sw = File.AppendText(@"C:\Thabo\BMW\logFile.txt"))
            //    {
            //        sw.WriteLine(fileName);
            //    }

            //}

            //// If there is a subdirectory in the current directory, then recursively 
            //// call FindFiles() method. The recursion will break when the innermost 
            //// directory with no subdirectory is found.
            //if (includeSubs)
            //{
            //    foreach (string directory in Directory.GetDirectories(SourcePath))
            //    {
            //        // Notice that FindFiles() is calling itself
            //        DirectoryInfo directoryInfo = new DirectoryInfo(directory);
            //        ReplicateFiles(directory, DestinationPath + directoryInfo.Name, includeSubs);
            //    } 
            //}

            SourcePath = SourcePath.EndsWith(@"\") ? SourcePath : SourcePath + @"\";
            DestinationPath = DestinationPath.EndsWith(@"\") ? DestinationPath : DestinationPath + @"\";

            try
            {
                if (Directory.Exists(SourcePath))
                {
                    if (Directory.Exists(DestinationPath) == false)
                    {
                        Directory.CreateDirectory(DestinationPath);
                    }

                    progressBar1.Value = 1;
                    progressBar1.Minimum = 1;
                    progressBar1.Step = 1;
                    progressBar1.Maximum = Directory.GetFiles(SourcePath).Length;


                    foreach (string files in Directory.GetFiles(SourcePath))
                    {
                       
                        FileInfo fileInfo = new FileInfo(files);
                        if (File.Exists(DestinationPath + fileInfo.Name))
                        {
                            FileInfo fileInfo2 = new FileInfo(DestinationPath + fileInfo.Name);
                            if (fileInfo.LastWriteTime != fileInfo2.LastWriteTime)
                            {
                                fileInfo.CopyTo(string.Format(@"{0}\{1}", DestinationPath, fileInfo.Name), true);
                                progressBar1.PerformStep();
                                using (StreamWriter sw = File.AppendText(@"C:\Thabo\BMW\logFile.txt"))
                                {
                                    sw.WriteLine(string.Format(@"Copy file from  {0} to {1}", SourcePath + fileInfo.Name, DestinationPath + fileInfo.Name));
                                }
                            }
                           
                        }
                        else
                        {
                            fileInfo.CopyTo(string.Format(@"{0}\{1}", DestinationPath, fileInfo.Name), true);
                            progressBar1.PerformStep();
                            using (StreamWriter sw = File.AppendText(@"C:\Thabo\BMW\logFile.txt"))
                            {
                                sw.WriteLine(string.Format(@"Copy file from  {0} to {1}", SourcePath + fileInfo.Name, DestinationPath + fileInfo.Name));
                            }
                        }
                       
                    }

                    foreach (string drs in Directory.GetDirectories(SourcePath))
                    {
                        DirectoryInfo directoryInfo = new DirectoryInfo(drs);
                        if (ReplicateFiles(drs, DestinationPath + directoryInfo.Name, includeSubs) == false)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        private void btnViewLog_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Thabo\BMW\logFile.txt");
        }
    }
}
