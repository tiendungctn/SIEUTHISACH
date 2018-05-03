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
        private void loadData(string _Filter = " where SDUNG = 'C'")
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
            string sql = "MAT_HANG_NHAP N'" + TxtID.Text.Trim() +
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
            string sql = "MAT_HANG_EDIT '" + TxtID.Text.Trim() +
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
            string vFilter = " where SDUNG = 'C'";
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
        //Trả giá trị về 
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
