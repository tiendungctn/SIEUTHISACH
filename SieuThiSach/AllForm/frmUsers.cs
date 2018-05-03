using SieuThiSach.AllForm;
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

namespace SieuThiSach
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        string _pMode = "";
        DataLoading DatLoa = new DataLoading();
        DesignForm DesFor = new DesignForm();

        //Các hàm Data-----------------------------------------------------------
        private void loadData(string _Filter = "where SDUNG = 'C' ")
        {
            DatLoa.loadData("*", "V_Users " + _Filter, ref dataGridView1);
            DesFor.EditCollum(ref dataGridView1, "CODE", true, "Tên đăng nhập");
            DesFor.EditCollum(ref dataGridView1, "MA_DVI", true, "Mã Đơn Vị");
            DesFor.EditCollum(ref dataGridView1, "TEN_DVI", true, "Tên Đơn Vị");
            DesFor.EditCollum(ref dataGridView1, "MA_NHAN_VIEN", true, "Mã nhân viên");
            DesFor.EditCollum(ref dataGridView1, "TEN_NHAN_VIEN", true, "Tên nhân viên");
            DesFor.EditCollum(ref dataGridView1, "NGAY_HET_HAN", true, "Ngày hết hạn");
            DesFor.EditCollum(ref dataGridView1, "PQUYEN", false, "");
            DesFor.EditCollum(ref dataGridView1, "SDUNG", false, "Sử dụng");
            DesFor.EditCollum(ref dataGridView1, "CHECK_PASS", false, "Check Pass");
        }

        private void AddNew()
        {
            Char vchkUsingCheck = chkUsingCheck.Checked ? 'C' : 'K';
            Char vchkChangePWDLogon = chkChangePWDLogon.Checked ? 'Y' : 'N';
            string sql = "USER_NHAP '" + TxtUserId.Text.Trim() +
                "',N'" + TxtUserName.Text.Trim() +
                "','" + dExpiredDate.Text.Trim() +
                "','" + txtBranchID.Text.Trim() +
                "','" + vchkUsingCheck +
                "','" + vchkChangePWDLogon + "',1";

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
            Char vchkUsingCheck = chkUsingCheck.Checked ? 'C' : 'K';
            Char vchkChangePWDLogon = chkChangePWDLogon.Checked ? 'Y' : 'N';
            string sql = "USER_EDIT '" + TxtUserId.Text.Trim() +
                "',N'" + TxtUserName.Text.Trim() +
                "','" + dExpiredDate.Text.Trim() +
                "','" + TxtStaffId.Text.Trim() +
                "','" + txtBranchID.Text.Trim() +
                "','" + vchkUsingCheck +
                 "','" + vchkChangePWDLogon + "',1";
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
            Char vchkUsingCheck = chkUsingCheck.Checked ? 'C' : 'K';
            Char vchkChangePWDLogon = chkChangePWDLogon.Checked ? 'Y' : 'N';
            string vFilter = "Where SDUNG = '" + vchkUsingCheck + "' and CHECK_PASS = '" + vchkChangePWDLogon + "'";
            if (TxtUserId.Text != "")
            {
                vFilter = vFilter + " and CODE like '%" + TxtUserId.Text.Trim() + "%'";
            }
            if (TxtUserName.Text != "")
            {
                vFilter = vFilter + " and TEN_NHAN_VIEN like N'%" + TxtUserName.Text.Trim() + "%'";
            }
            if (TxtStaffId.Text != "")
            {
                vFilter = vFilter + " and MA_NHAN_VIEN like '%" + TxtStaffId.Text.Trim() + "%'";
            }
            if (txtBranchID.Text != "")
            {
                vFilter = vFilter + " and MA_DVI like '%" + txtBranchID.Text + "%'";
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
                    TxtUserId.Text = "";
                    txtBranchID.Text = "";
                    lblNameBranch.Text = "";
                    TxtStaffId.Text = "";
                    TxtUserName.Text = "";
                    dExpiredDate.Text = "";
                    chkUsingCheck.Checked = true;
                    chkChangePWDLogon.Checked = true;
                    TxtUserId.Enabled = true;
                    TxtStaffId.Enabled = false;
                    txtBranchID.Enabled = true;
                    #endregion
                    TxtUserId.Focus();
                    DesFor.AlignCenterToScreen();
                    break;
                case "FIND":
                    grButton1.Enabled = false;
                    dataGridView1.Enabled = false;
                    this.Height = 440;
                    DesFor.ColorChange(ref btnFind);
                    #region "Load Text Box Clear"
                    TxtUserId.Text = "";
                    txtBranchID.Text = "";
                    lblNameBranch.Text = "";
                    TxtStaffId.Text = "";
                    TxtUserName.Text = "";
                    dExpiredDate.Text = "";
                    chkUsingCheck.Checked = true;
                    chkChangePWDLogon.Checked = false;
                    TxtUserId.Enabled = true;
                    TxtStaffId.Enabled = true;
                    txtBranchID.Enabled = true;
                    #endregion
                    TxtUserId.Focus();
                    DesFor.AlignCenterToScreen();
                    break;
                case "EDIT":
                    grButton1.Enabled = false;
                    dataGridView1.Enabled = false;
                    this.Height = 440;
                    DesFor.ColorChange(ref btnEdit);
                    #region "Load Text Box"
                    TxtUserId.Text = dataGridView1.CurrentRow.Cells["CODE"].Value.ToString();
                    txtBranchID.Text = dataGridView1.CurrentRow.Cells["MA_DVI"].Value.ToString();
                    lblNameBranch.Text = dataGridView1.CurrentRow.Cells["TEN_DVI"].Value.ToString();
                    TxtStaffId.Text = dataGridView1.CurrentRow.Cells["MA_NHAN_VIEN"].Value.ToString();
                    TxtUserName.Text = dataGridView1.CurrentRow.Cells["TEN_NHAN_VIEN"].Value.ToString();
                    dExpiredDate.Text = dataGridView1.CurrentRow.Cells["NGAY_HET_HAN"].Value.ToString();
                    chkUsingCheck.Checked = dataGridView1.CurrentRow.Cells["SDUNG"].Value.ToString() == "C" ? true : false;
                    chkChangePWDLogon.Checked = dataGridView1.CurrentRow.Cells["CHECK_PASS"].Value.ToString() == "Y" ? true : false;
                    TxtUserId.Enabled = false;
                    TxtStaffId.Enabled = false;
                    txtBranchID.Enabled = false;
                    #endregion
                    TxtUserName.Focus();
                    DesFor.AlignCenterToScreen();
                    break;
                case "":
                    grButton1.Enabled = true;
                    dataGridView1.Enabled = true;
                    #region "Load Text Box Clear"
                    TxtUserId.Text = "";
                    txtBranchID.Text = "";
                    lblNameBranch.Text = "";
                    TxtStaffId.Text = "";
                    TxtUserName.Text = "";
                    dExpiredDate.Text = "";
                    chkUsingCheck.Checked = false;
                    chkChangePWDLogon.Checked = false;
                    TxtUserId.Enabled = true;
                    TxtStaffId.Enabled = true;
                    txtBranchID.Enabled = true;
                    #endregion
                    this.Height = 336;
                    DesFor.AlignCenterToScreen();
                    break;
                default:
                    break;
            }
        }

        //Xử lý trên click trên form-----------------------------------------------------------
        private void frmUsers_Load(object sender, EventArgs e)
        {
            DesignForm.vForm = this;
            ViewMode();
            loadData();
            //DatLoa.loadCBB("select distinct ma_dvi from TB_DVI", ref cbbBranchID);
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

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (DatLoa.DelData("USER_EDIT_SDUNG", ref dataGridView1, "CODE", "MA_NHAN_VIEN", "SDUNG") > 0)
                loadData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(sender, e);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng chưa được xây dựng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng chưa được xây dựng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Xử lý trên key trên form-----------------------------------------------------------
        private void txtBranchID_TextChanged(object sender, EventArgs e)
        {
            lblNameBranch.Text = DatLoa.NameReturn("TEN_DVI", "TB_DVI", "MA_DVI = '" + txtBranchID.Text + "'");
        }

        private void frmUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N) btnAdd.PerformClick();
            else if (e.Control && e.KeyCode == Keys.E) btnEdit.PerformClick();
            else if (e.Control && e.KeyCode == Keys.F) btnFind.PerformClick();
            else if (e.KeyCode == Keys.Escape)
            {
                if (_pMode == "") this.Close();
                else btnCancel.PerformClick();
            }
            //switch (e.KeyData)
            //{
            //    case (Keys.Control | Keys.N):
            //        e.SuppressKeyPress = true;
            //        btnAdd.PerformClick();
            //        break;
            //    case (Keys.Control | Keys.E):
            //        e.SuppressKeyPress = true;
            //        btnEdit.PerformClick();
            //        break;
            //    case (Keys.Control | Keys.F):
            //        e.SuppressKeyPress = true;
            //        btnFind.PerformClick();
            //        break;
            //    case (Keys.Control | Keys.Z):
            //        e.SuppressKeyPress = true;
            //        btnCancel.PerformClick();
            //        break;
            //}
        }

        private void txtBranchID_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    e.SuppressKeyPress = true;
                    using (frmChiNhanh f = new frmChiNhanh())
                    {
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            txtBranchID.Text = f.DVI_ID;
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
                else return dataGridView1.CurrentRow.Cells["MA_DVI"].Value.ToString();
            }
        }

        public string StaffId
        {
            get
            {
                if (dataGridView1.Rows.Count <= 0) return "";
                else return dataGridView1.CurrentRow.Cells["MA_NHAN_VIEN"].Value.ToString();
            }
        }

        private void frmUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
