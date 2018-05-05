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
        string _Filter ;
        private void loadData()
        {
            DatLoa.loadDataToListView("*", _Filter, ref lstHistory);
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            _Filter = TB_History + " order by NGAY_SUA desc";
            loadData();
        }
    }
}
