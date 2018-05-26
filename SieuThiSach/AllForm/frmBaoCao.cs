using SieuThiSach.CrystalReport;
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
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        DataLoading DatLoa = new DataLoading();
        DesignForm DesFor = new DesignForm();
        public string _Filter = "";

        #region "Mặt hàng"
        private void loadDataMHforDay()
        {
            if (_Filter == "")
                _Filter = " where ngay = '" + txtDay.Text + "' and thang = '" + txtMonth.Text + "' and nam = '" + txtYear.Text + "' and MA_DVI like '%" + txtMaDV.Text +
                            "%' and (MA_HANG like '%" + txtMaHang.Text + "%' or TEN_HANG like N'%" + txtMaHang.Text + "%') group by MA_DVI,MA_HANG,TEN_HANG,NGAY,THANG,NAM ORDER BY NAM, THANG, NGAY";
            DatLoa.loadData("MA_DVI,MA_HANG,TEN_HANG,NGAY,THANG,NAM,sum(SL_NHAP) as SL_NHAP,sum(SL_XUAT) as SL_XUAT,sum(TONG_TIEN_NHAP)" +
                            " as TONG_TIEN_NHAP,sum(TONG_TIEN_XUAT) as TONG_TIEN_XUAT,sum(TONG_TIEN_XUAT) - sum(TONG_TIEN_NHAP) as DOANH_THU",
                            "V_BC_DoanhThu " + _Filter, ref dataGridView1);
            DesFor.EditCollum(ref dataGridView1, "MA_DVI", true, "Mã đơn vị");
            DesFor.EditCollum(ref dataGridView1, "MA_HANG", true, "Mã hàng");
            DesFor.EditCollum(ref dataGridView1, "TEN_HANG", true, "Tên hàng");
            DesFor.EditCollum(ref dataGridView1, "THANG", true, "Tháng");
            DesFor.EditCollum(ref dataGridView1, "NAM", true, "Năm");
            DesFor.EditCollum(ref dataGridView1, "SL_NHAP", true, "SL Nhập");
            DesFor.EditCollum(ref dataGridView1, "SL_XUAT", true, "SL Xuất");
            DesFor.EditCollum(ref dataGridView1, "TONG_TIEN_NHAP", true, "Chi phí hàng");
            DesFor.EditCollum(ref dataGridView1, "TONG_TIEN_XUAT", true, "Doanh thu thuần");
            DesFor.EditCollum(ref dataGridView1, "DOANH_THU", true, "Lợi nhuận");
            _Filter = "";
        }
        private void loadDataMHforMonth()
        {
            if (_Filter == "")
                _Filter = " where thang = '" + txtMonth.Text + "' and nam = '" + txtYear.Text + "' and MA_DVI like '%" + txtMaDV.Text +
                            "%' and (MA_HANG like '%" + txtMaHang.Text + "%' or TEN_HANG like N'%" + txtMaHang.Text + "%') group by MA_DVI,MA_HANG,TEN_HANG,THANG,NAM ORDER BY NAM, THANG";
            DatLoa.loadData("MA_DVI,MA_HANG,TEN_HANG,THANG,NAM,sum(SL_NHAP) as SL_NHAP,sum(SL_XUAT) as SL_XUAT,sum(TONG_TIEN_NHAP)" +
                            " as TONG_TIEN_NHAP,sum(TONG_TIEN_XUAT) as TONG_TIEN_XUAT,sum(TONG_TIEN_XUAT) - sum(TONG_TIEN_NHAP) as DOANH_THU",
                            "V_BC_DoanhThu " + _Filter, ref dataGridView1);
            DesFor.EditCollum(ref dataGridView1, "MA_DVI", true, "Mã đơn vị");
            DesFor.EditCollum(ref dataGridView1, "MA_HANG", true, "Mã hàng");
            DesFor.EditCollum(ref dataGridView1, "TEN_HANG", true, "Tên hàng");
            DesFor.EditCollum(ref dataGridView1, "THANG", true, "Tháng");
            DesFor.EditCollum(ref dataGridView1, "NAM", true, "Năm");
            DesFor.EditCollum(ref dataGridView1, "SL_NHAP", true, "SL Nhập");
            DesFor.EditCollum(ref dataGridView1, "SL_XUAT", true, "SL Xuất");
            DesFor.EditCollum(ref dataGridView1, "TONG_TIEN_NHAP", true, "Chi phí hàng");
            DesFor.EditCollum(ref dataGridView1, "TONG_TIEN_XUAT", true, "Doanh thu thuần");
            DesFor.EditCollum(ref dataGridView1, "DOANH_THU", true, "Lợi nhuận");
            _Filter = "";
        }

        private void loadDataMHforYear()
        {
            if (_Filter == "")
                _Filter = "  where nam = '" + txtYear.Text + "' and MA_DVI like '%" + txtMaDV.Text +
                            "%' and (MA_HANG like '%" + txtMaHang.Text + "%' or TEN_HANG like N'%" + txtMaHang.Text + "%') group by MA_DVI,MA_HANG,TEN_HANG,NAM ORDER BY NAM";
            DatLoa.loadData("MA_DVI,MA_HANG,TEN_HANG,NAM," +
                            "sum(SL_NHAP) as SL_NHAP, sum(SL_XUAT) as SL_XUAT, sum(TONG_TIEN_NHAP) as TONG_TIEN_NHAP, sum(TONG_TIEN_XUAT) as TONG_TIEN_XUAT," +
                            "sum(TONG_TIEN_XUAT) - sum(TONG_TIEN_NHAP) as DOANH_THU  ",
                            "V_BC_DoanhThu " + _Filter, ref dataGridView1);
            DesFor.EditCollum(ref dataGridView1, "MA_DVI", true, "Mã đơn vị");
            DesFor.EditCollum(ref dataGridView1, "MA_HANG", true, "Mã hàng");
            DesFor.EditCollum(ref dataGridView1, "TEN_HANG", true, "Tên hàng");
            DesFor.EditCollum(ref dataGridView1, "NAM", true, "Năm");
            DesFor.EditCollum(ref dataGridView1, "SL_NHAP", true, "SL Nhập");
            DesFor.EditCollum(ref dataGridView1, "SL_XUAT", true, "SL Xuất");
            DesFor.EditCollum(ref dataGridView1, "TONG_TIEN_NHAP", true, "Chi phí hàng");
            DesFor.EditCollum(ref dataGridView1, "TONG_TIEN_XUAT", true, "Doanh thu thuần");
            DesFor.EditCollum(ref dataGridView1, "DOANH_THU", true, "Lợi nhuận");
            _Filter = "";
        }
        #endregion

        #region "Nhóm hàng"
        private void loadDataNHforDay()
        {
            if (_Filter == "")
                _Filter = " where ngay = '" + txtDay.Text + "' and thang = '" + txtMonth.Text + "' and nam = '" + txtYear.Text + "' and MA_DVI like '%" + txtMaDV.Text +
                            "%' and (NHOM_HANG like '%" + txtNhomHang.Text + "%' or TEN_NHOM_HANG like N'%" + txtNhomHang.Text + "%') group by MA_DVI,NHOM_HANG,TEN_NHOM_HANG,NAM,THANG,NGAY ORDER BY NAM, THANG, NGAY";
            DatLoa.loadData("MA_DVI,NHOM_HANG,TEN_NHOM_HANG,NGAY,THANG,NAM,sum(SL_NHAP) as SL_NHAP, sum(SL_XUAT) as SL_XUAT, sum(TONG_TIEN_NHAP) as TONG_TIEN_NHAP, sum(TONG_TIEN_XUAT) as TONG_TIEN_XUAT,sum(TONG_TIEN_XUAT) - sum(TONG_TIEN_NHAP) as DOANH_THU ",
                            "V_BC_DoanhThu " + _Filter, ref dataGridView1);
            DesFor.EditCollum(ref dataGridView1, "MA_DVI", true, "Mã đơn vị");
            DesFor.EditCollum(ref dataGridView1, "NHOM_HANG", true, "Mã hàng");
            DesFor.EditCollum(ref dataGridView1, "TEN_NHOM_HANG", true, "Tên hàng");
            DesFor.EditCollum(ref dataGridView1, "THANG", true, "Tháng");
            DesFor.EditCollum(ref dataGridView1, "NAM", true, "Năm");
            DesFor.EditCollum(ref dataGridView1, "SL_NHAP", true, "SL Nhập");
            DesFor.EditCollum(ref dataGridView1, "SL_XUAT", true, "SL Xuất");
            DesFor.EditCollum(ref dataGridView1, "TONG_TIEN_NHAP", true, "Chi phí hàng");
            DesFor.EditCollum(ref dataGridView1, "TONG_TIEN_XUAT", true, "Doanh thu thuần");
            DesFor.EditCollum(ref dataGridView1, "DOANH_THU", true, "Lợi nhuận");
            _Filter = "";
        }

        private void loadDataNHforMonth()
        {
            if (_Filter == "")
                _Filter = " where thang = '" + txtMonth.Text + "' and nam = '" + txtYear.Text + "' and MA_DVI like '%" + txtMaDV.Text +
                            "%' and (NHOM_HANG like '%" + txtNhomHang.Text + "%' or TEN_NHOM_HANG like N'%" + txtNhomHang.Text + "%') group by MA_DVI,NHOM_HANG,TEN_NHOM_HANG,NAM,THANG ORDER BY NAM, THANG";
            DatLoa.loadData("MA_DVI,NHOM_HANG,TEN_NHOM_HANG,THANG,NAM,sum(SL_NHAP) as SL_NHAP, sum(SL_XUAT) as SL_XUAT, sum(TONG_TIEN_NHAP) as TONG_TIEN_NHAP, sum(TONG_TIEN_XUAT) as TONG_TIEN_XUAT,sum(TONG_TIEN_XUAT) - sum(TONG_TIEN_NHAP) as DOANH_THU ",
                            "V_BC_DoanhThu " + _Filter, ref dataGridView1);
            DesFor.EditCollum(ref dataGridView1, "MA_DVI", true, "Mã đơn vị");
            DesFor.EditCollum(ref dataGridView1, "NHOM_HANG", true, "Mã hàng");
            DesFor.EditCollum(ref dataGridView1, "TEN_NHOM_HANG", true, "Tên hàng");
            DesFor.EditCollum(ref dataGridView1, "THANG", true, "Tháng");
            DesFor.EditCollum(ref dataGridView1, "NAM", true, "Năm");
            DesFor.EditCollum(ref dataGridView1, "SL_NHAP", true, "SL Nhập");
            DesFor.EditCollum(ref dataGridView1, "SL_XUAT", true, "SL Xuất");
            DesFor.EditCollum(ref dataGridView1, "TONG_TIEN_NHAP", true, "Chi phí hàng");
            DesFor.EditCollum(ref dataGridView1, "TONG_TIEN_XUAT", true, "Doanh thu thuần");
            DesFor.EditCollum(ref dataGridView1, "DOANH_THU", true, "Lợi nhuận");
            _Filter = "";
        }

        private void loadDataNHforYear()
        {
            if (_Filter == "")
                _Filter = " where nam = '" + txtYear.Text + "' and MA_DVI like '%" + txtMaDV.Text +
                            "%' and (NHOM_HANG like '%" + txtNhomHang.Text + "%' or TEN_NHOM_HANG like N'%" + txtNhomHang.Text + "%') group by MA_DVI,NHOM_HANG,TEN_NHOM_HANG,NAM ORDER BY NAM";
            DatLoa.loadData("MA_DVI,NHOM_HANG,TEN_NHOM_HANG,NAM,sum(SL_NHAP) as SL_NHAP, sum(SL_XUAT) as SL_XUAT, sum(TONG_TIEN_NHAP) as TONG_TIEN_NHAP, sum(TONG_TIEN_XUAT) as TONG_TIEN_XUAT,sum(TONG_TIEN_XUAT) - sum(TONG_TIEN_NHAP) as DOANH_THU ",
                            "V_BC_DoanhThu " + _Filter, ref dataGridView1);
            DesFor.EditCollum(ref dataGridView1, "MA_DVI", true, "Mã đơn vị");
            DesFor.EditCollum(ref dataGridView1, "NHOM_HANG", true, "Mã hàng");
            DesFor.EditCollum(ref dataGridView1, "TEN_NHOM_HANG", true, "Tên hàng");
            DesFor.EditCollum(ref dataGridView1, "NAM", true, "Năm");
            DesFor.EditCollum(ref dataGridView1, "SL_NHAP", true, "SL Nhập");
            DesFor.EditCollum(ref dataGridView1, "SL_XUAT", true, "SL Xuất");
            DesFor.EditCollum(ref dataGridView1, "TONG_TIEN_NHAP", true, "Chi phí hàng");
            DesFor.EditCollum(ref dataGridView1, "TONG_TIEN_XUAT", true, "Doanh thu thuần");
            DesFor.EditCollum(ref dataGridView1, "DOANH_THU", true, "Lợi nhuận");
            _Filter = "";
        }
        #endregion

        #region "Nhà cung cấp"
        private void loadDataNCCforDay()
        {
            string select = ""; string MH = ""; string NH = ""; string whereMH = ""; string whereNH = "";
            string where = "";
            string groupby = "";
            if (_Filter == "")
            {
                if (txtMaHang.Text != "")
                {
                    MH = "MA_HANG,TEN_HANG,";
                    whereMH = " and (MA_HANG like '%" + txtMaHang.Text + "%' or Ten_Hang like N'%" + txtMaHang.Text + "%') ";
                }
                if (txtNhomHang.Text != "")
                {
                    NH = "NHOM_HANG,TEN_NHOM_HANG,";
                    whereNH = " and (NHOM_HANG like '%" + txtNhomHang.Text + "%' or TEN_NHOM_HANG like N'%" + txtNhomHang.Text + "%') ";
                }
                select = "MA_DVI,NHA_CC,TEN_KH," + NH + MH + " NGAY,THANG,NAM,sum(SL_NHAP) as SL_NHAP, sum(SL_XUAT) as SL_XUAT, sum(TONG_TIEN_NHAP) as TONG_TIEN_NHAP, sum(TONG_TIEN_XUAT) as TONG_TIEN_XUAT,sum(TONG_TIEN_XUAT) - sum(TONG_TIEN_NHAP) as DOANH_THU ";
                where = " where ngay = '" + txtDay.Text + "' and thang = '" + txtMonth.Text + "' and nam = '" + txtYear.Text + "' and MA_DVI like '%" + txtMaDV.Text +
                            "%' and (NHA_CC like '%" + txtNhaCC.Text + "%' or TEN_KH like N'%" + txtNhaCC.Text + "%') " + whereNH + whereMH;
                groupby = "group by MA_DVI,NHA_CC,TEN_KH, " + NH + MH + " NAM,THANG,NGAY ";

                _Filter = where + groupby + " ORDER BY NAM, THANG, NGAY";
            }

            DatLoa.loadData(select,
                            "V_BC_DoanhThu " + _Filter, ref dataGridView1);
            DesFor.EditCollum(ref dataGridView1, "MA_DVI", true, "Mã đơn vị");
            DesFor.EditCollum(ref dataGridView1, "THANG", true, "Tháng");
            DesFor.EditCollum(ref dataGridView1, "NAM", true, "Năm");
            DesFor.EditCollum(ref dataGridView1, "SL_NHAP", true, "SL Nhập");
            DesFor.EditCollum(ref dataGridView1, "SL_XUAT", true, "SL Xuất");
            DesFor.EditCollum(ref dataGridView1, "TONG_TIEN_NHAP", true, "Chi phí hàng");
            DesFor.EditCollum(ref dataGridView1, "TONG_TIEN_XUAT", true, "Doanh thu thuần");
            DesFor.EditCollum(ref dataGridView1, "DOANH_THU", true, "Lợi nhuận");
            _Filter = "";
        }

        private void loadDataNCCforMonth()
        {
            string select = ""; string MH = ""; string NH = ""; string whereMH = ""; string whereNH = "";
            string where = "";
            string groupby = "";
            if (_Filter == "")
            {
                if (txtMaHang.Text != "")
                {
                    MH = "MA_HANG,TEN_HANG,";
                    whereMH = " and (MA_HANG like '%" + txtMaHang.Text + "%' or Ten_Hang like N'%" + txtMaHang.Text + "%') ";
                }
                if (txtNhomHang.Text != "")
                {
                    NH = "NHOM_HANG,TEN_NHOM_HANG,";
                    whereNH = " and (NHOM_HANG like '%" + txtNhomHang.Text + "%' or TEN_NHOM_HANG like N'%" + txtNhomHang.Text + "%') ";
                }
                select = "MA_DVI,NHA_CC,TEN_KH," + NH + MH + " THANG,NAM,sum(SL_NHAP) as SL_NHAP, sum(SL_XUAT) as SL_XUAT, sum(TONG_TIEN_NHAP) as TONG_TIEN_NHAP, sum(TONG_TIEN_XUAT) as TONG_TIEN_XUAT,sum(TONG_TIEN_XUAT) - sum(TONG_TIEN_NHAP) as DOANH_THU ";
                where = " where thang = '" + txtMonth.Text + "' and nam = '" + txtYear.Text + "' and MA_DVI like '%" + txtMaDV.Text +
                            "%' and (NHA_CC like '%" + txtNhaCC.Text + "%' or TEN_KH like N'%" + txtNhaCC.Text + "%') " + whereNH + whereMH;
                groupby = "group by MA_DVI,NHA_CC,TEN_KH, " + NH + MH + " NAM,THANG ";

                _Filter = where + groupby + " ORDER BY NAM, THANG";
            }

            DatLoa.loadData(select,
                            "V_BC_DoanhThu " + _Filter, ref dataGridView1);
            DesFor.EditCollum(ref dataGridView1, "MA_DVI", true, "Mã đơn vị");
            DesFor.EditCollum(ref dataGridView1, "THANG", true, "Tháng");
            DesFor.EditCollum(ref dataGridView1, "NAM", true, "Năm");
            DesFor.EditCollum(ref dataGridView1, "SL_NHAP", true, "SL Nhập");
            DesFor.EditCollum(ref dataGridView1, "SL_XUAT", true, "SL Xuất");
            DesFor.EditCollum(ref dataGridView1, "TONG_TIEN_NHAP", true, "Chi phí hàng");
            DesFor.EditCollum(ref dataGridView1, "TONG_TIEN_XUAT", true, "Doanh thu thuần");
            DesFor.EditCollum(ref dataGridView1, "DOANH_THU", true, "Lợi nhuận");
            _Filter = "";
        }

        private void loadDataNCCforYear()
        {
            string select = ""; string MH = ""; string NH = ""; string whereMH = ""; string whereNH = "";
            string where = "";
            string groupby = "";
            if (_Filter == "")
            {
                if (txtMaHang.Text != "")
                {
                    MH = "MA_HANG,TEN_HANG,";
                    whereMH = " and (MA_HANG like '%" + txtMaHang.Text + "%' or Ten_Hang like N'%" + txtMaHang.Text + "%') ";
                }
                if (txtNhomHang.Text != "")
                {
                    NH = "NHOM_HANG,TEN_NHOM_HANG,";
                    whereNH = " and (NHOM_HANG like '%" + txtNhomHang.Text + "%' or TEN_NHOM_HANG like N'%" + txtNhomHang.Text + "%') ";
                }
                select = "MA_DVI,NHA_CC,TEN_KH," + NH + MH + " NAM,sum(SL_NHAP) as SL_NHAP, sum(SL_XUAT) as SL_XUAT, sum(TONG_TIEN_NHAP) as TONG_TIEN_NHAP, sum(TONG_TIEN_XUAT) as TONG_TIEN_XUAT,sum(TONG_TIEN_XUAT) - sum(TONG_TIEN_NHAP) as DOANH_THU ";
                where = " where nam = '" + txtYear.Text + "' and MA_DVI like '%" + txtMaDV.Text +
                            "%' and (NHA_CC like '%" + txtNhaCC.Text + "%' or TEN_KH like N'%" + txtNhaCC.Text + "%') " + whereNH + whereMH;
                groupby = "group by MA_DVI,NHA_CC,TEN_KH, " + NH + MH + " NAM ";

                _Filter = where + groupby + " ORDER BY NAM";
            }

            DatLoa.loadData(select,
                            "V_BC_DoanhThu " + _Filter, ref dataGridView1);
            DesFor.EditCollum(ref dataGridView1, "MA_DVI", true, "Mã đơn vị");
            DesFor.EditCollum(ref dataGridView1, "NAM", true, "Năm");
            DesFor.EditCollum(ref dataGridView1, "SL_NHAP", true, "SL Nhập");
            DesFor.EditCollum(ref dataGridView1, "SL_XUAT", true, "SL Xuất");
            DesFor.EditCollum(ref dataGridView1, "TONG_TIEN_NHAP", true, "Chi phí hàng");
            DesFor.EditCollum(ref dataGridView1, "TONG_TIEN_XUAT", true, "Doanh thu thuần");
            DesFor.EditCollum(ref dataGridView1, "DOANH_THU", true, "Lợi nhuận");
            _Filter = "";
        }
        #endregion

        private void TestLoad()
        {
            dataGridView1.DataSource = "";
            switch (cbbKyHan.Text)
            {
                case "Theo Ngày":
                    txtDay.Enabled = true;
                    if (txtDay.Text == "") txtDay.Text = DateTime.Now.Day.ToString();
                    txtMonth.Enabled = true;
                    if (txtMonth.Text == "") txtMonth.Text = DateTime.Now.Month.ToString();
                    if (cbbPhanLoai.Text == "Mặt Hàng")
                        loadDataMHforDay();
                    if (cbbPhanLoai.Text == "Nhóm Hàng")
                        loadDataNHforDay();
                    if (cbbPhanLoai.Text == "Nhà Cung Cấp")
                        loadDataNCCforDay();
                    break;
                case "Theo Tháng":
                    txtDay.Enabled = false; txtDay.Text = "";
                    txtMonth.Enabled = true;
                    if (txtMonth.Text == "") txtMonth.Text = DateTime.Now.Month.ToString();
                    if (cbbPhanLoai.Text == "Mặt Hàng")
                        loadDataMHforMonth();
                    if (cbbPhanLoai.Text == "Nhóm Hàng")
                        loadDataNHforMonth();
                    if (cbbPhanLoai.Text == "Nhà Cung Cấp")
                        loadDataNCCforMonth();
                    break;
                case "Theo Năm":
                    txtDay.Enabled = false; txtDay.Text = "";
                    txtMonth.Enabled = false; txtMonth.Text = "";
                    if (cbbPhanLoai.Text == "Mặt Hàng")
                        loadDataMHforYear();
                    if (cbbPhanLoai.Text == "Nhóm Hàng")
                        loadDataNHforYear();
                    if (cbbPhanLoai.Text == "Nhà Cung Cấp")
                        loadDataNCCforYear();
                    break;
            }
        }

        private void TestLoc()
        {
            switch (cbbPhanLoai.Text)
            {
                case "Mặt Hàng":
                    txtNhomHang.Enabled = false; txtNhomHang.Text = "";
                    txtMaHang.Enabled = true;
                    txtNhaCC.Enabled = false; txtNhaCC.Text = "";
                    break;
                case "Nhóm Hàng":
                    txtMaHang.Enabled = false; txtMaHang.Text = "";
                    txtNhomHang.Enabled = true;
                    txtNhaCC.Enabled = false; txtNhaCC.Text = "";
                    break;
                case "Nhà Cung Cấp":
                    txtMaHang.Enabled = true;
                    txtNhomHang.Enabled = true;
                    txtNhaCC.Enabled = true;
                    break;
            }
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            txtDay.Text = DateTime.Now.Day.ToString();
            txtMonth.Text = DateTime.Now.Month.ToString();
            txtYear.Text = DateTime.Now.Year.ToString();
            cbbKyHan.Text = "Theo Tháng";
            cbbPhanLoai.Text = "Nhóm Hàng";
        }

        private void cbbKyHan_TextChanged(object sender, EventArgs e)
        {
            TestLoad();
        }

        private void cbbPhanLoai_TextChanged(object sender, EventArgs e)
        {
            TestLoc();
            TestLoad();
        }

        private void txtDay_Validated(object sender, EventArgs e)
        {
            TestLoad();
        }

        private void txtMonth_Validated(object sender, EventArgs e)
        {
            TestLoad();
        }

        private void txtYear_Validated(object sender, EventArgs e)
        {
            TestLoad();
        }

        private void txtNhomHang_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    e.SuppressKeyPress = true;
                    using (frmNhomhang f = new frmNhomhang())
                    {
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            txtNhomHang.Text = f.NH_ID;
                        }
                        DesignForm.vForm = this;
                    }
                    break;
            }
        }

        private void txtMaHang_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    e.SuppressKeyPress = true;
                    using (frmMatHang f = new frmMatHang())
                    {
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            txtMaHang.Text = f.MH_ID;
                        }
                        DesignForm.vForm = this;
                    }
                    break;
            }
        }

        private void txtMaDV_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    e.SuppressKeyPress = true;
                    using (frmChiNhanh f = new frmChiNhanh())
                    {
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            txtMaDV.Text = f.DVI_ID;
                        }
                        DesignForm.vForm = this;
                    }
                    break;
            }
        }

        private void txtMaHang_TextChanged(object sender, EventArgs e)
        {
            TestLoad();
        }

        private void txtMaDV_TextChanged(object sender, EventArgs e)
        {
            TestLoad();
        }

        private void txtNhomHang_TextChanged(object sender, EventArgs e)
        {
            TestLoad();
        }

        private void txtMaHang_KeyUp(object sender, KeyEventArgs e)
        {
            if (cbbPhanLoai.Text == "Nhà Cung Cấp")
            {
                if (txtMaHang.Text.Length != 0) txtNhomHang.Enabled = false;
                else txtNhomHang.Enabled = true;
            }
        }

        private void txtNhomHang_KeyUp(object sender, KeyEventArgs e)
        {
            if (cbbPhanLoai.Text == "Nhà Cung Cấp")
            {
                if (txtNhomHang.Text.Length != 0) txtMaHang.Enabled = false;
                else txtMaHang.Enabled = true;
            }
        }

        private void txtNhaCC_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    e.SuppressKeyPress = true;
                    using (frmKhachHang f = new frmKhachHang())
                    {
                        f._Filter = " where MA_KH != 'KH00000' and MA_KH like '%CC%'";
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            txtNhaCC.Text = f.KH_ID;
                        }
                        DesignForm.vForm = this;
                    }
                    break;
            }
        }

        private void txtNhaCC_TextChanged(object sender, EventArgs e)
        {
            TestLoad();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int SLNhap = 0;
                int SLXuat = 0;
                int ChiPhi = 0;
                int DoanhThu = 0;
                int LoiNhuan = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    SLNhap = SLNhap + Convert.ToInt32(dataGridView1.Rows[i].Cells["SL_NHAP"].Value.ToString());
                    SLXuat = SLXuat + Convert.ToInt32(dataGridView1.Rows[i].Cells["SL_XUAT"].Value.ToString());
                    ChiPhi = ChiPhi + Convert.ToInt32(dataGridView1.Rows[i].Cells["TONG_TIEN_NHAP"].Value.ToString());
                    DoanhThu = DoanhThu + Convert.ToInt32(dataGridView1.Rows[i].Cells["TONG_TIEN_XUAT"].Value.ToString());
                    LoiNhuan = LoiNhuan + Convert.ToInt32(dataGridView1.Rows[i].Cells["DOANH_THU"].Value.ToString());
                }
                txtSLNhap.Text = SLNhap.ToString();
                txtSLXuat.Text = SLXuat.ToString();
                txtChiPhi.Text = String.Format("{0:0,0}", ChiPhi);
                txtDoanhThu.Text = String.Format("{0:0,0}", DoanhThu);
                if (LoiNhuan >= 0) txtLoiNhuan.Text = String.Format("{0:0,0}", LoiNhuan);
                else
                {
                    LoiNhuan = LoiNhuan * -1;
                    txtLoiNhuan.Text = "(" + String.Format("{0:0,0}", LoiNhuan) + ")";
                }
            }
            else
            {
                txtSLNhap.Text = "0";
                txtSLXuat.Text = "0";
                txtChiPhi.Text = "0";
                txtDoanhThu.Text = "0";
                txtLoiNhuan.Text = "0";
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (cbbPhanLoai.Text == "Nhóm Hàng" && cbbKyHan.Text == "Theo Năm")
            {
                crpBC_DT_Nhom_Nam MyReport = new crpBC_DT_Nhom_Nam();

                BindingSource gdSource = new BindingSource();
                gdSource = (BindingSource)this.dataGridView1.DataSource;
                MyReport.SetDataSource(gdSource.DataSource);
                MyReport.SetParameterValue("SL_Nhap", txtSLNhap.Text);
                MyReport.SetParameterValue("SL_Ban", txtSLXuat.Text);
                MyReport.SetParameterValue("Tien_Nhap", txtChiPhi.Text);
                MyReport.SetParameterValue("Tien_Ban", txtDoanhThu.Text);
                MyReport.SetParameterValue("Loi_Nhuan", txtLoiNhuan.Text);
                MyReport.SetParameterValue("Nam_SD", txtYear.Text);
                if (DatLoa.NameReturn("TEN_DVI", "TB_DVI", "MA_DVI = '" + txtMaDV.Text + "'") == "") MyReport.SetParameterValue("Dvi", "Tất cả đơn vị");
                else MyReport.SetParameterValue("Dvi", DatLoa.NameReturn("TEN_DVI", "TB_DVI", "MA_DVI = '" + txtMaDV.Text + "'"));

                if (DatLoa.NameReturn("TEN_NHOM_HANG", "TB_NHOM_HANG", "MA_NHOM_HANG = '" + txtNhomHang.Text + "'") == "") MyReport.SetParameterValue("Nhom", "Tất cả nhóm");
                else MyReport.SetParameterValue("Nhom", DatLoa.NameReturn("TEN_NHOM_HANG", "TB_NHOM_HANG", "MA_NHOM_HANG = '" + txtNhomHang.Text + "'"));

                MyReport.SetParameterValue("Nguoi_Sdung", DatLoa.NameReturn("TEN_NHAN_VIEN", "TB_NHAN_VIEN", "MA_NHAN_VIEN = '" + UserInformation.MaNV + "'"));

                frmReportViewer f = new frmReportViewer();
                f.crystalReportViewer1.ReportSource = MyReport;
                f.ShowDialog();
            }
        }

        private void frmBaoCao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.P) btnIn.PerformClick();
        }
    }
}
