using SieuThiSach.CrystalReport;
using SieuThiSach.DAL;
using SieuThiSach.SO;
using SieuThiSach.SystemForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace SieuThiSach.AllForm
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        string _pMode = "";
        DataLoading DatLoa = new DataLoading();
        DesignForm DesFor = new DesignForm();
        public string _Filter = " where MA_KH != 'KH00000'";
        private void loadData()
        {
            DatLoa.loadData("*", "TB_KHACH_HANG " + _Filter, ref dataGridView1);
            DesFor.EditCollum(ref dataGridView1, "MA_KH", true, "Mã khách hàng");
            DesFor.EditCollum(ref dataGridView1, "TEN_KH", true, "Tên khách hàng");
            DesFor.EditCollum(ref dataGridView1, "DIA_CHI", true, "Địa chỉ");
            DesFor.EditCollum(ref dataGridView1, "SDT", true, "Số điện thoại");
            DesFor.EditCollum(ref dataGridView1, "EMAIL", true, "Email");
            DesFor.EditCollum(ref dataGridView1, "TTHAI", true, "Trạng thái");
            DesFor.EditCollum(ref dataGridView1, "LOAI", false, "Loại");
        }

        private void AddNew()
        {
            string sql = "KHACH_HANG_NHAP '" + UserInformation.PQ +
                "',N'" + TxtName.Text.Trim() +
                "',N'" + txtDiaChi.Text.Trim() +
                "','" + TxtSDT.Text.Trim() +
                "','" + txtEmail.Text.Trim() +
                "','" + cbbLoai.Text.Trim() +
                "'," + txtTThai.Text.Trim();

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
            string sql = "KHACH_HANG_EDIT '" + UserInformation.PQ +
                "','" + TxtID.Text.Trim() +
                "',N'" + TxtName.Text.Trim() +
                "',N'" + txtDiaChi.Text.Trim() +
                "','" + TxtSDT.Text.Trim() +
                "','" + txtEmail.Text.Trim() +
                "','" + cbbLoai.Text.Trim() + "'";
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
            string vFilter = " Where MA_KH != 'KH00000'";
            if (TxtID.Text != "")
            {
                vFilter = vFilter + " and MA_KH like '%" + TxtID.Text.Trim() + "%'";
            }
            if (TxtName.Text != "")
            {
                vFilter = vFilter + " and TEN_KH like N'%" + TxtName.Text.Trim() + "%'";
            }
            if (txtDiaChi.Text != "")
            {
                vFilter = vFilter + " and DIA_CHI like N'%" + txtDiaChi.Text.Trim() + "%'";
            }
            if (TxtSDT.Text != "")
            {
                vFilter = vFilter + " and SDT like '%" + TxtSDT.Text.Trim() + "%'";
            }
            if (txtEmail.Text != "")
            {
                vFilter = vFilter + " and EMAIL like '%" + txtEmail.Text.Trim() + "%'";
            }
            if (cbbLoai.Text != "")
            {
                vFilter = vFilter + " and LOAI like '%" + cbbLoai.Text.Trim() + "%'";
            }
            if (txtTThai.Text != "")
            {
                vFilter = vFilter + " and TTHAI like '%" + txtTThai.Text.Trim() + "%'";
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
                    txtDiaChi.Text = "";
                    TxtSDT.Text = "";
                    txtEmail.Text = "";
                    cbbLoai.Text = "";
                    txtTThai.Text = "1";
                    txtTThai.Enabled = false;
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
                    txtDiaChi.Text = "";
                    TxtSDT.Text = "";
                    txtEmail.Text = "";
                    cbbLoai.Text = "";
                    txtTThai.Text = "";
                    txtTThai.Enabled = true;
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
                    TxtID.Text = dataGridView1.CurrentRow.Cells["MA_KH"].Value.ToString();
                    TxtName.Text = dataGridView1.CurrentRow.Cells["TEN_KH"].Value.ToString();
                    txtDiaChi.Text = dataGridView1.CurrentRow.Cells["DIA_CHI"].Value.ToString();
                    TxtSDT.Text = dataGridView1.CurrentRow.Cells["SDT"].Value.ToString();
                    txtEmail.Text = dataGridView1.CurrentRow.Cells["EMAIL"].Value.ToString();
                    cbbLoai.Text = dataGridView1.CurrentRow.Cells["LOAI"].Value.ToString();
                    txtTThai.Text = dataGridView1.CurrentRow.Cells["TTHAI"].Value.ToString();
                    TxtID.Enabled = false;
                    txtTThai.Enabled = false;
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
                    txtDiaChi.Text = "";
                    TxtSDT.Text = "";
                    txtEmail.Text = "";
                    cbbLoai.Text = "";
                    txtTThai.Text = "";
                    TxtID.Enabled = true;
                    txtTThai.Enabled = true;
                    #endregion
                    this.Height = 336;
                    DesFor.AlignCenterToScreen();
                    break;
                default:
                    break;
            }
        }

        //Xử lý trên click trên form-----------------------------------------------------------

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            DesignForm.vForm = this;
            ViewMode();
            loadData();
            DatLoa.loadCBB("select distinct loai from TB_KHACH_HANG", ref cbbLoai);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells["LOAI"].Value.ToString() == "CC")
                {
                    //if (dataGridView1.Rows[i] == dataGridView1.CurrentRow)
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
                    dataGridView1.Rows[i].DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
                }
            }
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

        private void btnDel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng chưa được xây dựng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                exc.table = "TB_KHACH_HANG";
                                if (exc.ShowDialog() == DialogResult.OK) frmKhachHang_Load(sender, e);
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
                                sheet.Cells[1, 1].Value = "Danh sách Khách hàng";
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
                                sheet.Columns[4].NumberFormat = "@";//Chuyển về dạng text
                                for (int i = 1; i <= dataGridView1.Rows.Count; i++)
                                {
                                    for (int j = 1; j <= dataGridView1.Columns.Count; j++)
                                    {
                                        sheet.Cells[i + 2, j] = dataGridView1.Rows[i - 1].Cells[j - 1].Value.ToString();
                                        sheet.Cells[i + 2, j].Borders.weight = Excel.XlBorderWeight.xlThin;
                                        if (j == 4) // tinh chỉnh cột 4
                                        {
                                            sheet.Cells[i + 2, j].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight; //căn lề phải
                                        }
                                        if (j == 6) // tinh chỉnh cột 6
                                        {
                                            sheet.Cells[i + 2, j].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; //căn lề giữa
                                        }
                                        if (j == 7) // tinh chỉnh cột 7
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
        private void btnPrint_Click(object sender, EventArgs e)
        {
            crpDsKhachHang MyReport = new crpDsKhachHang();

            BindingSource gdSource = new BindingSource();
            gdSource = (BindingSource)this.dataGridView1.DataSource;
            MyReport.SetDataSource(gdSource.DataSource);
            MyReport.SetParameterValue("Nguoi_Sdung", UserInformation.MaNV);

            frmReportViewer f = new frmReportViewer();
            f.crystalReportViewer1.ReportSource = MyReport;
            f.ShowDialog();
        }

        //Xử lý trên key trên form-----------------------------------------------------------

        private void frmKhachHang_KeyDown(object sender, KeyEventArgs e)
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
        private void cbbLoai_TextChanged(object sender, EventArgs e)
        {
            if (cbbLoai.Text == "CC") lblNameLoai.Text = "Nhà Cung Cấp";
            else if (cbbLoai.Text == "KH") lblNameLoai.Text = "Khách Hàng";
            else lblNameLoai.Text = "";
        }

        private void txtTThai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void TxtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.Parse(e.KeyChar.ToString().ToUpper());
        }

        //Trả giá trị về 
        public string KH_ID
        {
            get
            {
                if (dataGridView1.Rows.Count <= 0) return "";
                else return dataGridView1.CurrentRow.Cells["MA_KH"].Value.ToString();
            }
        }

        private void frmKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    }
}
