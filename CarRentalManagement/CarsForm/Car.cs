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
using System.Text.RegularExpressions;

namespace CarRentalManagement.CarsForm
{
    public partial class Car : Form
    {
        String filepath = "";
        private List<String> patternsList;
      
        public Car()
        {
            InitializeComponent();
        }
        private void patterns()
        {
            patternsList = new List<String>();
            //Plate No
            patternsList.Add(@"^[a-zA-Z]{3}-\d{4}$");
            //Company
            patternsList.Add(@"^[a-zA-Z]+$");
            //Name
            patternsList.Add(@"^[a-zA-Z]+$");
            //Color
            patternsList.Add(@"^[a-zA-Z]+$");
            //Engine No
            patternsList.Add(@"^[a-zA-Z]+$");
            //Model
            patternsList.Add(@"^\d{4}$");

        }
      

  

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                filepath = ofd.FileName;
               // picAddCar.Image = Image.FromFile(filepath);
            }
            else
                filepath = "";
        }

        //private void btnAddCar_Click(object sender, EventArgs e)
        //{
        //    SettingLabels();
        //    try
        //    {
        //        if (filepath!=String.Empty && txtPlateNo.Text!= String.Empty && txtCarName.Text!= String.Empty && txtCompany.Text!= String.Empty && txtColor.Text!= String.Empty && txtModel.Text != String.Empty
        //            && txtEngineNo.Text != String.Empty && (rdBtnAuto.Checked || rdBtnManual.Checked ))
        //        {
        //            if (!checking())
        //            {
        //                AddCarLogic car = new AddCarLogic();
        //                car.plateNo = txtPlateNo.Text;
        //                car.name = txtCarName.Text;
        //                car.company = txtCompany.Text;
        //                car.color = txtColor.Text;
        //                car.model = int.Parse(txtModel.Text);
        //                car.engineNo = txtEngineNo.Text;
        //                if (rdBtnAuto.Checked)
        //                    car.transmission = 1;
        //                else
        //                    car.transmission = 0;
        //                car.carLogicAdd();

        //            }

        //        }
        //        else
        //        {
        //            if (filepath == String.Empty)
        //                lblPicError.Text = "Please select a File to Upload";
        //            if (txtPlateNo.Text == String.Empty)
        //                lblPlateNoError.Text = "Please enter plate no";
        //            if (txtCompany.Text == String.Empty)
        //                lblCompanyError.Text = "Please enter company of car";
        //            if (txtCarName.Text == String.Empty)
        //                lblNameError.Text = "Please enter name of Car";
        //            if (rdBtnAuto.Checked || rdBtnManual.Checked)
        //            {}
        //            else
        //               lblTransmissionError.Text = "Please select mode of Transmission";
        //            if (txtColor.Text == String.Empty)
        //                lblColorError.Text = "Please enter color of Car";
        //            if (txtEngineNo.Text == String.Empty)
        //                lblEngineNoError.Text = "Please enter color of Car";
        //            if (txtModel.Text == String.Empty)
        //                lblModelError.Text = "Plese enter Model of car";
                   
        //        }
                
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}
        //private bool checking()
        //{
        //    String plateNo = "", carName = "", company = "", color = "", model = "", engineNo = "", transmission = "";
        //    bool check = false;
        //    #region matchingWithPatterns

        //    if (Regex.IsMatch(txtPlateNo.Text, patternsList[0]))
        //        plateNo = txtPlateNo.Text;
        //    else
        //    {
        //        lblPlateNoError.Text = "Please enter correct plate no";
        //        check = true;
        //    }
        //    if (Regex.IsMatch(txtCompany.Text, patternsList[1]))
        //        company = txtCompany.Text;
        //    else
        //    {
        //        lblCompanyError.Text = "Please enter correct company name";
        //        check = true;
        //    }
        //    if (Regex.IsMatch(txtCarName.Text, patternsList[2]))
        //        carName = txtCarName.Text;
        //    else
        //    {
        //        lblNameError.Text = "Please enter correct car name";
        //        check = true;
        //    }
        //    if (rdBtnAuto.Checked)
        //        transmission = rdBtnAuto.Text;
        //    else if (rdBtnManual.Checked)
        //        transmission = rdBtnManual.Text;
        //    else
        //    {
        //        lblTransmissionError.Text = "Please select mode of Transmission";
        //        check = true;
        //    }
        //    if (Regex.IsMatch(txtColor.Text, patternsList[3]))
        //        color = txtColor.Text;
        //    else
        //    {
        //        lblColorError.Text = "Please select correct color of car";
        //        check = true;
        //    }
        //    if (Regex.IsMatch(txtEngineNo.Text, patternsList[4]))
        //        engineNo = txtEngineNo.Text;
        //    else
        //    {
        //        lblEngineNoError.Text = "Please enter correct Engine No";
        //        check = true;
        //    }
        //    if (Regex.IsMatch(txtModel.Text, patternsList[5]))
        //        model = txtModel.Text;
        //    else
        //    {
        //        lblModelError.Text = "Please enter correct model of Car";
        //        check = true;
        //    }
        //    return check;
        //    #endregion
        //}
        //private void SettingLabels()
        //{
        //    lblColorError.Text = "";
        //    lblCompanyError.Text = "";
        //    lblEngineNoError.Text = "";
        //    lblModelError.Text = "";
        //    lblNameError.Text = "";
        //    lblPicError.Text = "";
        //    lblPlateNoError.Text = "";
        //    lblTransmissionError.Text = "";
            
        //}

        private void AddCar_Load(object sender, EventArgs e)
        {
            patterns();
          //  SettingLabels();
        }

        private void picAddCar_Click(object sender, EventArgs e)
        {

        }
    }
}
