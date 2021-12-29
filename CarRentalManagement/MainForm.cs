﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Private functions
        private void openChild(Object child)
        {
            if (this.panelMainShowForms.Controls.Count > 0)
                this.panelMainShowForms.Controls.RemoveAt(0);
            Form f = child as Form;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.panelMainShowForms.Controls.Add(f);
            this.panelMainShowForms.Tag = f;
            f.Show();
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            openChild(new Welcome());
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            openChild(new CarsForm.Car());
        }
    }
}
