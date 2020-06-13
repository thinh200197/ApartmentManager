using DevExpress.Utils.VisualEffects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentManager
{
    public partial class frmCommon : Form
    {
        public frmCommon()
        {
            InitializeComponent();
            LoadDataGirdView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "This is messege ");
            
        }
        private void LoadDataGirdView()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("BirDay");
            dt.Columns.Add("Code");
            dt.Columns.Add("Phone");
            DataRow _ravi = dt.NewRow();
            _ravi["ID"] = "ravi";
            _ravi["Name"] = "ravi";
            _ravi["BirDay"] = "ravi";
            _ravi["Code"] = "ravi";
            _ravi["Phone"] = "500";
            dt.Rows.Add(_ravi);

        }
    }

}
