namespace SerializedDataSetViewer
{
    partial class SerializedDataSetViewer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerializedDataSetViewer));
            this.bttnOpen = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWarning = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataSetViewer1 = new SerializedDataSetViewerControls.DataSetViewer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnOpen
            // 
            this.bttnOpen.Image = global::SerializedDataSetViewer.Properties.Resources.FolderOpened_16x;
            this.bttnOpen.Location = new System.Drawing.Point(412, 18);
            this.bttnOpen.Name = "bttnOpen";
            this.bttnOpen.Size = new System.Drawing.Size(94, 29);
            this.bttnOpen.TabIndex = 0;
            this.bttnOpen.UseVisualStyleBackColor = true;
            this.bttnOpen.Click += new System.EventHandler(this.bttnOpen_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(13, 18);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(393, 27);
            this.txtFolder.TabIndex = 1;
            this.txtFolder.TextChanged += new System.EventHandler(this.txtFolder_TextChanged);
            // 
            // lbFiles
            // 
            this.lbFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.ItemHeight = 20;
            this.lbFiles.Location = new System.Drawing.Point(0, 0);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(300, 925);
            this.lbFiles.TabIndex = 2;
            this.lbFiles.SelectedIndexChanged += new System.EventHandler(this.lbFiles_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblWarning);
            this.panel1.Controls.Add(this.txtFolder);
            this.panel1.Controls.Add(this.bttnOpen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1552, 64);
            this.panel1.TabIndex = 3;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(567, 27);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(220, 20);
            this.lblWarning.TabIndex = 2;
            this.lblWarning.Text = "Warning: Loaded max 1000 files";
            this.lblWarning.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 64);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbFiles);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataSetViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(1552, 925);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 4;
            // 
            // dataSetViewer1
            // 
            this.dataSetViewer1.DataSet = null;
            this.dataSetViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataSetViewer1.Location = new System.Drawing.Point(0, 0);
            this.dataSetViewer1.Name = "dataSetViewer1";
            this.dataSetViewer1.Size = new System.Drawing.Size(1248, 925);
            this.dataSetViewer1.TabIndex = 0;
            // 
            // SerializedDataSetViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 989);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SerializedDataSetViewer";
            this.Text = "Serialized DataSet Viewer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnOpen;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private SerializedDataSetViewerControls.DataSetViewer dataSetViewer1;
        private System.Windows.Forms.Label lblWarning;
    }
}

