using SieuThiSach.CrystalReport;
using SieuThiSach.DAL;
using SieuThiSach.Function;
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
        DocSoTien doctien = new DocSoTien();
        public string LOAI = "";
        public string MA_HD = "";
        public string MA_DVI = "";

        private void ViewMode()
        {
            switch (_pMode)
            {
                case "":
                    txtMaKH.Text = "";
                    txtMaMH.Text = "";
                    txtDongiaMH.Enabled = false; txtDongiaMH.Text = "";
                    txtSoluongMH.Enabled = false; txtSoluongMH.Text = "";
                    txtTyleChietKhauMH.Enabled = false; txtTyleChietKhauMH.Text = "0";
                    txtTienChietkhauMH.Enabled = false; txtTienChietkhauMH.Text = "0";
                    txtTamtinhHD.Text = "0";
                    txtTyleChietKhauHD.Enabled = false;
                    txtTienChieuKhauHD.Enabled = false; txtTienChieuKhauHD.Text = "0";
                    txtKhachtra.Enabled = false; txtKhachtra.Text = "";
                    txtTongtienHD.Text = "0"; txtConlai.Text = "";

                    if (LOAI == "X") lblTenPhieu.Text = "Phiếu Bán Hàng";
                    else if (LOAI == "N") lblTenPhieu.Text = "Phiếu Nhập Hàng";

                    lblNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    lblTenNV.Text = DatLoa.NameReturn("TEN_NHAN_VIEN", "TB_NHAN_VIEN", "MA_NHAN_VIEN = '" + UserInformation.MaNV + "'");
                    lblDv.Text = DatLoa.NameReturn("TEN_DVI", "TB_DVI", "MA_DVI = '" + MA_DVI + "'");
                    break;
                case "ADD_MH":
                    txtMaMH.Text = "";
                    txtDongiaMH.Enabled = false; txtDongiaMH.Text = "";
                    txtSoluongMH.Enabled = false; txtSoluongMH.Text = "";
                    txtTyleChietKhauMH.Enabled = false; txtTyleChietKhauMH.Text = "0";
                    txtTienChietkhauMH.Enabled = false; txtTienChietkhauMH.Text = "0";
                    break;
                case "EDIT_MH":
                    txtMaMH.Text = dataGridView1.CurrentRow.Cells["MA_HANG"].Value.ToString();
                    //if (LOAI == "X") txtSoluongMH.Text = dataGridView1.CurrentRow.Cells["SL_XUAT"].Value.ToString();
                    //else if (LOAI == "N") txtSoluongMH.Text = dataGridView1.CurrentRow.Cells["SL_NHAP"].Value.ToString();
                    //txtDongiaMH.Text = dataGridView1.CurrentRow.Cells["DON_GIA"].Value.ToString();
                    //txtTienChietkhauMH.Text = dataGridView1.CurrentRow.Cells["CHIET_KHAU"].Value.ToString();
                    break;
                default:
                    break;
            }
        }

        private void loadData()
        {
            bool LoaiX = false; bool LoaiN = false;
            if (LOAI == "X") LoaiX = true;
            else if (LOAI == "N") LoaiN = true;
            string _Filter = "where MA_HD = '" + lblMaHD.Text + "' and MA_DVI = '" + MA_DVI + "' and SDUNG = 'C'";
            DatLoa.loadData("*", "V_CT_HD " + _Filter, ref dataGridView1);
            DesFor.EditCollum(ref dataGridView1, "MA_DVI", false, "Mã DVI");
            DesFor.EditCollum(ref dataGridView1, "MA_HD", false, "Mã HD");
            DesFor.EditCollum(ref dataGridView1, "NGAY_VIET_HD", false, "Ngày");
            DesFor.EditCollum(ref dataGridView1, "MA_HANG", true, "Mã Hàng");
            DesFor.EditCollum(ref dataGridView1, "TEN_HANG", true, "Tên Hàng");
            DesFor.EditCollum(ref dataGridView1, "SL_NHAP", LoaiN, "Số lượng");
            DesFor.EditCollum(ref dataGridView1, "SL_XUAT", LoaiX, "Số lượng");
            DesFor.EditCollum(ref dataGridView1, "DON_GIA", true, "Đơn giá");
            DesFor.EditCollum(ref dataGridView1, "TAM_TINH_O", false, "Số Tiền Gốc");
            DesFor.EditCollum(ref dataGridView1, "CHIET_KHAU", true, "Triết Khấu");
            DesFor.EditCollum(ref dataGridView1, "TAM_TINH", true, "Tạm Tính");
            DesFor.EditCollum(ref dataGridView1, "LOAI", false, "Loại");
            DesFor.EditCollum(ref dataGridView1, "SDUNG", false, "SDUNG");
        }

        private void AddNewMH()
        {
            string ham = "";
            if (LOAI == "X") ham = "MAT_HANG_HDX_NHAP ";
            else if (LOAI == "N") ham = "MAT_HANG_HDN_NHAP ";
            string sql = ham + " '" + UserInformation.PQ +
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
            string ham = "";
            if (LOAI == "X") ham = "MAT_HANG_HDX_NHAP ";
            else if (LOAI == "N") ham = "MAT_HANG_HDN_NHAP ";

            string sl = "";
            if (LOAI == "X") sl = "SL_XUAT";
            else if (LOAI == "N") sl = "SL_NHAP";

            if (DatLoa.NameReturn("TEN_HANG", "TB_MAT_HANG", "MA_HANG = '" + txtMaMH.Text + "' and MA_DVI = '" + UserInformation.MaDV + "'") != "")
                sql = ham + " '" + UserInformation.PQ +
                "','" + UserInformation.MaDV +
                "','" + lblMaHD.Text +
                "','" + txtMaMH.Text.Trim() +
                "','" + txtDongiaMH.Text.Trim() +
                "','" + txtSoluongMH.Text.Trim() +
                "','" + txtTienChietkhauMH.Text.Trim() + "', 'K'";
            else
            {
                if (dataGridView1.Rows.Count > 0)
                    sql = ham + " '" + UserInformation.PQ +
                    "','" + UserInformation.MaDV +
                    "','" + lblMaHD.Text +
                    "','" + dataGridView1.CurrentRow.Cells["MA_HANG"].Value.ToString() +
                    "','" + dataGridView1.CurrentRow.Cells["DON_GIA"].Value.ToString() +
                    "','" + dataGridView1.CurrentRow.Cells[sl].Value.ToString() +
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
                PRINT();
                if (MA_HD == "")
                {
                    lblMaHD.Text = DatLoa.CreatMAHD("HD_NHAP_WAIT", LOAI);
                    ViewMode();
                    loadData();
                }
                else lblMaHD.Text = MA_HD;
            }
        }

        private void PRINT()
        {
            crpHoaDon MyReport = new crpHoaDon();

            BindingSource gdSource = new BindingSource();
            gdSource = (BindingSource)this.dataGridView1.DataSource;
            MyReport.SetDataSource(gdSource.DataSource);
            MyReport.SetParameterValue("Nhan_Vien", lblTenNV.Text);
            MyReport.SetParameterValue("Ma_HD", lblMaHD.Text);
            MyReport.SetParameterValue("Chi_Nhanh", lblDv.Text);
            MyReport.SetParameterValue("Tam_Tinh", txtTamtinhHD.Text);
            MyReport.SetParameterValue("Chiet_Khau", txtTienChieuKhauHD.Text);
            MyReport.SetParameterValue("Tong_Tien", txtTongtienHD.Text);
            MyReport.SetParameterValue("Khach_Tra", txtKhachtra.Text);
            MyReport.SetParameterValue("Con_Lai", txtConlai.Text);

            frmReportViewer f = new frmReportViewer();
            f.crystalReportViewer1.ReportSource = MyReport;
            f.ShowDialog();
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

        //Bắt sự kiện KICK-------------------------------------------------------------------

        private void frmHD_Load(object sender, EventArgs e)
        {
            if (MA_HD == "") lblMaHD.Text = DatLoa.CreatMAHD("HD_NHAP_WAIT", LOAI);
            else lblMaHD.Text = MA_HD;
            if (MA_DVI == "") MA_DVI = UserInformation.MaDV;

            if (LOAI == "X")
            {
                Label32.Visible = true;
                txtKhachtra.Visible = true;
                Label33.Visible = true;
                Label34.Visible = true;
                txtConlai.Visible = true;
                Label35.Visible = true;
            }
            else if (LOAI == "N")
            {
                Label32.Visible = false;
                txtKhachtra.Visible = false;
                Label33.Visible = false;
                Label34.Visible = false;
                txtConlai.Visible = false;
                Label35.Visible = false;
            }

            ViewMode();
            txtMaKH.Text = DatLoa.NameReturn("KHACH_HANG", "TB_HOA_DON", "MA_HD = '" + lblMaHD.Text + "' and MA_DVI = '" + MA_DVI + "'");
            loadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTongtienMH.Text != "" && Convert.ToInt32(txtTongtienMH.Text) > 0) AddNewMH();
            else
                MessageBox.Show("Có lỗi nhập mặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtTongtienHD.Text) > 0) AddNewHD();
            else
                MessageBox.Show("Có lỗi nhập hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                _pMode = "EDIT_MH";
                ViewMode();
            }
            else MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnTralai_Click(object sender, EventArgs e)
        {
            DeleteMH();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn hủy không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                DeleteHD();
                _pMode = "";
                if (MA_HD == "")
                {
                    lblMaHD.Text = DatLoa.CreatMAHD("HD_NHAP_WAIT", LOAI);
                    ViewMode();
                    loadData();
                }
                else lblMaHD.Text = MA_HD;
            }
        }

        private void frmHD_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn hủy & thoát không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No) e.Cancel = true;
            else DeleteHD();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            btnNhapLai.PerformClick();
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

        //Bắt sự kiện KEY---------------------------------------------------------------------

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

        private void txtKhachtra_TextChanged(object sender, EventArgs e)
        {
            if (txtTongtienHD.Text == "") txtTongtienHD.Text = "0";
            if (txtKhachtra.Text == "") txtKhachtra.Text = "0";
            txtConlai.Text = Convert.ToString(Convert.ToInt64(txtKhachtra.Text) -
                                Convert.ToInt64(txtTongtienHD.Text));
        }

        private void txtTamtinhHD_TextChanged(object sender, EventArgs e)
        {
            if (txtTamtinhHD.Text == "") txtTamtinhHD.Text = "0";
            if (txtTienChieuKhauHD.Text == "") txtTienChieuKhauHD.Text = "0";
            if (txtTamtinhHD.Text != "0")
            {
                txtTyleChietKhauHD.Enabled = true;
                txtTienChieuKhauHD.Enabled = true;
                txtKhachtra.Enabled = true;
                txtTongtienHD.Text = Convert.ToString(Convert.ToInt64(txtTamtinhHD.Text) -
                                            Convert.ToInt64(txtTienChieuKhauHD.Text));
            }
        }

        private void txtTongtienHD_TextChanged(object sender, EventArgs e)
        {
            if (txtTongtienHD.Text == "") txtTongtienHD.Text = "0";
            if (txtKhachtra.Text == "") txtKhachtra.Text = "0";
            txtConlai.Text = Convert.ToString(Convert.ToInt64(txtKhachtra.Text) -
                                Convert.ToInt64(txtTongtienHD.Text));
            if (txtTongtienHD.Text != "" & txtTongtienHD.Text != "0")
                lblTienThanhChu.Text = doctien.ChuyenSo(txtTongtienHD.Text);
            else lblTienThanhChu.Text = "";
        }

        private void txtMaKH_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    e.SuppressKeyPress = true;
                    using (frmKhachHang f = new frmKhachHang())
                    {
                        if (LOAI == "X") f._Filter = " where MA_KH != 'KH00000' and MA_KH like '%KH%'";
                        else if (LOAI == "N") f._Filter = " where MA_KH != 'KH00000' and MA_KH like '%CC%'";

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
                    if (LOAI == "N" && DatLoa.NameReturn("TEN_KH", "TB_KHACH_HANG", "MA_KH = '" + txtMaKH.Text + "'") == "")
                    {
                        MessageBox.Show("Nhập nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    using (frmMatHang f = new frmMatHang())
                    {
                        if (LOAI == "N")
                            f._Filter = " where MA_DVI = '" + UserInformation.MaDV + "' and NHA_CC = '" + txtMaKH.Text + "' and SDUNG = 'C' ";
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
                txtDongiaMH.Enabled = true;
                txtSoluongMH.Enabled = true;
                txtTyleChietKhauMH.Enabled = true;
                txtTienChietkhauMH.Enabled = true;

                if (DatLoa.NameReturn("DON_GIA", "TB_CT_HOA_DON", "MA_HANG = '" + txtMaMH.Text + "' and MA_HD = '" + lblMaHD.Text + "' and MA_DVI = '" + UserInformation.MaDV + "'") == "")
                {
                    //chưa có mặt hàng trong HĐ hiện tại, lấy giá từ bảng mặt hàng
                    if (LOAI == "X") txtDongiaMH.Text = DatLoa.NameReturn("GIA_BAN", "TB_MAT_HANG", "MA_HANG = '" + txtMaMH.Text + "' and MA_DVI = '" + UserInformation.MaDV + "'");
                    else if (LOAI == "N") txtDongiaMH.Text = DatLoa.NameReturn("GIA_NHAP", "TB_MAT_HANG", "MA_HANG = '" + txtMaMH.Text + "' and MA_DVI = '" + UserInformation.MaDV + "'");
                }
                else
                {
                    //Lấy từ đơn giá đã có
                    txtDongiaMH.Text = DatLoa.NameReturn("DON_GIA", "TB_CT_HOA_DON", "MA_HANG = '" + txtMaMH.Text + "' and MA_HD = '" + lblMaHD.Text + "' and MA_DVI = '" + UserInformation.MaDV + "'");
                }

                if (DatLoa.NameReturn("SL_NHAP", "TB_CT_HOA_DON", "MA_HANG = '" + txtMaMH.Text + "' and MA_HD = '" + lblMaHD.Text + "' and MA_DVI = '" + UserInformation.MaDV + "'") == "" &&
                    DatLoa.NameReturn("SL_XUAT", "TB_CT_HOA_DON", "MA_HANG = '" + txtMaMH.Text + "' and MA_HD = '" + lblMaHD.Text + "' and MA_DVI = '" + UserInformation.MaDV + "'") == "")
                    txtSoluongMH.Text = "1";
                else
                {
                    if (LOAI == "X") txtSoluongMH.Text = DatLoa.NameReturn("SL_XUAT", "TB_CT_HOA_DON", "MA_HANG = '" + txtMaMH.Text + "' and MA_HD = '" + lblMaHD.Text + "' and MA_DVI = '" + UserInformation.MaDV + "'");
                    else if (LOAI == "N") txtSoluongMH.Text = DatLoa.NameReturn("SL_NHAP", "TB_CT_HOA_DON", "MA_HANG = '" + txtMaMH.Text + "' and MA_HD = '" + lblMaHD.Text + "' and MA_DVI = '" + UserInformation.MaDV + "'");

                }

                if (DatLoa.NameReturn("CHIET_KHAU", "TB_CT_HOA_DON", "MA_HANG = '" + txtMaMH.Text + "' and MA_HD = '" + lblMaHD.Text + "' and MA_DVI = '" + UserInformation.MaDV + "'") == "")
                    txtTienChietkhauMH.Text = "0";
                else txtTienChietkhauMH.Text = DatLoa.NameReturn("CHIET_KHAU", "TB_CT_HOA_DON", "MA_HANG = '" + txtMaMH.Text + "' and MA_HD = '" + lblMaHD.Text + "' and MA_DVI = '" + UserInformation.MaDV + "'");
            }
            else
            {
                txtDongiaMH.Enabled = false; txtDongiaMH.Text = "";
                txtSoluongMH.Enabled = false; txtSoluongMH.Text = "";
                txtTyleChietKhauMH.Enabled = false; txtTyleChietKhauMH.Text = "0";
                txtTienChietkhauMH.Enabled = false; txtTienChietkhauMH.Text = "0";
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
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) || txtTyleChietKhauHD.Text.Length > 1)
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

        private void frmHD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N) btnHuy.PerformClick();
            else if (e.Control && e.KeyCode == Keys.E) btnNhapLai.PerformClick();
            else if (e.Control && e.KeyCode == Keys.F)
            {
                if (LOAI == "N" && DatLoa.NameReturn("TEN_KH", "TB_KHACH_HANG", "MA_KH = '" + txtMaKH.Text + "'") == "")
                {
                    MessageBox.Show("Nhập nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (frmMatHang f = new frmMatHang())
                {
                    if (LOAI == "N")
                        f._Filter = " where MA_DVI = '" + UserInformation.MaDV + "' and NHA_CC = '" + txtMaKH.Text + "' and SDUNG = 'C' ";
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        txtMaMH.Text = f.MH_ID;
                    }
                    DesignForm.vForm = this;
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                if (txtMaMH.Text != "") btnTralai.PerformClick();
                else
                {
                    if (dataGridView1.Rows.Count > 0) btnHuy.PerformClick();
                    else btnExit.PerformClick();
                }

            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (txtMaMH.Text != "") btnAdd.PerformClick();
                else btnThanhToan.PerformClick();
            }
        }
    }
}
