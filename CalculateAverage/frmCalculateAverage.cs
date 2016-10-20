/**

 * Name: Ana Luiza Fonseca Teixeira

 * Teacher: Mr. Hardman 

 * Assignment #2, Program #2

 * Date Last Modified: 10/18/2016

 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateAverage
{
    public partial class frmCalculateAverage : Form
    {
        public frmCalculateAverage()
        {
            InitializeComponent();
        }

        private void txtFirstMark_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSecondMark_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtThirdMark_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFourthMark_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFifthMark_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

           
            double mark1;
            double mark2;
            double mark3;
            double mark4;
            double mark5;
            double totalAverage;

            mark1 = Convert.ToDouble(txtFirstMark.Text);
            mark2 = Convert.ToDouble(txtSecondMark.Text);
            mark3 = Convert.ToDouble(txtThirdMark.Text);
            mark4 = Convert.ToDouble(txtFourthMark.Text);
            mark5 = Convert.ToDouble(txtFifthMark.Text);

            totalAverage = (mark1 + mark2 + mark3 + mark4 + mark5 * 1.0) / 5;

            lblResult.Text = string.Format("{0,10}{1,15}\n{2,10}{3,15}\n{4,10}{5,15}\n{6,10}{7,15}\n{8,10}{9,15}\n\n{10,10}{11,15}", "Grade 1:", mark1, "Grade 2:", mark2, "Grade 3:", mark3, "Grade 4:", mark4, "Grade 5:", mark5, "Average:", totalAverage);
          
        }
    }
}
