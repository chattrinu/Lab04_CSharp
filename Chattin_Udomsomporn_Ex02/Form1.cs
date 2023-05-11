using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Chattin_Udomsomporn_Ex02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void bttInp_Click(object sender, EventArgs e)
        {
             num2.Items.Add(txtnum1.Text);
        }



        private void num2_Click(object sender, EventArgs e)
        {

        }

        private void bttSum_Click(object sender, EventArgs e)
        {
            decimal sum = 0;
            for (int i=0; i < num2.Items.Count; i++)
            {
                sum += Convert.ToDecimal(num2.Items[i]);
            }
            txtnum1.Text = "Sum:"+sum.ToString();
           
        }

        private void bttAve_Click(object sender, EventArgs e)
        {
            decimal sum = 0;
            int count = 0;
            for (int i = 0; i < num2.Items.Count; i++)
            {
                sum += Convert.ToDecimal(num2.Items[i]);
                count++;

            }
            decimal average = sum / count;
            txtnum1.Text = "Average;" + average.ToString();

        }

        private void bttCle_Click(object sender, EventArgs e)
        {
            if (txtnum1 != null)
            {
                txtnum1.Text = null;
            }
        }

        private void bttRem_Click(object sender, EventArgs e)
        {
            num2.Items.Remove(num2.SelectedItem);
        }

        private void num2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
