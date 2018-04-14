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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        string _pMode = "";
        DataLoading DatLoa = new DataLoading();
        DesignForm DesFor = new DesignForm();
        private void loadData(string _Filter = " where MA_KH != 'KH00000'")
        {
            DatLoa.loadData("*", "TB_KHACH_HANG " + _Filter, ref dataGridView1);
            DesFor.EditCollum(ref dataGridView1, "MA_KH", true, "Mã khách hàng");
            DesFor.EditCollum(ref dataGridView1, "TEN_KH", true, "Tên khách hàng");
            DesFor.EditCollum(ref dataGridView1, "DIA_CHI", true, "Địa chỉ");
            DesFor.EditCollum(ref dataGridView1, "SDT", true, "Số điện thoại");
            DesFor.EditCollum(ref dataGridView1, "EMAIL", true, "ĐC");
            DesFor.EditCollum(ref dataGridView1, "TTHAI", true, "Trạng thái");
            DesFor.EditCollum(ref dataGridView1, "LOAI", false, "Loại");
        }

        private void AddNew()
        {
            string sql = "KHACH_HANG_NHAP '" + TxtID.Text +
                "',N'" + TxtName.Text +
                "','" + txtDiaChi.Text +
                "','" + TxtSDT.Text +
                "','" + txtEmail.Text +
                "','" + cbbLoai.Text +
                "'," + txtTThai.Text;

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
            string sql = "KHACH_HANG_EDIT '" + TxtID.Text +
                "',N'" + TxtName.Text +
                "','" + txtDiaChi.Text +
                "','" + TxtSDT.Text +
                "','" + txtEmail.Text +
                "','" + cbbLoai.Text +
                "'," + txtTThai.Text;
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
            string vFilter = "Where MA_KH != 'KH00000'";
            if (TxtID.Text != "")
            {
                vFilter = vFilter + " and MA_KH like '%" + TxtID.Text + "%'";
            }
            if (TxtName.Text != "")
            {
                vFilter = vFilter + " and TEN_KH like N'%" + TxtName.Text + "%'";
            }
            if (txtDiaChi.Text != "")
            {
                vFilter = vFilter + " and DIA_CHI like '%" + txtDiaChi.Text + "%'";
            }
            if (TxtSDT.Text != "")
            {
                vFilter = vFilter + " and SDT like '%" + TxtSDT.Text + "%'";
            }
            if (txtEmail.Text != "")
            {
                vFilter = vFilter + " and EMAIL like '%" + txtEmail.Text + "%'";
            }
            if (cbbLoai.Text != "")
            {
                vFilter = vFilter + " and LOAI like '%" + cbbLoai.Text + "%'";
            }
            if (txtTThai.Text != "")
            {
                vFilter = vFilter + " and TTHAI like '%" + txtTThai.Text + "%'";
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
                    TxtSDT.Text = "";
                    txtEmail.Text = "";
                    cbbLoai.Text = "";
                    txtTThai.Text = "";
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
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells["LOAI"].Value.ToString() == "CC")
                {
                    //if (dataGridView1.Rows[i] == dataGridView1.CurrentRow)
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            btnEdit_Click(sender, e);
        }

        private void frmKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N) btnAdd.PerformClick();
            else if (e.Control && e.KeyCode == Keys.E) btnEdit.PerformClick();
            else if (e.Control && e.KeyCode == Keys.F) btnFind.PerformClick();
            else if (e.KeyCode == Keys.Escape)
            {
                if (_pMode == "") this.Close();
                else btnCancel.PerformClick();
            }
        }

        //Xử lý trên key trên form-----------------------------------------------------------


    }
}
