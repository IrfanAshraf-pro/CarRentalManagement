using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarBusinessLogic.CarLogic;
using CarBusinessLogic.Finance;
using CarBusinessLogic.Maintenance;

namespace CarRentalManagement.Functionality
{
    public partial class Finance : Form
    {
        public Finance()
        {
            InitializeComponent();
        }
        #region private functions

        private void readingCars()
        {
            AddCarLogic car = new AddCarLogic();
            var carList = car.carLogicRead();
            foreach (var c in carList)
            {
                cmbxFinanceCarSearch.Items.Add(c.regNo);
            }
        }
        private void readingFinanceOfCar()
        {
            FinanceBl fl = new FinanceBl();
                var readFinance = fl.readingCarFinances(cmbxFinanceCarSearch.SelectedItem.ToString());
                dgvFinance.Rows.Clear();
                foreach (var item in readFinance)
                {
                    dgvFinance.Rows.Add(item.carName, item.regNum, item.rentId, item.rentDate, item.returnDate, item.fee, item.returnedDate, item.fine);
                }
           
        }
        private void readingMaintenance()
        {
                MaintenanceBl ml = new MaintenanceBl();
                String querry = "select m.mdate,m.price,retCar.RegNum from maintenance m join ReturnCars retCar on retCar.RegNum = m.RegNum";
               var mlist=ml.readMaintenance(querry);
                dgvMaintenanceInFinance.Rows.Clear();
                foreach (var item in mlist)
                {
                    dgvMaintenanceInFinance.Rows.Add(item.regNo, item.date, item.price);
                }
            
        }

        #endregion

        private void Finance_Load(object sender, EventArgs e)
        {
            readingCars();
        }

        private void btnFinanceSearch_Click(object sender, EventArgs e)
        {
           if(cmbxFinanceCarSearch.SelectedItem!=null)
            {
                readingMaintenance();
                readingFinanceOfCar();
            }
        }
    }
}
