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

namespace SieuThiSach.SystemForm
{
    public partial class frmLogin : Form
    {
        DataLoading DatLoa = new DataLoading();
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Thực hiện đăng nhập vào ứng Demo với thông tin trên
            string loginApp = LoginProvider.LoginApp(
                MyApp.gHostDB, MyApp.gPortDB, MyApp.gServiceNameDB, txtUserName.Text, txtPassword.Text,
                txtUserName.Text, txtPassword.Text);
            if (loginApp.Equals("true"))
            {
                MyApp.gConnected = true;
                MyApp.gUserDB = txtUserName.Text;
                frmMain.Current.ItemMnuLoginChange = "Đăng xuất";
                #region "Tham số Members"
                UserInformation.Code = txtUserName.Text;
                UserInformation.Pass = txtPassword.Text;
                UserInformation.MaNV = UserInformation.vMaNV(UserInformation.Code);
                UserInformation.MaDV = UserInformation.vMaDV(UserInformation.Code);
                UserInformation.Name = UserInformation.vName(UserInformation.MaNV, UserInformation.MaDV);
                UserInformation.CheckPass = UserInformation.vCheckPass(UserInformation.Code);
                #endregion
                //Gọi đổi mật khẩu nếu như đây là lần đăng nhập đầu tiên
                if (UserInformation.CheckPass == "Y")
                {
                    using (frmPassword digForm = new frmPassword())
                    {
                        if (digForm.ShowDialog() == DialogResult.OK)
                        {
                            //Goi phan quyen o day
                            PhanQuyen.ShowAll();
                            //close form
                            this.Close();
                        }
                    }  
                }
                else if (UserInformation.CheckPass == "N")
                {
                    //Goi phan quyen o day
                    PhanQuyen.ShowAll();
                    //close form
                    this.Close();
                }
            }
            else
            {
                string mMessage;
                mMessage = string.Format("Đăng nhập vào {0} không thành công. Bạn hãy kiểm tra lại các thông tin đăng nhập.\r\n{1}", MyApp.gHostDB, loginApp);
                MessageBox.Show(mMessage);
            }
        }
    }
}
