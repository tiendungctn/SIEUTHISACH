using SieuThiSach.DAL;
using SieuThiSach.SO;
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
    public partial class frmChiNhanh : Form
    {
        public frmChiNhanh()
        {
            InitializeComponent();
        }
        string _pMode = "";
        DataLoading DatLoa = new DataLoading();
        DesignForm DesFor = new DesignForm();
        private void loadData(string _Filter = " Where SDUNG = 'C'")
        {
            DatLoa.loadData("*", "TB_DVI " + _Filter, ref dataGridView1);
            DesFor.EditCollum(ref dataGridView1, "MA_DVI", true, "Mã đơn vị");
            DesFor.EditCollum(ref dataGridView1, "TEN_DVI", true, "Tên đơn vị");
            DesFor.EditCollum(ref dataGridView1, "DIA_CHI", true, "Địa chỉ");
            DesFor.EditCollum(ref dataGridView1, "SDUNG", false, "SDUNG");
        }

        private void AddNew()
        {
            string sql = "DVI_NHAP N'" + UserInformation.PQ +
                "','" + TxtName.Text.Trim() +
                "',N'" + txtDiaChi.Text.Trim() + "'";

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
            string sql = "DVI_EDIT '" + UserInformation.PQ +
                "','" + TxtID.Text.Trim() +
                "',N'" + TxtName.Text.Trim() +
                "',N'" + txtDiaChi.Text.Trim() + "'";
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
            string vFilter = " Where SDUNG = 'C' ";
            if (TxtID.Text != "")
            {
                vFilter = vFilter + " and MA_DVI like '%" + TxtID.Text.Trim() + "%'";
            }
            if (TxtName.Text != "")
            {
                vFilter = vFilter + " and TEN_DVI like N'%" + TxtName.Text.Trim() + "%'";
            }
            if (txtDiaChi.Text != "")
            {
                vFilter = vFilter + " and DIA_CHI like N'%" + txtDiaChi.Text.Trim() + "%'";
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
                    txtDiaChi.Text = "";
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
                    TxtID.Text = dataGridView1.CurrentRow.Cells["MA_DVI"].Value.ToString();
                    TxtName.Text = dataGridView1.CurrentRow.Cells["TEN_DVI"].Value.ToString();
                    txtDiaChi.Text = dataGridView1.CurrentRow.Cells["DIA_CHI"].Value.ToString();
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
                    txtDiaChi.Text = "";
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
        private void frmChiNhanh_Load(object sender, EventArgs e)
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

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (DatLoa.DelData("DVI_EDIT_SDUNG", ref dataGridView1, "MA_DVI", "TEN_DVI", "SDUNG") > 0)
                loadData();
        }

        //Xử lý trên key trên form-----------------------------------------------------------

        private void frmChiNhanh_KeyDown(object sender, KeyEventArgs e)
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
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        //Trả giá trị về 
        public string DVI_ID
        {
            get
            {
                if (dataGridView1.Rows.Count <= 0) return "";
                else return dataGridView1.CurrentRow.Cells["MA_DVI"].Value.ToString();
            }
        }

        private void frmChiNhanh_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    }
}
