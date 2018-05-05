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
    public partial class frmHistory : Form
    {
        public frmHistory()
        {
            InitializeComponent();
        }
        DesignForm DesFor = new DesignForm();
        DataLoading DatLoa = new DataLoading();
        public static string TB_History = "";
        public List<string> namecolumns = new List<string>();
        string _Filter = "";
        public string ID1;
        public string ID2;
        private void loadData()
        {
            DatLoa.loadDataToListView("*", _Filter, ref lstHistory);
            LoadColName();
            lstHistory.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstHistory.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            for (int i = 0; i < lstHistory.Columns.Count; i++)
            {
                if (lstHistory.Columns[i].Width > 200)
                    lstHistory.Columns[i].Width = 200;
            }
        }

        private void LoadColName()
        {
            for (int i = 0; i < namecolumns.Count; i++)
            {
                lstHistory.Columns[i].Text = namecolumns[i];
            }
        }

        private void FindData()
        {
            string vFilter = " where NGAY_SUA >= '" + dStartDate.Text + "' and DATEADD(DD,-1, NGAY_SUA) <= '" +  dEndDate.Text + "' ";
            if (txtID1.Text != "")
            {
                vFilter = vFilter + " and " + ID1 + " like '%" + txtID1.Text.Trim() + "%'";
            }
            if (txtID2.Text != "")
            {
                vFilter = vFilter + " and " + ID2 + " like '%" + txtID2.Text.Trim() + "%'";
            }
            _Filter = vFilter;
            //loadData();           
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            lstHistory.Clear();
            _Filter = TB_History + _Filter + " order by NGAY_SUA desc";
            loadData();
            dStartDate.Text = DatLoa.NameReturn("min(ngay_sua)", TB_History, "(1=1)");
            lblID1.Text = lstHistory.Columns[0].Text;
            lblID2.Text = lstHistory.Columns[1].Text;
        }

        private void frmHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            namecolumns.Clear();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FindData();
            frmHistory_Load(sender, e);
        }

        private void txtID2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.Parse(e.KeyChar.ToString().ToUpper());
        }
    }
}
