using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SieuThiSach.SO;
using SieuThiSach.SystemForm;
using SieuThiSach.AllForm;

namespace SieuThiSach
{
    public partial class frmMain : Form
    {
        public static frmMain Current;
        public string ItemMnuLoginChange
        {
            get { return ItemMnuSystemLogin.Text; }
            set { ItemMnuSystemLogin.Text = value; }
        }
        public frmMain()
        {
            InitializeComponent();
            Current = this;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            this.Show();
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.White;
                }
            }
            MyApp.gConnected = false;
            //truyền đối tượng This (frmMain) cho class PhanQuyen
            PhanQuyen.frmmain = this;
            //gọi HideAll để ẩn menu trong class PhanQuyen
            PhanQuyen.HideAll();
            //
            //gọi form kết nối
            if (!MyApp.gConnected)
            {
                frmLogin digForm = new frmLogin();
                digForm.ShowDialog();
            }
            //(new frmLogin()).Show();
        }

        private void ItemMnuSystemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ItemMnuSystemLogin_Click(object sender, EventArgs e)
        {
            if (!MyApp.gConnected)
            {
                frmLogin digForm = new frmLogin();
                digForm.ShowDialog();
            }
            else
            {
                if (MessageBox.Show("Có chắc chắn bỏ kết nối?", "Đăng xuất",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    MyApp.gConnected = false;
                    frmMain.Current.ItemMnuLoginChange = "Đăng nhập";
                    #region "Members"
                    UserInformation.Code = "";
                    UserInformation.Pass = "";
                    UserInformation.MaNV = "";
                    UserInformation.MaDV = "";
                    UserInformation.Name = "";
                    UserInformation.CheckPass = "";
                    UserInformation.PQ = "";
                    #endregion
                    PhanQuyen.HideAll(); //ẩn tất cả các menu
                    frmLogin digForm = new frmLogin();
                    digForm.ShowDialog();
                }
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ItemMnuSystemUser_Click(object sender, EventArgs e)
        {
            frmUsers callForm = new frmUsers();
            callForm.ShowDialog();
        }

        private void ItemMnuSystemPassword_Click(object sender, EventArgs e)
        {
            frmPassword callForm = new frmPassword();
            callForm.ShowDialog();
        }

        private void ItemMnuDanhMuc_KHACHHANG_Click(object sender, EventArgs e)
        {
            frmKhachHang callForm = new frmKhachHang();
            callForm.ShowDialog();
        }

        private void ItemMnuDanhMuc_NHOMHANG_Click(object sender, EventArgs e)
        {
            frmNhomhang callForm = new frmNhomhang();
            callForm.ShowDialog();
        }

        private void ItemMnuDanhMuc_DSHANGHOA_Click(object sender, EventArgs e)
        {
            frmMatHang callForm = new frmMatHang();
            callForm.ShowDialog();
        }

        private void ItemMnuDanhMuc_CHINHANH_Click(object sender, EventArgs e)
        {
            frmChiNhanh callForm = new frmChiNhanh();
            callForm.ShowDialog();
        }

        private void phânQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhanQuyen callForm = new frmPhanQuyen();
            callForm.ShowDialog();
        }

        private void ItemMnuHoaDon_XUATHANG_Click(object sender, EventArgs e)
        {
            frmHD callForm = new frmHD();
            callForm.LOAI = "X";
            callForm.ShowDialog();
        }

        private void ItemMnuHoaDon_NHAPHANG_Click(object sender, EventArgs e)
        {
            frmHD callForm = new frmHD();
            callForm.LOAI = "N";
            callForm.ShowDialog();
        }

        private void ItemMnuHoaDon_LICHSU_Click(object sender, EventArgs e)
        {
            frmHistory htr = new frmHistory();
            htr.TB_History = "V_DS_Hoa_Don ";
            #region "Load Tên Cột HISTORY"
            htr.namecolumns.Add("Mã Đơn Vị");
            htr.namecolumns.Add("Mã Hóa Đơn");
            htr.namecolumns.Add("Ngày tạo");
            htr.namecolumns.Add("Mã nhân viên");
            htr.namecolumns.Add("Tên nhân viên");
            htr.namecolumns.Add("Mã khách hàng");
            htr.namecolumns.Add("Tên khách hàng");
            htr.namecolumns.Add("Tạm tính");
            htr.namecolumns.Add("Chiết khấu");
            htr.namecolumns.Add("Thành tiền");
            htr.namecolumns.Add("Trạng thái");
            htr.namecolumns.Add("Loại");
            #endregion
            #region "LOAD ID FIND"
            htr.ID1 = "MA_DVI";
            htr.ID2 = "MA_HD";
            #endregion
            htr.ShowDialog();
        }

        private void ItemMnuKho_TonKho_Click(object sender, EventArgs e)
        {
            frmTonkho callForm = new frmTonkho();
            callForm.ShowDialog();
        }

        private void ItemMnuBC_KQKinhDoanh_Click(object sender, EventArgs e)
        {
            frmBaoCao callForm = new frmBaoCao();
            callForm.ShowDialog();
        }
    }
}
