using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetirementCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] portfolios = new string[5] {"Conservative", "Moderate-Conservative", "Moderate",
             "Moderate-Aggressive", "Aggressive"};
        string[] models = new string[5]
        {
            "6% Large Cap, 2% Mid Cap, 2% Small Cap, 5% International, 85% Bonds",
            "15% Large Cap, 5% Mid Cap, 5% Small Cap, 5% International, 70% Bonds",
            "40% Large Cap, 5% Mid Cap, 5% Small Cap, 5% International, 45% Bonds",
            "60% Large Cap, 5% Mid Cap, 5% Small Cap, 5% International, 25% Bonds",
            "80% Large Cap, 5% Mid Cap, 5% Small Cap, 5% International, 5% Bonds"
        };

        private void btReset_Click(object sender, EventArgs e)
        {
            tbYearsInvested.Clear();
            tbAmountInvested.Clear();
            tbRiskQ1.Clear();
            tbRiskQ2.Clear();
            tbRiskQ3.Clear();
            tbRiskQ4.Clear();
            tbRiskQ5.Clear();
            lbResult.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double futureAmount;
            double years = double.Parse(tbYearsInvested.Text);
            double amount = double.Parse(tbAmountInvested.Text);

            double q1 = double.Parse(tbRiskQ1.Text);
            double q2 = double.Parse(tbRiskQ2.Text);
            double q3 = double.Parse(tbRiskQ3.Text);
            double q4 = double.Parse(tbRiskQ4.Text);
            double q5 = double.Parse(tbRiskQ5.Text);
            double total = q1 + q2 + q3 + q4 + q5;

            if (total < 7)
            {
                futureAmount = amount * Math.Pow(1 + .04 / 1, 1 * years);
                lbResult.Text = "Your suggested portfolio is " + portfolios[0] + " and has the following mix :\n" + models[0] + "\n" +
                    "Your expected return is 4% and the estimated balance will be " + String.Format("{0:0.00}", futureAmount);
            }
            else if(total < 12)
            {
                futureAmount = amount * Math.Pow(1 + .05 / 1, 1 * years);
                lbResult.Text = "Your suggested portfolio is " + portfolios[1] + " and has the following mix :\n" + models[1] + "\n" +
                    "Your expected return is 5% and the estimated balance will be " + String.Format("{0:0.00}", futureAmount);
            }
            else if(total < 17)
            {
                futureAmount = amount * Math.Pow(1 + .06 / 1, 1 * years);
                lbResult.Text = "Your suggested portfolio is " + portfolios[2] + " and has the following mix :\n" + models[2] + "\n" +
                    "Your expected return is 6% and the estimated balance will be " + String.Format("{0:0.00}", futureAmount);
            }
            else if(total < 22)
            {
                futureAmount = amount * Math.Pow(1 + .07 / 1, 1 * years);
                lbResult.Text = "Your suggested portfolio is " + portfolios[3] + " and has the following mix :\n" + models[3] + "\n" +
                    "Your expected return is 7% and the estimated balance will be " + String.Format("{0:0.00}", futureAmount);
            }
            else
            {
                futureAmount = amount * Math.Pow(1 + .08 / 1, 1 * years);
                lbResult.Text = "Your suggested portfolio is " + portfolios[4] + " and has the following mix :\n" + models[4] + "\n" +
                    "Your expected return is 8% and the estimated balance will be " + String.Format("{0:0.00}", futureAmount);
            }
        }
    }
}
