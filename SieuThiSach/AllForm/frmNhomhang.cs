using SieuThiSach.DAL;
using SieuThiSach.SO;
using SieuThiSach.SystemForm;
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
    public partial class frmNhomhang : Form
    {
        public frmNhomhang()
        {
            InitializeComponent();
        }
        string _pMode = "";
        DataLoading DatLoa = new DataLoading();
        DesignForm DesFor = new DesignForm();
        private void loadData(string _Filter = " where SDUNG = 'C'")
        {
            //DatLoa.loadData("*", "V_NHOM_HANG " + _Filter, ref dataGridView1);
            DatLoa.loadData("*", "TB_NHOM_HANG " + _Filter, ref dataGridView1);
            DesFor.EditCollum(ref dataGridView1, "MA_NHOM_HANG", true, "Mã Nhóm hàng");
            DesFor.EditCollum(ref dataGridView1, "TEN_NHOM_HANG", true, "Tên Nhóm hàng");
            //DesFor.EditCollum(ref dataGridView1, "SO_MAT_HANG", true, "Số Mặt hàng");
            DesFor.EditCollum(ref dataGridView1, "SDUNG", false, "Using");
        }

        private void AddNew()
        {
            string sql = "NHOM_HANG_NHAP N'" + UserInformation.PQ +
                "','" + TxtName.Text.Trim() + "'";

            int _ok = DatLoa.AddNew(sql);
            if (_ok > 0)
            {
                loadData();
                _pMode = "";
                ViewMode();
                DesFor.ColorChange(ref DesFor.BtnChange);
                DesFor.AlignCenterToScreen();
            }
        }

        private void EditData()
        {
            string sql = "NHOM_HANG_EDIT '" + UserInformation.PQ +
                "','" + TxtID.Text.Trim() +
                "',N'" + TxtName.Text.Trim() + "'";
            int _ok = DatLoa.AddNew(sql);
            if (_ok > 0)
            {
                loadData();
                _pMode = "";
                ViewMode();
                DesFor.ColorChange(ref DesFor.BtnChange);
                DesFor.AlignCenterToScreen();
            }
        }

        private void FindData()
        {
            string vFilter = " where SDUNG = 'C'";
            if (TxtID.Text != "")
            {
                vFilter = vFilter + " and MA_NHOM_HANG like '%" + TxtID.Text.Trim() + "%'";
            }
            if (TxtName.Text != "")
            {
                vFilter = vFilter + " and TEN_NHOM_HANG like N'%" + TxtName.Text.Trim() + "%'";
            }
            loadData(vFilter);
            _pMode = "";
            ViewMode();
            DesFor.ColorChange(ref DesFor.BtnChange);
            DesFor.AlignCenterToScreen();
        }

        private void ViewMode()
        {
            switch (_pMode)
            {
                case "ADD":
                    grButton1.Enabled = false;
                    dataGridView1.Enabled = false;
                    this.Height = 440;
                    DesFor.ColorChange(ref btnAdd);
                    #region "Load Text Box Clear"
                    TxtID.Text = "";
                    TxtName.Text = "";
                    TxtID.Enabled = false;
                    #endregion
                    TxtID.Focus();
                    DesFor.AlignCenterToScreen();
                    break;
                case "FIND":
                    grButton1.Enabled = false;
                    dataGridView1.Enabled = false;
                    this.Height = 440;
                    DesFor.ColorChange(ref btnFind);
                    #region "Load Text Box Clear"
                    TxtID.Text = "";
                    TxtName.Text = "";
                    TxtID.Enabled = true;
                    #endregion
                    TxtID.Focus();
                    DesFor.AlignCenterToScreen();
                    break;
                case "EDIT":
                    grButton1.Enabled = false;
                    dataGridView1.Enabled = false;
                    this.Height = 440;
                    DesFor.ColorChange(ref btnEdit);
                    #region "Load Text Box"
                    TxtID.Text = dataGridView1.CurrentRow.Cells["MA_NHOM_HANG"].Value.ToString();
                    TxtName.Text = dataGridView1.CurrentRow.Cells["TEN_NHOM_HANG"].Value.ToString();
                    TxtID.Enabled = false;
                    #endregion
                    TxtName.Focus();
                    DesFor.AlignCenterToScreen();
                    break;
                case "":
                    grButton1.Enabled = true;
                    dataGridView1.Enabled = true;
                    #region "Load Text Box Clear"
                    TxtID.Text = "";
                    TxtName.Text = "";
                    #endregion
                    this.Height = 336;
                    DesFor.AlignCenterToScreen();
                    break;
                default:
                    break;
            }
        }

        //Xử lý trên click trên form-----------------------------------------------------------

        private void frmNhomhang_Load(object sender, EventArgs e)
        {
            DesignForm.vForm = this;
            ViewMode();
            loadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _pMode = "ADD";
            ViewMode();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _pMode = "EDIT";
            ViewMode();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            _pMode = "FIND";
            ViewMode();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _pMode = "";
            ViewMode();
            DesFor.ColorChange(ref DesFor.BtnChange);
            DesFor.AlignCenterToScreen();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            switch (_pMode)
            {
                case "ADD":
                    AddNew();
                    break;
                case "EDIT":
                    EditData();
                    break;
                case "FIND":
                    FindData();
                    break;
                default:
                    break;
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            btnEdit_Click(sender, e);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            using (frmImExQuestion excQ = new frmImExQuestion())
            {
                DialogResult dlr = excQ.ShowDialog();
                if (dlr == DialogResult.Yes)
                {
                    using (OpenFileDialog ofd = new OpenFileDialog()) //Mở form chọn file (form hệ thống)
                    {
                        ofd.Filter = "Các tệp excel|*.xlsx|Tất cả các tệp|*.*"; //Lọc file .excel
                        if (ofd.ShowDialog() == DialogResult.OK) //Kiểm tra tệp có được chọn không ?
                        {
                            using (frmExecl exc = new frmExecl()) //Mở form load Excel
                            {
                                exc.datagoc = dataGridView1;
                                exc.FilePath = ofd.FileName;
                                exc.table = "TB_NHOM_HANG";
                                if (exc.ShowDialog() == DialogResult.OK) frmNhomhang_Load(sender, e);
                            }
                        }
                    }
                }
                else if (dlr == DialogResult.No)
                {
                    using (SaveFileDialog sfd = new SaveFileDialog())
                    {
                        sfd.Filter = "Các tệp excel|*.xlsx|Tất cả các tệp|*.*"; //Lọc file .excel
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            Excel.Application app = new Excel.Application();//Tạo excel app                        
                            Excel.Workbook wb = app.Workbooks.Add(Type.Missing);//tạo workbook                       
                            Excel.Worksheet sheet = null;//tạo sheet
                            //Excel.Range Cells;
                            try
                            {
                                //đọc dữ liệu từ dtg ra excel
                                sheet = wb.ActiveSheet;
                                sheet.Name = "Dữ liệu xuất";
                                sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, dataGridView1.Columns.Count]].Merge();
                                sheet.Cells[1, 1].Value = "Danh sách Nhóm hàng";
                                sheet.Cells[1, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; //căn giữa
                                sheet.Cells[1, 1].Font.Size = 20; //Cỡ chữ
                                sheet.Cells[1, 1].Borders.Weight = Excel.XlBorderWeight.xlThin;
                                //Sinh cột
                                for (int i = 1; i <= dataGridView1.Columns.Count; i++)
                                {
                                    sheet.Cells[2, i] = dataGridView1.Columns[i - 1].HeaderText;
                                    sheet.Cells[2, i].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                                    sheet.Cells[2, i].Font.Bold = true;
                                    sheet.Cells[2, i].Borders.Weight = Excel.XlBorderWeight.xlThin;
                                }
                                //Sinh dữ liệu
                                //sheet.Columns[4].NumberFormat = "@";//Chuyển về dạng text
                                for (int i = 1; i <= dataGridView1.Rows.Count; i++)
                                {
                                    for (int j = 1; j <= dataGridView1.Columns.Count; j++)
                                    {
                                        sheet.Cells[i + 2, j] = dataGridView1.Rows[i - 1].Cells[j - 1].Value.ToString();
                                        sheet.Cells[i + 2, j].Borders.weight = Excel.XlBorderWeight.xlThin;
                                        if (j == 3) // tinh chỉnh cột 3
                                        {
                                            sheet.Cells[i + 2, j].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; //căn lề phải
                                        }
                                    }
                                }
                                wb.SaveAs(sfd.FileName);
                                MessageBox.Show("Lưu tập tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi lưu tệp tin\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                app.Quit();
                                //wb = null;
                            }
                        }
                    }
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (DatLoa.DelData("NHOM_HANG_EDIT_SDUNG", ref dataGridView1, "MA_NHOM_HANG", "TEN_NHOM_HANG", "SDUNG") > 0)
                loadData();
        }

        //Xử lý trên key trên form-----------------------------------------------------------

        private void frmNhomhang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N) btnAdd.PerformClick();
            else if (e.Control && e.KeyCode == Keys.E) btnEdit.PerformClick();
            else if (e.Control && e.KeyCode == Keys.F) btnFind.PerformClick();
            else if (e.Control && e.KeyCode == Keys.H) btnHistory.PerformClick();
            else if (e.Control && e.KeyCode == Keys.L) btnExcel.PerformClick();
            else if (e.KeyCode == Keys.Delete) btnDel.PerformClick();
            else if (e.KeyCode == Keys.Escape)
            {
                if (_pMode == "") this.Close();
                else btnCancel.PerformClick();
            }
        }

        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.Parse(e.KeyChar.ToString().ToUpper());
        }

        //Trả giá trị về 
        public string NH_ID
        {
            get
            {
                if (dataGridView1.Rows.Count <= 0) return "";
                else return dataGridView1.CurrentRow.Cells["MA_NHOM_HANG"].Value.ToString();
            }
        }

        private void frmNhomhang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    }
}
