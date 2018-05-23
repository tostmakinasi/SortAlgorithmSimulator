using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgorithmSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            pnlAddNumber.Visible = true;
        }

        private void btnOkNumber_Click(object sender, EventArgs e)
        {
            pnlAddNumber.Visible = false;
            btn1.Text = txt1.Text;
            btn2.Text = txt2.Text;
            btn3.Text = txt3.Text;
            btn4.Text = txt4.Text;
            btn5.Text = txt5.Text;
            btn6.Text = txt6.Text;

            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
            btn5.Visible = true;
            btn6.Visible = true;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked)
                btnstart.Enabled = true;
        }
        public void sortBuble()
        {
            int n1 = Convert.ToInt32(txt1.Text);
            int n2 = Convert.ToInt32(txt2.Text);
            //int n3 = Convert.ToInt32(txt3.Text);
            //int n4 = Convert.ToInt32(txt4.Text);
            //int n5 = Convert.ToInt32(txt5.Text);
            //int n6 = Convert.ToInt32(txt6.Text);

            int temp;
            int x = 0, y = 0;
            if (n1 < n2)
            {
                x = txt1.Location.X;
                y = txt1.Location.Y;
                txt1.Location = txt2.Location;
                txt2.Location = new Point(x, y);
            }
                
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            sortBuble();
        }
    }
}
