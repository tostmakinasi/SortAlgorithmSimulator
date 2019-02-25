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
            int[] n = {Convert.ToInt32(btn1.Text), Convert.ToInt32(btn2.Text), Convert.ToInt32(btn3.Text), Convert.ToInt32(btn4.Text), Convert.ToInt32(btn5.Text), Convert.ToInt32(btn6.Text)};
            Panel[] p = { pnl1, pnl2, pnl3, pnl4, pnl5, pnl6 };

            int temp;
            int x1 = 0,x2=0,y1=0, y2 = 0, i=0;
            for(i=0; i<n.Length; i++)
            {
                for(int j=0; j<n.Length-1; j++)
                {
                    if (n[j] > n[j+1])
                    {
                        temp = n[j];
                        n[j] = n[j+1];
                        n[j+1] = temp;
                        x1 = p[j].Location.X;
                        y1 = p[j].Location.Y;
                        x2 = p[j + 1].Location.X;
                        y2 = p[j + 1].Location.Y;
                        p[j].Location = new Point(x2, y2);
                        p[j + 1].Location = new Point(x1, y1);
                        
                    }
                }
               
                
            }
                
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            sortBuble();
        }

        private void pnlsayilar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
