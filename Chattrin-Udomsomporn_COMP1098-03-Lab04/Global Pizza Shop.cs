using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;

namespace Chattrin_Udomsomporn_COMP1098_03_Lab04
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }




        

        private void bttAddorder_Click(object sender, EventArgs e)
        {
            double smallcost = 10.00;
            double mediumcost = 12.00;
            double largecost = 14.00;
            double totalsize = 0;
            double total = 0;
            double totalcheck = 0;
            double totalmeat = 0;
            double totalveg = 0;
            Random random = new Random();
            int rd = random.Next(101, 999);
            textorder.Text = rd.ToString();

           

            if (comboSize.SelectedItem.Equals("Small"))
            {
                totalsize = smallcost;
            }
            if(comboSize.SelectedItem.Equals("Large"))
            {
                totalsize = largecost;
            }
            if(comboSize.SelectedItem.Equals("Medium"))
            {
                totalsize = mediumcost;
            }

            var meatbox = new CheckBox[] { chkPep, chkHam, chkSau, chkChe };
            var vegbox = new CheckBox[] { chkMus, chkOli, chkOni, chkPeppers, chkPin };
           

            foreach (CheckBox meat in meatbox)
            {

                if (meat.Checked)
                {
                    totalcheck = totalcheck + 1.00;
                }

                totalmeat = totalcheck;
            }

            foreach (CheckBox veg in vegbox)
            {

                if (veg.Checked)
                {
                    totalcheck = totalcheck + 1.00;
                }

                totalveg = totalcheck;
            }

            total = totalmeat + totalveg + totalsize;
            double taxtotal = total + (total * .13);
            totallabel.Text = total.ToString("C2",System.Globalization.CultureInfo.GetCultureInfo("en-ca"));


            summary.Text = "Order Number" + "   " + "Customer name" + "   " + "Price" + "\n" +
                            textorder.Text .ToString().PadRight(24)+textname.Text.ToString().PadRight(20) + total.ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("en-ca"));
            

            grandtotal.Text = taxtotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-ca"));
            
        }


        

        private void comboSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bttClearorder_Click(object sender, EventArgs e)
        {
            double smallcost = 10.00;
            double mediumcost= 12.00;
            double largecost = 14.00;
            double taxtotal = 0;
            var box = new CheckBox[] { chkPep, chkHam, chkSau, chkChe, chkMus, chkOli, chkOni, chkPeppers, chkPin };


            foreach (CheckBox item in box)
            {

                if (item.Checked)
                {
                    item.Checked = false;
                    if (comboSize.SelectedItem.Equals("Small"))
                    {
                        totallabel.Text = smallcost.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-ca"));
                        taxtotal = smallcost + (smallcost * 0.13);
                         grandtotal.Text = taxtotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-ca"));
                    }
                   
                    if (comboSize.SelectedItem.Equals("Large"))
                    {
                        totallabel.Text = largecost.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-ca"));
                        taxtotal = largecost + (largecost * 0.13);
                        grandtotal.Text = taxtotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-ca"));
                    }

                    if (comboSize.SelectedItem.Equals("Medium"))
                    {
                        totallabel.Text=mediumcost.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-ca"));
                        taxtotal = mediumcost + (mediumcost * 0.13);
                        grandtotal.Text = taxtotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-ca"));
                    }



                }


            }
            summary.Text = "Order Number" + "   " + "Customer name" + "   " + "Price" + "\n" +
                           textorder.Text.ToString().PadRight(24) + textname.Text.ToString().PadRight(23);

        }
        private void bttUpd_Click(object sender, EventArgs e)
        {
            summary.Text = "Order Number" + "   " + "Customer name" + "   " + "Price" + "\n" +
                            textorder.Text.ToString().PadRight(24) + textname.Text.ToString().PadRight(23);

        }


        private void bttClearinfor_Click(object sender, EventArgs e)
        {
            if (summary.Text != null)
            {
                summary.Text = null;
            }
        }

        private void bttClearall_Click(object sender, EventArgs e)
        {
            if (summary.Text != null)
            {
                summary.Text = null;
            }
            if ( textname.Text != null)
            {
                 textname.Text = null;
            }
            if (textorder.Text != null)
            {
                textorder.Text = null;
            }
            if (textphone.Text != null)
            {
                textphone.Text = null;
            }
            if (textaddress.Text != null)
            {
                textaddress.Text = null;
            }
            if (!comboSize.SelectedItem.Equals(null))
            {
                comboSize.SelectedItem = null;
            }
            if (!comboType.SelectedItem.Equals(null))
            {
                comboType.SelectedItem = null;
            }
            if (totallabel.Text != null)
            {
                totallabel.Text = null;
            }
            if (totallabel.Text != null)
            {
                totallabel.Text = null;
            }
            if (grandtotal.Text != null)
            {
                grandtotal.Text = null;
            }
            var box = new CheckBox[] { chkPep, chkHam, chkSau, chkChe, chkMus, chkOli, chkOni, chkPeppers, chkPin };


            foreach (CheckBox item in box)
            {

                if (item.Checked)
                {
                    item.Checked = false;

                }

            }
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
