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

        public string FilePath;

        private void LoadExcel()
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook wb = app.Workbooks.Open(FilePath);
            try
            {
                Excel._Worksheet sheet = wb.Sheets[1];
                Excel.Range range = sheet.UsedRange;//tham chiếu vùng dữ liệu
                //đọc dữ liệu
                int rows = range.Rows.Count;
                int cols = range.Columns.Count;
                //Đọc dòng tiêu đề để tạo cột trong listview
                for (int c = 1; c <= cols; c++)
                {
                    string columnname = range.Cells[1, c].Value.ToString();
                    ColumnHeader col = new ColumnHeader();
                    col.Text = columnname;
                    col.Width = 120;
                    lstExcel.Columns.Add(col);
                }
                //dữ liệu
                for (int i = 2; i < rows; i++)
                {
                    ListViewItem item = new ListViewItem();
                    for (int j = 1; j <= cols; j++)
                    {
                        if (j == 1) item.Text = range.Cells[i, j].Value.ToString();
                        else item.SubItems.Add(range.Cells[i, j].Value.ToString());
                    }
                    lstExcel.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmExecl_Load(object sender, EventArgs e)
        {
            LoadExcel();
        }
    }
}
