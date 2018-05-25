using SieuThiSach.CrystalReport;
using SieuThiSach.DAL;
using SieuThiSach.SO;
using SieuThiSach.SystemForm;
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
    public partial class frmTonkho : Form
    {
        public frmTonkho()
        {
            InitializeComponent();
        }

        DataLoading DatLoa = new DataLoading();
        DesignForm DesFor = new DesignForm();
        public string _Filter = "";
        private void loadData()
        {
            string proc = "TON_KHO '" + dDate.Text + "', '%" + txtDvi.Text + "%', '%" + txtMaHang.Text + "%', '%" + txtNhom.Text + "%'";
            DatLoa.loadDataPROC(proc, ref dataGridView1);
            DesFor.EditCollum(ref dataGridView1, "MA_DVI", true, "Mã đơn vị");
            DesFor.EditCollum(ref dataGridView1, "MA_HANG", true, "Mã hàng");
            DesFor.EditCollum(ref dataGridView1, "TEN_HANG", true, "Tên hàng");
            DesFor.EditCollum(ref dataGridView1, "NHOM_HANG", false, "Mã nhóm");
            DesFor.EditCollum(ref dataGridView1, "TEN_NHOM_HANG", true, "Nhóm hàng");
            DesFor.EditCollum(ref dataGridView1, "TONG_NHAP", true, "Tổng nhập");
            DesFor.EditCollum(ref dataGridView1, "TONG_XUAT", true, "Tổng xuất");
            DesFor.EditCollum(ref dataGridView1, "TON_KHO", true, "Tồn kho");
            DesFor.EditCollum(ref dataGridView1, "SDUNG", true, "Sử dụng");
            //dataGridView1.AutoGenerateColumns = false;
        }
        bool IsTheSameCellValue(int column, int row) //trả lại nội dung 2 ô cạnh nhau trong cột có giống nhau
        {
            DataGridViewCell cell1 = dataGridView1[column, row];
            DataGridViewCell cell2 = dataGridView1[column, row - 1];
            if (cell1.Value == null || cell2.Value == null)
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)//tô viền
        {
            if (e.RowIndex < 0 || (e.ColumnIndex != 3 & e.ColumnIndex != 0 & e.ColumnIndex != 4))
                return;
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;//Xóa dòng kẻ ngang
            if (e.RowIndex < 1)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
            else
            {
                //kẻ dòng phân cách 2 ô khác nhau
                e.AdvancedBorderStyle.Top = dataGridView1.AdvancedCellBorderStyle.Top;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0 || (e.ColumnIndex != 3 & e.ColumnIndex != 0 & e.ColumnIndex != 4))
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.CellStyle.ForeColor = Color.Transparent;
                e.FormattingApplied = true;
            }
        }

        private void frmTonkho_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void txtDvi_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    e.SuppressKeyPress = true;
                    using (frmChiNhanh f = new frmChiNhanh())
                    {
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            txtDvi.Text = f.DVI_ID;
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

        private void txtNhom_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    e.SuppressKeyPress = true;
                    using (frmNhomhang f = new frmNhomhang())
                    {
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            txtNhom.Text = f.NH_ID;
                        }
                        DesignForm.vForm = this;
                    }
                    break;
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            frmHistory htr = new frmHistory();
            htr.TB_History = "V_CT_HD_MH_HISTORY ";
            htr._Filter = " where MA_HANG = '" + dataGridView1.CurrentRow.Cells["MA_HANG"].Value.ToString() + "'";
            #region "Load Tên Cột HISTORY"
            htr.namecolumns.Add("Mã Đơn Vị");
            htr.namecolumns.Add("Mã Hóa Đơn");
            htr.namecolumns.Add("Ngày tạo");
            htr.namecolumns.Add("Mã hàng");
            htr.namecolumns.Add("Tên hàng");
            htr.namecolumns.Add("Mã khách hàng");
            htr.namecolumns.Add("Tên khách hàng");
            htr.namecolumns.Add("Số lượng");
            htr.namecolumns.Add("Đơn giá");
            htr.namecolumns.Add("Chiết khấu");
            htr.namecolumns.Add("Tạm tính");
            htr.namecolumns.Add("Loại");
            htr.namecolumns.Add("Trạng thái");
            #endregion
            #region "LOAD ID FIND"
            htr.ID1 = "MA_DVI";
            htr.ID2 = "MA_HD";
            #endregion
            htr.ShowDialog();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            crpBC_TonKho MyReport = new crpBC_TonKho();
            BindingSource gdSource = new BindingSource();
            gdSource = (BindingSource)this.dataGridView1.DataSource;
            MyReport.SetDataSource(gdSource.DataSource);
            MyReport.SetParameterValue("Nguoi_Sdung", DatLoa.NameReturn("TEN_NHAN_VIEN", "TB_NHAN_VIEN", "MA_NHAN_VIEN = '" + UserInformation.MaNV + "'"));
            if (DatLoa.NameReturn("TEN_DVI", "TB_DVI", "MA_DVI = '" + txtDvi.Text + "'") == "")
                MyReport.SetParameterValue("Chi_Nhanh", "Tất cả Chi Nhánh");
            else
                MyReport.SetParameterValue("Chi_Nhanh", DatLoa.NameReturn("TEN_DVI", "TB_DVI", "MA_DVI = '" + txtDvi.Text + "'"));

            if (DatLoa.NameReturn("TEN_NHOM_HANG", "TB_NHOM_HANG", "MA_NHOM_HANG = '" + txtNhom.Text + "'") == "")
                MyReport.SetParameterValue("Nhom_Hang", "Tất cả Nhóm Hàng");
            else
                MyReport.SetParameterValue("Nhom_Hang", DatLoa.NameReturn("TEN_NHOM_HANG", "TB_NHOM_HANG", "MA_NHOM_HANG = '" + txtNhom.Text + "'"));

            if (DatLoa.NameReturn("TEN_HANG", "TB_MAT_HANG", "MA_HANG = '" + txtMaHang.Text + "'") == "")
                MyReport.SetParameterValue("Mat_Hang", "Tất cả Mặt Hàng");
            else
                MyReport.SetParameterValue("Mat_Hang", DatLoa.NameReturn("TEN_HANG", "TB_MAT_HANG", "MA_HANG = '" + txtMaHang.Text + "'"));

            MyReport.SetParameterValue("Ngay", String.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(dDate.Text)));

            frmReportViewer f = new frmReportViewer();
            f.crystalReportViewer1.ReportSource = MyReport;
            f.ShowDialog();
        }
    }
}
