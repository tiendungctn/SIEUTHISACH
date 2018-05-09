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
                    lblNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    lblTenNV.Text = DatLoa.NameReturn("TEN_NHAN_VIEN", "TB_NHAN_VIEN", "MA_NHAN_VIEN = '" + UserInformation.MaNV + "'");
                    lblDv.Text = DatLoa.NameReturn("TEN_DVI", "TB_DVI", "MA_DVI = '" + UserInformation.MaDV + "'");
                    lblMaHD.Text = DatLoa.CreatMAHD("HD_NHAP_WAIT", "N");
                    break;
                default:
                    break;
            }
        }

        public string _Filter;
        private void loadData()
        {
            _Filter = "where MA_HD = '"+lblMaHD.Text+"' and MA_DVI = '"+ UserInformation.MaDV + "'";
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

        private void frmHD_Load(object sender, EventArgs e)
        {
            ViewMode();
            loadData();
        }
    }
}
