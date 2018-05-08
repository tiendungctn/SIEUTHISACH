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
    public partial class frmPhanQuyen : Form
    {
        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        DataLoading DatLoa = new DataLoading();
        DesignForm DesFor = new DesignForm();

        //Các hàm Data-----------------------------------------------------------
        private void loadData(string _Filter = "where SDUNG = 'C' and code != 'demo' ")
        {
            DatLoa.loadData("*", "V_PHAN_QUYEN " + _Filter, ref dataGridView1);
            DesFor.EditCollum(ref dataGridView1, "CODE", true, "Tên đăng nhập");
            DesFor.EditCollum(ref dataGridView1, "MA_NHAN_VIEN", true, "Mã nhân Viên");
            DesFor.EditCollum(ref dataGridView1, "TEN_NHAN_VIEN", true, "Tên nhân viên");
            DesFor.EditCollum(ref dataGridView1, "PQUYEN", true, "Quyền hạn");
            DesFor.EditCollum(ref dataGridView1, "TEN_PQ", true, "Ghi chú");
            DesFor.EditCollum(ref dataGridView1, "SDUNG", false, "SDUNG");

            dataGridView1.Columns["CODE"].ReadOnly = true;
            dataGridView1.Columns["MA_NHAN_VIEN"].ReadOnly = true;
            dataGridView1.Columns["TEN_NHAN_VIEN"].ReadOnly = true;
            dataGridView1.Columns["TEN_PQ"].ReadOnly = true;
            dataGridView1.Columns["PQUYEN"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int i = DatLoa.InsDgv("PQUYEN", "[USER]", ref dataGridView1);
                if (i > 0)
                {
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Cells["TEN_PQ"].Value = DatLoa.NameReturn("TEN_PQ", "TB_PHAN_QUYEN", " MA_PQ='" + dataGridView1.CurrentRow.Cells["PQUYEN"].Value + "'");
        }
    }
}
