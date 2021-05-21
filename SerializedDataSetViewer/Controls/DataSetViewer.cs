using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerializedDataSetViewerControls
{
    public partial class DataSetViewer : UserControl
    {
        public DataSetViewer()
        {
            InitializeComponent();
        }

        private DataSet ds;

        public DataSet DataSet
        {
            get
            {
                return ds;
            }
            set
            {
                ds = value;
                if (ds == null || ds.Tables.Count==0)
                {
                    tsTable.Text = "No tables to select";
                }
                populateTables();
            }
        }

        private static string GetDTText(DataTable dt) {
            return dt.TableName + " { " + dt.Rows.Count.ToString() + "}";
        }


        private void populateTables()
        {
            tsTable.DropDownItems.Clear();
            if (ds != null)
            {
                var sortedTables = ds.Tables.Cast<DataTable>().OrderBy(item => item.TableName).ToList();
                foreach (DataTable dt in sortedTables)
                {
                    var ddTable = new ToolStripMenuItem(GetDTText(dt)) { Tag = dt.TableName } ;
                    tsTable.DropDownItems.Add(ddTable);
                    ddTable.Click += DdTable_Click;
                }
                if (sortedTables.Count > 0)
                {
                    viewDT(sortedTables[0]);
                }
            }
        }

        private void viewDT(DataTable dt)
        {
            dgv.DataSource = dt;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            tsTable.Text = GetDTText(dt);
        }

        private void DdTable_Click(object sender, EventArgs e)
        {
            var item = (ToolStripItem)sender;
            viewDT(ds.Tables[(string)item.Tag]);
        }

        private void tsCopy_Click(object sender, EventArgs e)
        {
            SerializedDataSetViewer.Common.CopyDataGridViewToClipboard(dgv);
        }
    }
}
