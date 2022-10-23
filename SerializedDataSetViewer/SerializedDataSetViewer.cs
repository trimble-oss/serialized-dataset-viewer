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
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json.Bson;
using Microsoft.Extensions.Configuration;

namespace SerializedDataSetViewer
{
    public partial class SerializedDataSetViewer : Form
    {
        public SerializedDataSetViewer()
        {
            InitializeComponent();
        }

        private void BttnOpen_Click(object sender, EventArgs e)
        {
            using var fbd = new FolderBrowserDialog() { AutoUpgradeEnabled = false, SelectedPath=txtFolder.Text  };
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtFolder.Text = fbd.SelectedPath;
            }
        }
   

        private void LoadFiles()
        {
            string folder = txtFolder.Text;
            lbFiles.Items.Clear();
            lblWarning.Visible = false;
            if (Directory.Exists(folder))
            {
                int i = 0;
                foreach(var f in Directory.EnumerateFiles(folder, "*.xml",SearchOption.TopDirectoryOnly))
                {
                    lbFiles.Items.Add(Path.GetFileName(f));
                    i += 1;
                    if (i >= 1000)
                    {
                        lblWarning.Visible = true;
                        break;
                    }

                }
            }
        }


        //https://stackoverflow.com/questions/1869853/overcoming-net-problem-of-displaying-binary-columns-in-a-datagridview
        private static void MorphBinaryColumns(DataTable table)
        {
            var targetNames = table.Columns.Cast<DataColumn>()
              .Where(col => col.DataType.Equals(typeof(byte[])))
              .Select(col => col.ColumnName).ToList();
            foreach (string colName in targetNames)
            {
                // add new column and put it where the old column was
                var tmpName = "¬new";
                table.Columns.Add(new DataColumn(tmpName, typeof(string)));
                table.Columns[tmpName].SetOrdinal(table.Columns[colName].Ordinal);

                // fill in values in new column for every row
                foreach (DataRow row in table.Rows)
                {
                    if (row[colName] != DBNull.Value)
                    {
                        row[tmpName] = "0x" + string.Join("",
                          ((byte[])row[colName]).Select(b => b.ToString("X2")).ToArray());
                    }
                }

                // cleanup
                table.Columns.Remove(colName);
                table.Columns[tmpName].ColumnName = colName;
            }
        }

        private static void MorphBinaryColumns(DataSet ds)
        {
            foreach(DataTable t in ds.Tables)
            {
                MorphBinaryColumns(t);
            }
        }

        private void LbFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filePath =Path.Combine(txtFolder.Text,(string)lbFiles.SelectedItem);
            if (File.Exists(filePath))
            {
                try
                {
                    var ds = new DataSet();
                    ds.ReadXml(filePath);
                    MorphBinaryColumns(ds);
                    dataSetViewer1.DataSet = ds;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TxtFolder_TextChanged(object sender, EventArgs e)
        {
            LoadFiles();
        }

        private void SerializedDataSetViewer_Load(object sender, EventArgs e)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json").Build();
            this.Text = "Serialized DataSet Viewer " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(3);
            txtFolder.Text = config.GetValue<string>("DefaultPath");
        }
    }
}
