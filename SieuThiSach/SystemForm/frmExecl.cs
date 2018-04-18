using SieuThiSach.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace SieuThiSach.AllForm
{
    public partial class frmExecl : Form
    {
        public frmExecl()
        {
            InitializeComponent();
        }
        public string table;
        public string FilePath;
        DataLoading DatLoa = new DataLoading();

        private void LoadExcel(int sh, int colnam, int dat)
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook wb = app.Workbooks.Open(FilePath);
            try
            {
                Excel._Worksheet sheet = wb.Sheets[sh];
                Excel.Range range = sheet.UsedRange;//tham chiếu vùng dữ liệu
                //đọc dữ liệu
                int rows = range.Rows.Count;
                int cols = range.Columns.Count;
                #region "Load Tên cột"
                if (colnam > 0)
                {
                    for (int c = 1; c <= cols; c++)
                    {
                        string columnname = range.Cells[colnam, c].Value ?? string.Empty.ToString();
                        dataGridView1.Columns.Add("" + (c - 1), columnname);
                    }
                }
                else
                {
                    for (int c = 1; c <= cols; c++)
                    {
                        string columnname = "No Name";
                        dataGridView1.Columns.Add("" + (c - 1), columnname);
                    }
                }
                #endregion

                #region "Load Dữ liệu"
                for (int i = dat; i <= rows; i++)
                {
                    DataGridViewRow dr = new DataGridViewRow();
                    for (int j = 1; j <= cols; j++)
                    {
                        DataGridViewCell _cell = new DataGridViewTextBoxCell();
                        _cell.Value = range.Cells[i, j].Value ?? string.Empty.ToString();
                        dr.Cells.Add(_cell);
                    }
                    dataGridView1.Rows.Add(dr);
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                app.Quit();
                wb = null;
            }
        }
        private void frmExecl_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            checkBtn();
            LoadExcel(Convert.ToInt16(txtWS.Text), Convert.ToInt16(txtColNam.Text), Convert.ToInt16(txtDat.Text));
        }

        private void checkBtn()
        {
            if (cbxWS.CheckState == CheckState.Checked) txtWS.Enabled = true;
            else { txtWS.Enabled = false; txtWS.Text = "1"; }
            if (cbxColNam.CheckState == CheckState.Checked) txtColNam.Enabled = true;
            else { txtColNam.Enabled = false; txtColNam.Text = "1"; }
            if (cbxDat.CheckState == CheckState.Checked) txtDat.Enabled = true;
            else { txtDat.Enabled = false; txtDat.Text = "2"; }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int i = DatLoa.InsExc(table, ref dataGridView1);
                if (i == 1)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void cbxWS_CheckedChanged(object sender, EventArgs e)
        {
            checkBtn();
        }

        private void cbxColNam_CheckedChanged(object sender, EventArgs e)
        {
            checkBtn();
        }

        private void cbxDat_CheckedChanged(object sender, EventArgs e)
        {
            checkBtn();
        }

        private void txtWS_TextChanged(object sender, EventArgs e)
        {
            frmExecl_Load(sender, e);
        }

        private void txtColNam_TextChanged(object sender, EventArgs e)
        {
            frmExecl_Load(sender, e);
        }

        private void txtDat_TextChanged(object sender, EventArgs e)
        {
            frmExecl_Load(sender, e);
        }
    }
}
