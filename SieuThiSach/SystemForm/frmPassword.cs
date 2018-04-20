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
    public partial class frmPassword : Form
    {
        DataLoading DatLoa = new DataLoading();
        public frmPassword()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Thực thi đăng nhập
        /// </summary>
        /// <param name="sSql"></param>
        private void btnCommit_Click(object sender, EventArgs e)
        {
            #region Kiểm tra thông tin đầu vào
            if (txtOLDpass.Text != UserInformation.Pass)
            {
                MessageBox.Show("Mật khẩu cũ sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            if (txtNEWpass.Text != txtNEWpasscheck.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            if (txtNEWpass.Text == txtOLDpass.Text)
            {
                MessageBox.Show("Mật khẩu mới không được giống mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            if (txtNEWpass.Text == "")
            {
                MessageBox.Show("Mật khẩu không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            #endregion

            string sql = "PASS_CHANGE '" + UserInformation.Code + "' , '" + txtNEWpass.Text + "'";
            int _ok = DatLoa.AddNew(sql);
            if (_ok >= 0)
            {
                MyApp.MSSQLConnectionString = MyApp.GetLoginMSSQL(MyApp.gHostDB, MyApp.gServiceNameDB, MyApp.gUserDB, txtNEWpass.Text);
                UserInformation.Pass = txtNEWpass.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
