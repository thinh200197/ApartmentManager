﻿using ApartmentManager.DAO;
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
    public partial class frmRegisteredResident : Form
    {
        public frmRegisteredResident()
        {
            InitializeComponent();
        }

        private void frmRegisteredResident_Load(object sender, EventArgs e)
        {
            gv_RegisteredResident.DataSource = ResidentApartmentDAO.Instance.GetAllResidentApartment();
        }

        private void gv_RegisteredResident_ClickCell(object sender, Infragistics.Win.UltraWinGrid.ClickCellEventArgs e)
        {

        }
    }
}
