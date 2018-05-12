using SieuThiSach.SO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SieuThiSach.DAL
{
    class DataLoading
    {
        DataAccess dbA = new DataAccess();
        DataSet ct = new DataSet();
        public string NameReturn(string name, string table, string dk)
        {
            if (dk == "") return "";
            String Name = "";
            //DataSet ct = new DataSet();
            string sql = "SELECT " + name + " FROM " + table + " WHERE " + dk;
            try
            {
                ct = dbA.ExecuteAsDataSetSql(sql);
                if (ct.Tables[0].Rows.Count > 0)
                    Name = ct.Tables[0].Rows[0][0].ToString();
            }
            catch (Exception es)
            {
                MessageBox.Show("Có lỗi" + es.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Name;
        }

        public string CreatMAHD(string PROC, string LoaiHD)
        {
            String Name = "";
            string sql = "exec " + PROC + " " + UserInformation.PQ + ",'" + UserInformation.MaDV + "','" + UserInformation.MaNV + "','" + LoaiHD + "'";
            try
            {
                ct = dbA.ExecuteAsDataSetSql(sql);
                if (ct.Tables[0].Rows.Count > 0)
                    Name = ct.Tables[0].Rows[0][0].ToString();
            }
            catch (Exception es)
            {
                MessageBox.Show("Có lỗi" + es.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Name;
        }

        public string ListColumnsName(string tb)
        {
            string ColumnsName = "";
            string sql = "select name from sys.all_columns where object_id = (select object_id from sys.objects where type='u' and name ='" + tb + "')";
            try
            {
                ct = dbA.ExecuteAsDataSetSql(sql);
                if (ct.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ct.Tables[0].Rows.Count; i++)
                    {
                        if (i == 0) ColumnsName = ct.Tables[0].Rows[i][0].ToString();
                        else ColumnsName = ColumnsName + "; " + ct.Tables[0].Rows[i][0].ToString();
                    }
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("Có lỗi " + es.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ColumnsName;
        }

        public void loadData(string columns, string table, ref DataGridView dt)
        {
            //DataSet ct = new DataSet();
            string sql = "SELECT " + columns + " FROM " + table;
            //string sql = "EXEC " + ts;
            try
            {
                ct = dbA.ExecuteAsDataSetSql(sql);
                BindingSource gdSource = new BindingSource();
                gdSource.DataSource = ct.Tables[0];
                dt.DataSource = gdSource;
            }
            catch (Exception es)
            {
                MessageBox.Show("Có lỗi" + es.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void loadDataPROC(string PROC, ref DataGridView dt)
        {
            //DataSet ct = new DataSet();
            string sql = "EXEC " + PROC;
            //string sql = "EXEC " + ts;
            try
            {
                ct = dbA.ExecuteAsDataSetSql(sql);
                BindingSource gdSource = new BindingSource();
                gdSource.DataSource = ct.Tables[0];
                dt.DataSource = gdSource;
            }
            catch (Exception es)
            {
                MessageBox.Show("Có lỗi" + es.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public int loadDataToListView(string columns, string table, int page, ref ListView ls)
        {
            int check = 0;
            string sql = "SELECT " + columns + " FROM " + table;
            try
            {
                ct = dbA.ExecuteAsDataSetSql(sql);
                BindingSource gdSource = new BindingSource();
                gdSource.DataSource = ct.Tables[0];
                //Tạo cột list view
                for (int i = 0; i < ct.Tables[0].Columns.Count; i++)
                {
                    string columnname = ct.Tables[0].Columns[i].ColumnName.ToString();
                    ColumnHeader col = new ColumnHeader();
                    col.Text = columnname;
                    ls.Columns.Add(col);
                }
                //add dữ liệu
                int last_rows = (page - 1) * 50 + 50 - 1;
                if (last_rows > ct.Tables[0].Rows.Count)
                {
                    last_rows = ct.Tables[0].Rows.Count;
                    check = 1;
                }

                for (int i = (page - 1) * 50; i < last_rows; i++)
                {
                    ListViewItem item = new ListViewItem();
                    for (int j = 0; j < ct.Tables[0].Columns.Count; j++)
                    {
                        if (j == 0)
                            item.Text = ct.Tables[0].Rows[i][j].ToString();
                        else
                            item.SubItems.Add(ct.Tables[0].Rows[i][j].ToString());
                    }
                    ls.Items.Add(item);
                }               
            }
            catch (Exception es)
            {
                MessageBox.Show("Có lỗi" + es.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            return check;
        }

        public int AddNew(string PROC)
        {
            int _ok = 0;
            string sql = "EXEC " + PROC;
            try
            {
                _ok = dbA.vExecuteData(sql);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return _ok;
        }

        public int DelData
            (string PROC, ref DataGridView table, string code, string name, string sdung)
        {
            int _ok = 0;
            if (table.Rows.Count <= 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK);
            }
            else
                foreach (System.Windows.Forms.DataGridViewRow dgvUsersrows in table.SelectedRows)
                {
                    string _code = dgvUsersrows.Cells[code].Value.ToString().Trim();
                    string _name = dgvUsersrows.Cells[name].Value.ToString().Trim();
                    string _sdung = dgvUsersrows.Cells[sdung].Value.ToString().Trim();

                    if (MessageBox.Show("Có chắc chắn xóa/ngưng sử dụng '" + _code + " - " + _name + "' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string sql = "EXEC " + PROC + " '" + UserInformation.PQ + "','" + _code + "','" + _sdung + "'";
                        try
                        {
                            _ok = dbA.vExecuteData(sql);
                        }
                        catch (Exception es)
                        {
                            MessageBox.Show("Có lỗi " + es.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            return _ok;
        }

        public int DelData2key
            (string PROC, ref DataGridView table, string code, string name, string sdung)
        {
            int _ok = 0;
            if (table.Rows.Count <= 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK);
            }
            else
                foreach (System.Windows.Forms.DataGridViewRow dgvUsersrows in table.SelectedRows)
                {
                    string _code = dgvUsersrows.Cells[code].Value.ToString().Trim();
                    string _name = dgvUsersrows.Cells[name].Value.ToString().Trim();
                    string _sdung = dgvUsersrows.Cells[sdung].Value.ToString().Trim();

                    if (MessageBox.Show("Có chắc chắn xóa/ngưng sử dụng '" + _code + " - " + _name + "' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string sql = "EXEC " + PROC + " '" + UserInformation.PQ + "','" + UserInformation.MaDV + "','" + _code + "','" + _sdung + "'";
                        try
                        {
                            _ok = dbA.vExecuteData(sql);
                        }
                        catch (Exception es)
                        {
                            MessageBox.Show("Có lỗi " + es.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            return _ok;
        }

        public void loadCBB(string sql, ref ComboBox cbb)
        {
            cbb.Items.Clear();
            try
            {
                ct = dbA.ExecuteAsDataSetSql(sql);
                if (ct.Tables[0].Rows.Count > 0)
                {
                    cbb.Items.Add("");
                    for (byte i = 0; i < ct.Tables[0].Rows.Count; i++)
                    {
                        cbb.Items.Add(ct.Tables[0].Rows[i][0].ToString());
                    }
                }

            }
            catch (Exception es)
            {
                MessageBox.Show("Có lỗi" + es.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void loadCBBfromHeaderText(ref DataGridView dgv, ref ComboBox cbb)
        {
            cbb.Items.Clear();
            try
            {
                if (dgv.Columns.Count > 0)
                {
                    List<string> check = new List<string>();
                    for (byte i = 0; i < dgv.Columns.Count; i++)
                    {
                        cbb.Items.Add(dgv.Columns[i].HeaderText.ToString());
                        check.Add(dgv.Columns[i].HeaderText.ToString());
                    }
                    if (!check.Contains("")) cbb.Items.Add("");
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("Có lỗi" + es.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void loadCBBfromColNameNumber(ref DataGridView dgv, ref ComboBox cbb)
        {
            cbb.Items.Clear();
            try
            {
                if (dgv.Columns.Count > 0)
                {
                    for (byte i = 0; i < dgv.Columns.Count; i++)
                    {
                        cbb.Items.Add((Convert.ToInt16(dgv.Columns[i].Name) + 1).ToString());
                    }
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("Có lỗi" + es.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void loadCBBfromList(List<string> list, ref ComboBox cbb)
        {
            cbb.Items.Clear();
            try
            {
                if (list.Count > 0)
                {
                    for (byte i = 0; i < list.Count; i++)
                    {
                        cbb.Items.Add(list[i]);
                    }
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("Có lỗi" + es.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int InsExc(int dt, string tb, ref DataGridView dtv)
        {
            int rw = 0;
            try
            {
                rw = dbA.ImportExcel(dt - 1, tb, ref dtv);
                if (rw > 0) MessageBox.Show("Đã nạp thành công " + rw + " dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception es)
            {
                MessageBox.Show("Lỗi tại dòng: " + dbA.RowEr + "\n" + es.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rw;
        }

        public int InsDgv(string clu, string tb, ref DataGridView dtv)
        {
            int rw = 0;
            try
            {
                rw = dbA.EditDataGridView(clu, tb, ref dtv);
                if (rw > 0) MessageBox.Show("Thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception es)
            {
                MessageBox.Show("Lỗi tại dòng: " + dbA.RowEr + "\n" + es.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rw;
        }
    }
}
