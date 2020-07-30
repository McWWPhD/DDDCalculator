using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDDCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResult.Visible = false;

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double dose = Convert.ToDouble(numDose.Value);
                int numberInPackage = Convert.ToInt32(numDoseInOnePackage.Value);
                double DDDInDose = Convert.ToDouble(numDDDInOneDose.Value);
                int packages = Convert.ToInt32(numNumberOfPackages.Value);


                var result = DDDCalculator.CalculateDDD(dose, numberInPackage, DDDInDose, packages);
                lblResult.Visible= true;

                lblResult.Text = result.ToString("N");

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }


        }
    }
}
