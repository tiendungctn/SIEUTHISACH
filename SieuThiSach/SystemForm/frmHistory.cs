using SieuThiSach.AllForm;
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
        public string TB_History = "";
        public List<string> namecolumns = new List<string>();
        public string _Filter = "";
        public string ID1;
        public string ID2;
        int vCheck;
        private void loadData()
        {
            vCheck = DatLoa.loadDataToListView("*", _Filter, Convert.ToInt16(txtTest.Text), ref lstHistory);
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
            string vFilter = " where NGAY_SUA >= '" + dStartDate.Text + "' and DATEADD(DD,-1, NGAY_SUA) <= '" + dEndDate.Text + "' ";
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
            btnBack.Enabled = false;       
            lstHistory.Clear();
            _Filter = TB_History + _Filter + " order by NGAY_SUA desc";
            loadData();
            if (vCheck == 1)//Có load Next không ?
                btnNext.Enabled = false;
            else btnNext.Enabled = true;
            dStartDate.Text = DatLoa.NameReturn("min(ngay_sua)", TB_History, "(1=1)");
            lblID1.Text = lstHistory.Columns[0].Text;
            lblID2.Text = lstHistory.Columns[1].Text;
        }

        private void frmHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            namecolumns.Clear();
        }

        private bool Find = false;
        private void btnFind_Click(object sender, EventArgs e)
        {
            Find = true;
            txtTest.Text = "1"; page = 1;
            FindData();
            frmHistory_Load(sender, e);
            Find = false;
        }

        private void txtID2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.Parse(e.KeyChar.ToString().ToUpper());
        }

        int page = 1;
        private void btnNext_Click(object sender, EventArgs e)
        {
            page = page + 1;
            txtTest.Text = page.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            page = page - 1;
            txtTest.Text = page.ToString();
        }

        private void txtTest_TextChanged(object sender, EventArgs e)
        {
            if (!Find)
            {
                #region "Load Data"
                lstHistory.Clear();
                loadData();
                dStartDate.Text = DatLoa.NameReturn("min(ngay_sua)", TB_History, "(1=1)");
                lblID1.Text = lstHistory.Columns[0].Text;
                lblID2.Text = lstHistory.Columns[1].Text;
                #endregion
                if (vCheck == 1)
                    btnNext.Enabled = false;
                else btnNext.Enabled = true;
                if (page == 1)
                    btnBack.Enabled = false;
                else btnBack.Enabled = true;
            }
            
        }

        private void lstHistory_DoubleClick(object sender, EventArgs e)
        {
            if (TB_History == "V_DS_Hoa_Don " || TB_History == "V_CT_HD_MH_HISTORY ")
            {
                string MA_HD = "";
                string MA_DVI = "";
                string LOAI = "";
                foreach (ListViewItem items in lstHistory.SelectedItems)
                {
                    MA_HD = items.SubItems[1].Text;
                    MA_DVI = items.SubItems[0].Text;
                    LOAI = items.SubItems[11].Text;
                }
                frmHD callForm = new frmHD();
                callForm.MA_HD = MA_HD;
                callForm.MA_DVI = MA_DVI;
                callForm.LOAI = LOAI;
                callForm.ShowDialog();
            }
        }
    }
}
