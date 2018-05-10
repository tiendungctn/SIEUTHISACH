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
    public partial class frmHD : Form
    {
        public frmHD()
        {
            InitializeComponent();
        }
        string _pMode = "";
        DataLoading DatLoa = new DataLoading();
        DesignForm DesFor = new DesignForm();
        private void ViewMode()
        {
            switch (_pMode)
            {
                case "":
                    txtMaMH.Text = "";
                    txtDongiaMH.Enabled = false; txtDongiaMH.Text = "";
                    txtSoluongMH.Enabled = false; txtSoluongMH.Text = "";
                    txtTyleChietKhauMH.Enabled = false; txtTyleChietKhauMH.Text = "0";
                    txtTienChietkhauMH.Enabled = false; txtTienChietkhauMH.Text = "0";
                    txtTamtinhHD.Text = "0";
                    txtTienChieuKhauHD.Text = "0";
                    txtKhachtra.Text = "";


                    lblNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    lblTenNV.Text = DatLoa.NameReturn("TEN_NHAN_VIEN", "TB_NHAN_VIEN", "MA_NHAN_VIEN = '" + UserInformation.MaNV + "'");
                    lblDv.Text = DatLoa.NameReturn("TEN_DVI", "TB_DVI", "MA_DVI = '" + UserInformation.MaDV + "'");
                    lblMaHD.Text = DatLoa.CreatMAHD("HD_NHAP_WAIT", "N");
                    break;
                case "ADD_MH":
                    txtMaMH.Text = "";
                    txtDongiaMH.Enabled = false; txtDongiaMH.Text = "";
                    txtSoluongMH.Enabled = false; txtSoluongMH.Text = "";
                    txtTyleChietKhauMH.Enabled = false; txtTyleChietKhauMH.Text = "0";
                    txtTienChietkhauMH.Enabled = false; txtTienChietkhauMH.Text = "0";

                    //lblNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    //lblTenNV.Text = DatLoa.NameReturn("TEN_NHAN_VIEN", "TB_NHAN_VIEN", "MA_NHAN_VIEN = '" + UserInformation.MaNV + "'");
                    //lblDv.Text = DatLoa.NameReturn("TEN_DVI", "TB_DVI", "MA_DVI = '" + UserInformation.MaDV + "'");
                    break;
                case "EDIT_MH":
                    txtMaMH.Text = dataGridView1.CurrentRow.Cells["MA_HANG"].Value.ToString();
                    txtDongiaMH.Text = dataGridView1.CurrentRow.Cells["GIA_XUAT"].Value.ToString();
                    txtSoluongMH.Text = dataGridView1.CurrentRow.Cells["SO_LUONG"].Value.ToString();
                    txtTienChietkhauMH.Text = dataGridView1.CurrentRow.Cells["CHIET_KHAU"].Value.ToString();

                    //lblNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    //lblTenNV.Text = DatLoa.NameReturn("TEN_NHAN_VIEN", "TB_NHAN_VIEN", "MA_NHAN_VIEN = '" + UserInformation.MaNV + "'");
                    //lblDv.Text = DatLoa.NameReturn("TEN_DVI", "TB_DVI", "MA_DVI = '" + UserInformation.MaDV + "'");
                    break;
                default:
                    break;
            }
        }

        private void loadData()
        {
            string _Filter = "where MA_HD = '" + lblMaHD.Text + "' and MA_DVI = '" + UserInformation.MaDV + "' and SDUNG = 'C'";
            DatLoa.loadData("*", "V_CT_HD " + _Filter, ref dataGridView1);
            DesFor.EditCollum(ref dataGridView1, "MA_DVI", false, "Mã DVI");
            DesFor.EditCollum(ref dataGridView1, "MA_HD", false, "Mã HD");
            DesFor.EditCollum(ref dataGridView1, "MA_HANG", true, "Mã Hàng");
            DesFor.EditCollum(ref dataGridView1, "TEN_HANG", true, "Tên Hàng");
            DesFor.EditCollum(ref dataGridView1, "SO_LUONG", true, "Số lượng");
            DesFor.EditCollum(ref dataGridView1, "GIA_NHAP", false, "Đơn giá");
            DesFor.EditCollum(ref dataGridView1, "GIA_XUAT", true, "Đơn giá");
            DesFor.EditCollum(ref dataGridView1, "CHIET_KHAU", true, "Triết Khấu");
            DesFor.EditCollum(ref dataGridView1, "TAM_TINH", true, "Tạm Tính");
            DesFor.EditCollum(ref dataGridView1, "SDUNG", false, "SDUNG");
        }

        private void AddNewMH()
        {
            string sql = "MAT_HANG_HD_NHAP '" + UserInformation.PQ +
                "','" + UserInformation.MaDV +
                "','" + lblMaHD.Text +
                "','" + txtMaMH.Text.Trim() +
                "','" + txtDongiaMH.Text.Trim() +
                "','" + txtSoluongMH.Text.Trim() +
                "','" + txtTienChietkhauMH.Text.Trim() + "', 'C'";

            int _ok = DatLoa.AddNew(sql);
            if (_ok > 0)
            {
                _pMode = "ADD_MH";
                ViewMode();
                loadData();
            }
        }

        private void DeleteMH()
        {
            string sql;
            if (txtMaMH.Text != "")
                sql = "MAT_HANG_HD_NHAP '" + UserInformation.PQ +
                "','" + UserInformation.MaDV +
                "','" + lblMaHD.Text +
                "','" + txtMaMH.Text.Trim() +
                "','" + txtDongiaMH.Text.Trim() +
                "','" + txtSoluongMH.Text.Trim() +
                "','" + txtTienChietkhauMH.Text.Trim() + "', 'K'";
            else
            {
                if (dataGridView1.Rows.Count > 0)
                    sql = "MAT_HANG_HD_NHAP '" + UserInformation.PQ +
                    "','" + UserInformation.MaDV +
                    "','" + lblMaHD.Text +
                    "','" + dataGridView1.CurrentRow.Cells["MA_HANG"].Value.ToString() +
                    "','" + dataGridView1.CurrentRow.Cells["GIA_XUAT"].Value.ToString() +
                    "','" + dataGridView1.CurrentRow.Cells["SO_LUONG"].Value.ToString() +
                    "','" + dataGridView1.CurrentRow.Cells["CHIET_KHAU"].Value.ToString() + "', 'K'";
                else return;
            }

            int _ok = DatLoa.AddNew(sql);
            if (_ok > 0)
            {
                _pMode = "ADD_MH";
                ViewMode();
                loadData();
            }
        }

        private void AddNewHD()
        {
            string sql = "HD_NHAP_COMPLETE '" + UserInformation.PQ +
                "','" + UserInformation.MaDV +
                "','" + lblMaHD.Text +
                "','" + txtMaKH.Text.Trim() +
                "','" + txtTienChieuKhauHD.Text.Trim() + "', 'C'";

            int _ok = DatLoa.AddNew(sql);
            if (_ok > 0)
            {
                _pMode = "";
                ViewMode();
                loadData();
            }
        }

        private void DeleteHD()
        {
            string sql = "HD_NHAP_COMPLETE '" + UserInformation.PQ +
                "','" + UserInformation.MaDV +
                "','" + lblMaHD.Text +
                "','" + txtMaKH.Text.Trim() +
                "','" + txtTienChieuKhauHD.Text.Trim() + "', 'F'";

            DatLoa.AddNew(sql);
        }

        private void frmHD_Load(object sender, EventArgs e)
        {
            ViewMode();
            loadData();
        }

        private void txtMaKH_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    e.SuppressKeyPress = true;
                    using (frmKhachHang f = new frmKhachHang())
                    {
                        f._Filter = " where MA_KH != 'KH00000' and MA_KH like '%KH%'";
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            txtMaKH.Text = f.KH_ID;
                        }
                        DesignForm.vForm = this;
                    }
                    break;
            }
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            lblTenKH.Text = DatLoa.NameReturn("TEN_KH", "TB_KHACH_HANG", "MA_KH = '" + txtMaKH.Text + "'");
            lblSDT.Text = DatLoa.NameReturn("SDT", "TB_KHACH_HANG", "MA_KH = '" + txtMaKH.Text + "'");
            lblDiaChi.Text = DatLoa.NameReturn("DIA_CHI", "TB_KHACH_HANG", "MA_KH = '" + txtMaKH.Text + "'");
            lblEmail.Text = DatLoa.NameReturn("Email", "TB_KHACH_HANG", "MA_KH = '" + txtMaKH.Text + "'");
        }

        private void txtMaMH_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    e.SuppressKeyPress = true;
                    using (frmMatHang f = new frmMatHang())
                    {
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            txtMaMH.Text = f.MH_ID;
                        }
                        DesignForm.vForm = this;
                    }
                    break;
            }
        }

        private void txtMaMH_TextChanged(object sender, EventArgs e)
        {
            grMATHANG.Text = "Mặt hàng: " + DatLoa.NameReturn("TEN_HANG", "TB_MAT_HANG", "MA_HANG = '" + txtMaMH.Text + "' and MA_DVI = '" + UserInformation.MaDV + "'");

            if (DatLoa.NameReturn("TEN_HANG", "TB_MAT_HANG", "MA_HANG = '" + txtMaMH.Text + "' and MA_DVI = '" + UserInformation.MaDV + "'") != "")
            {
                txtDongiaMH.Text = DatLoa.NameReturn("GIA_BAN", "TB_MAT_HANG", "MA_HANG = '" + txtMaMH.Text + "' and MA_DVI = '" + UserInformation.MaDV + "'");
                txtDongiaMH.Enabled = true;
                txtSoluongMH.Enabled = true;
                txtTyleChietKhauMH.Enabled = true;
                txtTienChietkhauMH.Enabled = true;

                if (DatLoa.NameReturn("SO_LUONG", "TB_CT_HOA_DON", "MA_HANG = '" + txtMaMH.Text + "' and MA_HD = '" + lblMaHD.Text + "' and MA_DVI = '" + UserInformation.MaDV + "'") == "")
                    txtSoluongMH.Text = "1";
                else txtSoluongMH.Text = DatLoa.NameReturn("SO_LUONG", "TB_CT_HOA_DON", "MA_HANG = '" + txtMaMH.Text + "' and MA_HD = '" + lblMaHD.Text + "' and MA_DVI = '" + UserInformation.MaDV + "'");

                if (DatLoa.NameReturn("CHIET_KHAU", "TB_CT_HOA_DON", "MA_HANG = '" + txtMaMH.Text + "' and MA_HD = '" + lblMaHD.Text + "' and MA_DVI = '" + UserInformation.MaDV + "'") == "")
                    txtTienChietkhauMH.Text = "0";
                else txtTienChietkhauMH.Text = DatLoa.NameReturn("CHIET_KHAU", "TB_CT_HOA_DON", "MA_HANG = '" + txtMaMH.Text + "' and MA_HD = '" + lblMaHD.Text + "' and MA_DVI = '" + UserInformation.MaDV + "'");
            }
        }

        private void txtDongiaMH_TextChanged(object sender, EventArgs e)
        {
            if (txtDongiaMH.Text == "") txtDongiaMH.Text = "0";
            if (txtSoluongMH.Text == "") txtSoluongMH.Text = "0";
            txtTongtienMH.Text = Convert.ToString(Convert.ToInt64(txtDongiaMH.Text) *
                                    Convert.ToInt64(txtSoluongMH.Text) -
                                    Convert.ToInt64(txtTienChietkhauMH.Text));
        }

        private void txtSoluongMH_TextChanged(object sender, EventArgs e)
        {
            if (txtSoluongMH.Text == "") txtSoluongMH.Text = "0";
            if (txtDongiaMH.Text == "") txtDongiaMH.Text = "0";
            txtTongtienMH.Text = Convert.ToString(Convert.ToInt64(txtDongiaMH.Text) *
                                    Convert.ToInt64(txtSoluongMH.Text) -
                                    Convert.ToInt64(txtTienChietkhauMH.Text));
        }
        private bool TienChietkhauMHCheck = false;
        private void txtTienChietkhauMH_TextChanged(object sender, EventArgs e)
        {
            TienChietkhauMHCheck = true;
            if (txtTienChietkhauMH.Text == "") txtTienChietkhauMH.Text = "0";
            txtTongtienMH.Text = Convert.ToString(Convert.ToInt64(txtDongiaMH.Text) *
                                    Convert.ToInt64(txtSoluongMH.Text) -
                                    Convert.ToInt64(txtTienChietkhauMH.Text));
            if (!TyleChietKhauMHCheck & txtTongtienMH.Text != "0")
                txtTyleChietKhauMH.Text = Convert.ToString(Convert.ToInt64(txtTienChietkhauMH.Text) * 100 /
                                            Convert.ToInt64(txtTongtienMH.Text));
            TienChietkhauMHCheck = false;
        }
        private bool TyleChietKhauMHCheck = false;
        private void txtTyleChietKhauMH_TextChanged(object sender, EventArgs e)
        {
            TyleChietKhauMHCheck = true;
            if (txtTyleChietKhauMH.Text == "") txtTyleChietKhauMH.Text = "0";
            if (!TienChietkhauMHCheck)
                txtTienChietkhauMH.Text = Convert.ToString(Convert.ToInt64(txtTongtienMH.Text) *
                                            Convert.ToInt64(txtTyleChietKhauMH.Text) / 100);
            TyleChietKhauMHCheck = false;
        }

        private void txtTyleChietKhauMH_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    e.SuppressKeyPress = true;//tăng giảm giá trị của tỷ lệ chiết khấu mặt hàng
                    if (Convert.ToInt64(txtTyleChietKhauMH.Text) < 99)
                        txtTyleChietKhauMH.Text = Convert.ToString(Convert.ToInt64(txtTyleChietKhauMH.Text) + 1);
                    break;
                case Keys.Down:
                    e.SuppressKeyPress = true;
                    if (Convert.ToInt64(txtTyleChietKhauMH.Text) > 0)
                        txtTyleChietKhauMH.Text = Convert.ToString(Convert.ToInt32(txtTyleChietKhauMH.Text) - 1);
                    break;
            }
        }

        private void txtTienChietkhauMH_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    e.SuppressKeyPress = true;//tăng giảm giá trị của tiền chiết khấu mặt hàng
                    if (Convert.ToInt64(txtTienChietkhauMH.Text) < 99)
                        txtTienChietkhauMH.Text = Convert.ToString(Convert.ToInt64(txtTienChietkhauMH.Text) + 1);
                    break;
                case Keys.Down:
                    e.SuppressKeyPress = true;
                    if (Convert.ToInt64(txtTienChietkhauMH.Text) > 0)
                        txtTienChietkhauMH.Text = Convert.ToString(Convert.ToInt32(txtTienChietkhauMH.Text) - 1);
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewMH();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int tongtien = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    tongtien = tongtien + Convert.ToInt32(dataGridView1.Rows[i].Cells["TAM_TINH"].Value.ToString());
                }
                txtTamtinhHD.Text = tongtien.ToString();
            }

        }
        private bool TyleChietKhauHDCheck = false;
        private void txtTyleChietKhauHD_TextChanged(object sender, EventArgs e)
        {
            TyleChietKhauHDCheck = true;
            if (txtTyleChietKhauHD.Text == "") txtTyleChietKhauHD.Text = "0";
            if (!TienChietkhauHDCheck)
                txtTienChieuKhauHD.Text = Convert.ToString(Convert.ToInt64(txtTongtienHD.Text) *
                                            Convert.ToInt64(txtTyleChietKhauHD.Text) / 100);
            TyleChietKhauHDCheck = false;
        }
        private bool TienChietkhauHDCheck = false;
        private void txtTienChieuKhauHD_TextChanged(object sender, EventArgs e)
        {
            TienChietkhauHDCheck = true;
            if (txtTienChieuKhauHD.Text == "") txtTienChieuKhauHD.Text = "0";
            txtTongtienHD.Text = Convert.ToString(Convert.ToInt64(txtTamtinhHD.Text) -
                                    Convert.ToInt64(txtTienChieuKhauHD.Text));
            if (!TyleChietKhauHDCheck & txtTongtienHD.Text != "0")
                txtTyleChietKhauHD.Text = Convert.ToString(Convert.ToInt64(txtTienChieuKhauHD.Text) * 100 /
                                            Convert.ToInt64(txtTongtienHD.Text));
            TienChietkhauHDCheck = false;
        }

        private void txtTamtinhHD_TextChanged(object sender, EventArgs e)
        {
            if (txtTamtinhHD.Text == "") txtTamtinhHD.Text = "0";
            if (txtTienChieuKhauHD.Text == "") txtTienChieuKhauHD.Text = "0";
            txtTongtienHD.Text = Convert.ToString(Convert.ToInt64(txtTamtinhHD.Text) -
                                        Convert.ToInt64(txtTienChieuKhauHD.Text));
        }

        private void txtTongtienHD_TextChanged(object sender, EventArgs e)
        {
            if (txtTongtienHD.Text == "") txtTongtienHD.Text = "0";
            if (txtKhachtra.Text == "") txtKhachtra.Text = "0";
            txtConlai.Text = Convert.ToString(Convert.ToInt64(txtTongtienHD.Text) -
                                        Convert.ToInt64(txtKhachtra.Text));
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            AddNewHD();
        }

        private void txtKhachtra_TextChanged(object sender, EventArgs e)
        {
            if (txtTongtienHD.Text == "") txtTongtienHD.Text = "0";
            if (txtKhachtra.Text == "") txtKhachtra.Text = "0";
            txtConlai.Text = Convert.ToString(Convert.ToInt64(txtTongtienHD.Text) -
                                        Convert.ToInt64(txtKhachtra.Text));
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                _pMode = "EDIT_MH";
                ViewMode();
            }
        }

        private void btnTralai_Click(object sender, EventArgs e)
        {
            DeleteMH();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DeleteHD();
            _pMode = "";
            ViewMode();
            loadData();
        }

        private void frmHD_FormClosing(object sender, FormClosingEventArgs e)
        {
            DeleteHD();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            btnNhapLai.PerformClick();
        }

        private void txtDongiaMH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoluongMH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTyleChietKhauMH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) || txtTyleChietKhauMH.Text.Length > 1)
                e.Handled = true;
        }

        private void txtTienChietkhauMH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTyleChietKhauHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTienChieuKhauHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtKhachtra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
