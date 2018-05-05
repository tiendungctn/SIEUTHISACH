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
    public partial class frmMatHang : Form
    {
        public frmMatHang()
        {
            InitializeComponent();
        }
        string _pMode = "";
        DataLoading DatLoa = new DataLoading();
        DesignForm DesFor = new DesignForm();
        public string _Filter = " where MA_DVI = '" + UserInformation.MaDV + "' and SDUNG = 'C' ";
        private void loadData()
        {
            DatLoa.loadData("*", "V_MAT_HANG " + _Filter, ref dataGridView1);
            DesFor.EditCollum(ref dataGridView1, "MA_DVI", false, "Mã đơn vị");
            DesFor.EditCollum(ref dataGridView1, "MA_HANG", true, "Mã hàng");
            DesFor.EditCollum(ref dataGridView1, "TEN_HANG", true, "Tên hàng");
            DesFor.EditCollum(ref dataGridView1, "NHOM_HANG", false, "Nhóm");
            DesFor.EditCollum(ref dataGridView1, "TEN_NHOM_HANG", true, "Nhóm");
            DesFor.EditCollum(ref dataGridView1, "NHA_CC", false, "Nhà cung cấp");
            DesFor.EditCollum(ref dataGridView1, "TEN_KH", true, "Nhà cung cấp");
            DesFor.EditCollum(ref dataGridView1, "GIA_NHAP", true, "Giá nhập");
            DesFor.EditCollum(ref dataGridView1, "GIA_BAN", true, "Giá bán");
            DesFor.EditCollum(ref dataGridView1, "SDUNG", false, "Sdung");
        }

        private void AddNew()
        {
            string sql = "MAT_HANG_NHAP '" + UserInformation.MaDV +
                "',N'" + TxtID.Text.Trim() +
                "',N'" + TxtName.Text.Trim() +
                "','" + TxtNhomHang.Text +
                "','" + TxtNhaCC.Text +
                "','" + TxtGiaNhap.Text.Trim() +
                "','" + TxtGiaBan.Text.Trim() + "'";

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
            string sql = "MAT_HANG_EDIT '" + UserInformation.MaDV +
                "',N'" + TxtID.Text.Trim() +
                "',N'" + TxtName.Text.Trim() +
                "','" + TxtNhomHang.Text +
                "','" + TxtNhaCC.Text +
                "','" + TxtGiaNhap.Text.Trim() +
                "','" + TxtGiaBan.Text.Trim() + "'";
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
            string vFilter = " where MA_DVI = '" + UserInformation.MaDV + "' and SDUNG = 'C' ";
            if (TxtID.Text != "")
            {
                vFilter = vFilter + " and MA_HANG like '%" + TxtID.Text.Trim() + "%'";
            }
            if (TxtName.Text != "")
            {
                vFilter = vFilter + " and TEN_HANG like N'%" + TxtName.Text.Trim() + "%'";
            }
            if (TxtNhomHang.Text != "")
            {
                vFilter = vFilter + " and NHOM_HANG like N'%" + TxtNhomHang.Text + "%'";
            }
            if (TxtNhaCC.Text != "")
            {
                vFilter = vFilter + " and NHA_CC like '%" + TxtNhaCC.Text + "%'";
            }
            if (TxtGiaNhap.Text != "")
            {
                vFilter = vFilter + " and GIA_NHAP = " + TxtGiaNhap.Text.Trim();
            }
            if (TxtGiaBan.Text != "")
            {
                vFilter = vFilter + " and GIA_BAN like " + TxtGiaBan.Text.Trim();
            }
            _Filter = vFilter;
            loadData();
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
                    TxtNhomHang.Text = "";
                    TxtGiaNhap.Text = "";
                    TxtGiaBan.Text = "";
                    TxtNhaCC.Text = "";
                    TxtID.Enabled = true;
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
                    TxtNhomHang.Text = "";
                    TxtGiaNhap.Text = "";
                    TxtGiaBan.Text = "";
                    TxtNhaCC.Text = "";
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
                    TxtID.Text = dataGridView1.CurrentRow.Cells["MA_HANG"].Value.ToString();
                    TxtName.Text = dataGridView1.CurrentRow.Cells["TEN_HANG"].Value.ToString();
                    TxtNhomHang.Text = dataGridView1.CurrentRow.Cells["NHOM_HANG"].Value.ToString();
                    TxtGiaNhap.Text = dataGridView1.CurrentRow.Cells["GIA_NHAP"].Value.ToString();
                    TxtGiaBan.Text = dataGridView1.CurrentRow.Cells["GIA_BAN"].Value.ToString();
                    TxtNhaCC.Text = dataGridView1.CurrentRow.Cells["NHA_CC"].Value.ToString();
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
                    TxtNhomHang.Text = "";
                    TxtGiaNhap.Text = "";
                    TxtGiaBan.Text = "";
                    TxtNhaCC.Text = "";
                    TxtID.Enabled = true;
                    #endregion
                    this.Height = 336;
                    DesFor.AlignCenterToScreen();
                    break;
                default:
                    break;
            }
        }

        //Xử lý trên click trên form-----------------------------------------------------------

        private void frmMatHang_Load(object sender, EventArgs e)
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            btnEdit_Click(sender, e);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (DatLoa.DelData2key("MAT_HANG_EDIT_SDUNG", ref dataGridView1, "MA_HANG", "TEN_HANG", "SDUNG") > 0)
                loadData();
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
                                exc.table = "TB_MAT_HANG";
                                if (exc.ShowDialog() == DialogResult.OK) frmMatHang_Load(sender, e);
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
                                #region Sinh Tiêu đề
                                sheet.Range[sheet.Cells[1, 2], sheet.Cells[1, dataGridView1.Columns.Count]].Merge();
                                sheet.Cells[1, 2].Value = "Danh sách Mặt hàng của " + DatLoa.NameReturn("TEN_DVI", "TB_DVI", "MA_DVI='" + UserInformation.MaDV + "'");
                                sheet.Cells[1, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; //căn giữa
                                sheet.Cells[1, 2].Font.Size = 20; //Cỡ chữ
                                sheet.Cells[1, 2].Borders.Weight = Excel.XlBorderWeight.xlThin;
                                #endregion

                                #region Sinh cột
                                for (int i = 1; i <= dataGridView1.Columns.Count; i++)
                                {
                                    sheet.Cells[2, i] = dataGridView1.Columns[i - 1].HeaderText;
                                    sheet.Cells[2, i].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                                    sheet.Cells[2, i].Font.Bold = true;
                                    sheet.Cells[2, i].Borders.Weight = Excel.XlBorderWeight.xlThin;

                                }
                                #endregion

                                #region Sinh dữ liệu
                                //sheet.Columns[4].NumberFormat = "@";//chuyển về dạng text
                                for (int i = 1; i <= dataGridView1.Rows.Count; i++)
                                {
                                    for (int j = 1; j <= dataGridView1.Columns.Count; j++)
                                    {
                                        sheet.Cells[i + 2, j] = dataGridView1.Rows[i - 1].Cells[j - 1].Value.ToString();
                                        sheet.Cells[i + 2, j].Borders.weight = Excel.XlBorderWeight.xlThin;
                                        if (j == 10) // tinh chỉnh cột 4
                                        {
                                            sheet.Cells[i + 2, j].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; //căn lề phải
                                        }
                                    }
                                }
                                sheet.Columns[6].Delete(); sheet.Columns[4].Delete(); sheet.Columns[1].Delete();
                                #endregion

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

        private void btnHistory_Click(object sender, EventArgs e)
        {
            frmHistory htr = new frmHistory();
            frmHistory.TB_History = "TB_MAT_HANG_HISTORY ";
            #region "Load Tên Cột HISTORY"
            htr.namecolumns.Add("Mã Đơn Vị");
            htr.namecolumns.Add("Mã Hàng");
            htr.namecolumns.Add("Tên Hàng");
            htr.namecolumns.Add("Nhóm Hàng");
            htr.namecolumns.Add("Nhà Cung Cấp");
            htr.namecolumns.Add("Giá Nhập");
            htr.namecolumns.Add("Giá bán");
            htr.namecolumns.Add("Sử dụng");
            htr.namecolumns.Add("Thời gian sửa");
            htr.namecolumns.Add("Người sửa");
            htr.namecolumns.Add("Ghi chú");
            #endregion
            #region "LOAD ID FIND"
            htr.ID1 = "MA_DVI";
            htr.ID2 = "MA_HANG";
            #endregion
            htr.ShowDialog();
        }


        //Xử lý trên key trên form-----------------------------------------------------------
        private void frmMatHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N) btnAdd.PerformClick();
            else if (e.Control && e.KeyCode == Keys.E) btnEdit.PerformClick();
            else if (e.Control && e.KeyCode == Keys.F) btnFind.PerformClick();
            else if (e.Control && e.KeyCode == Keys.L) btnExcel.PerformClick();
            else if (e.KeyCode == Keys.Escape)
            {
                if (_pMode == "") this.Close();
                else btnCancel.PerformClick();
            }
        }

        private void TxtNhomHang_TextChanged(object sender, EventArgs e)
        {
            lblNhomHang.Text = DatLoa.NameReturn("TEN_NHOM_HANG", "TB_NHOM_HANG", "MA_NHOM_HANG = '" + TxtNhomHang.Text + "'");
        }

        private void TxtNhaCC_TextChanged(object sender, EventArgs e)
        {
            lblNhaCC.Text = DatLoa.NameReturn("TEN_KH", "TB_KHACH_HANG", "MA_KH = '" + TxtNhaCC.Text + "'");
        }

        private void TxtNhomHang_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    e.SuppressKeyPress = true;
                    using (frmNhomhang f = new frmNhomhang())
                    {
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            TxtNhomHang.Text = f.NH_ID;
                        }
                        DesignForm.vForm = this;
                    }
                    break;
            }
        }

        private void TxtNhaCC_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    e.SuppressKeyPress = true;
                    using (frmKhachHang f = new frmKhachHang())
                    {
                        f._Filter = " where MA_KH like '%CC%'";
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            TxtNhaCC.Text = f.KH_ID;
                        }
                        DesignForm.vForm = this;
                    }
                    break;
            }
        }

        private void TxtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void TxtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.Parse(e.KeyChar.ToString().ToUpper());
        }

        private void TxtNhomHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.Parse(e.KeyChar.ToString().ToUpper());
        }

        private void TxtNhaCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.Parse(e.KeyChar.ToString().ToUpper());
        }

        private void TxtGiaNhap_Validated(object sender, EventArgs e)
        {
            TxtGiaBan.Text = Convert.ToString(Convert.ToInt64(TxtGiaNhap.Text) + Convert.ToInt64(TxtGiaNhap.Text) / 10);
        }

        //Trả giá trị về -----------------------------------------------------------
        public string BranchID
        {
            get
            {
                if (dataGridView1.Rows.Count <= 0) return "";
                else return dataGridView1.CurrentRow.Cells["MA_HANG"].Value.ToString();
            }
        }

        private void frmMatHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    }
}
