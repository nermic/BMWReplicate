
namespace BMWReplicate
{
    partial class frmReplicate
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
            this.chkIncludeSub = new System.Windows.Forms.CheckBox();
            this.btnReplicate = new System.Windows.Forms.Button();
            this.btnViewLog = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.btnBrowseSource = new System.Windows.Forms.Button();
            this.btnBrowseDestination = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialogSource = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogDestination = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // chkIncludeSub
            // 
            this.chkIncludeSub.AutoSize = true;
            this.chkIncludeSub.Location = new System.Drawing.Point(134, 134);
            this.chkIncludeSub.Name = "chkIncludeSub";
            this.chkIncludeSub.Size = new System.Drawing.Size(136, 17);
            this.chkIncludeSub.TabIndex = 0;
            this.chkIncludeSub.Text = "Include Sub Directories";
            this.chkIncludeSub.UseVisualStyleBackColor = true;
            // 
            // btnReplicate
            // 
            this.btnReplicate.Location = new System.Drawing.Point(134, 175);
            this.btnReplicate.Name = "btnReplicate";
            this.btnReplicate.Size = new System.Drawing.Size(75, 23);
            this.btnReplicate.TabIndex = 1;
            this.btnReplicate.Text = "&Replicate";
            this.btnReplicate.UseVisualStyleBackColor = true;
            this.btnReplicate.Click += new System.EventHandler(this.btnReplicate_Click);
            // 
            // btnViewLog
            // 
            this.btnViewLog.Location = new System.Drawing.Point(134, 280);
            this.btnViewLog.Name = "btnViewLog";
            this.btnViewLog.Size = new System.Drawing.Size(75, 23);
            this.btnViewLog.TabIndex = 2;
            this.btnViewLog.Text = "View &Log";
            this.btnViewLog.UseVisualStyleBackColor = true;
            this.btnViewLog.Click += new System.EventHandler(this.btnViewLog_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(655, 280);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(134, 233);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(596, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(134, 42);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(512, 20);
            this.txtSource.TabIndex = 5;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(134, 86);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(512, 20);
            this.txtDestination.TabIndex = 6;
            // 
            // btnBrowseSource
            // 
            this.btnBrowseSource.Location = new System.Drawing.Point(655, 40);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.btnBrowseSource.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSource.TabIndex = 7;
            this.btnBrowseSource.Text = "Browse";
            this.btnBrowseSource.UseVisualStyleBackColor = true;
            this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowseSource_Click);
            // 
            // btnBrowseDestination
            // 
            this.btnBrowseDestination.Location = new System.Drawing.Point(655, 86);
            this.btnBrowseDestination.Name = "btnBrowseDestination";
            this.btnBrowseDestination.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseDestination.TabIndex = 8;
            this.btnBrowseDestination.Text = "Browse";
            this.btnBrowseDestination.UseVisualStyleBackColor = true;
            this.btnBrowseDestination.Click += new System.EventHandler(this.btnBrowseDestination_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Progress Bar";
            // 
            // frmReplicate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 331);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowseDestination);
            this.Controls.Add(this.btnBrowseSource);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewLog);
            this.Controls.Add(this.btnReplicate);
            this.Controls.Add(this.chkIncludeSub);
            this.Name = "frmReplicate";
            this.Text = "Replicate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkIncludeSub;
        private System.Windows.Forms.Button btnReplicate;
        private System.Windows.Forms.Button btnViewLog;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button btnBrowseSource;
        private System.Windows.Forms.Button btnBrowseDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSource;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogDestination;
    }
}

