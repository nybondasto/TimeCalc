using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aikalaskin
{
    public partial class Form1 : Form
    {
        private System.Drawing.Color NormalColor = System.Drawing.Color.White;
        private System.Drawing.Color FocusColor = System.Drawing.Color.FromArgb(255, 230, 204);


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            doCalc();
        }

        private void moveToEnd(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                kloLoppu.Focus();
            }
        }



        private void doCalc()
        {
            DateTime alku = DateTime.Parse(kloAlku.Text);
            DateTime loppu = DateTime.Parse(kloLoppu.Text);

            System.TimeSpan erotus = loppu - alku;

            int h = erotus.Hours;
            int m = erotus.Minutes;

            lblTulos.Text = h.ToString() + " h " + m.ToString() + " m";
        }

        private void moveToCalc(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                doCalc();
            }
        }

        private void clear()
        {
            kloAlku.Text = "";
            kloLoppu.Text = "";
            lblTulos.Text = "---";
            kloAlku.Focus();
        }

        private void EnterEvent(object sender, EventArgs e)
        {
            if (sender is TextBox)
                ((TextBox)sender).BackColor = FocusColor;
        }

        private void LeaveEvent(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).BackColor = NormalColor;

                TextBox txt = (TextBox)sender;

                if (txt.Text.Trim() != "")
                {
                    DateTime temp;
                    if (DateTime.TryParse(txt.Text, out temp))
                    {

                    }
                    else
                    {
                        MessageBox.Show("Given text is not valid time!");
                        txt.Focus();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear(); 
        }
    }
}
