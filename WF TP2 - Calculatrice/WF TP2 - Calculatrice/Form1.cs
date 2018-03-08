using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_TP2___Calculatrice
{
    public partial class Form1 : Form
    {
        int operande1 = 0, operande2 = 0, resultat = 0;
        string operateur;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            tb_resultat.Text += "0";
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            tb_resultat.Text += "1";
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            tb_resultat.Text += "2";
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            tb_resultat.Text += "3";
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            tb_resultat.Text += "4";
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            tb_resultat.Text += "5";
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            tb_resultat.Text += "6";
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            tb_resultat.Text += "7";
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            tb_resultat.Text += "8";
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            tb_resultat.Text += "9";
        }

        private void bt_c_Click(object sender, EventArgs e)
        {
            tb_resultat.Text = "";
            operande1 = 0;
        }

        private void bt_plus_Click(object sender, EventArgs e)
        {

            operande1 = Int32.Parse(tb_resultat.Text);
            tb_resultat.Text = "";
            operateur = "+";

        }

        private void bt_moins_Click(object sender, EventArgs e)
        {

            operande1 = Int32.Parse(tb_resultat.Text);
            tb_resultat.Text = "";
            operateur = "-";
        }

        private void bt_fois_Click(object sender, EventArgs e)
        {
            operande1 = Int32.Parse(tb_resultat.Text);
            tb_resultat.Text = "";
            operateur = "*";
        }

        private void bt_res_Click(object sender, EventArgs e)
        {
            switch(operateur)
            {
                case "+":
                    resultat = operande1 + Int32.Parse(tb_resultat.Text);
                    tb_resultat.Text = resultat.ToString();
                    break;
                case "-":
                    resultat = operande1 - Int32.Parse(tb_resultat.Text);
                    tb_resultat.Text = resultat.ToString();
                    break;
                case "*":
                    resultat = operande1 * Int32.Parse(tb_resultat.Text);
                    tb_resultat.Text = resultat.ToString();
                    break;
                case "/":
                    resultat = operande1 / Int32.Parse(tb_resultat.Text);
                    tb_resultat.Text = resultat.ToString();
                    break;
                default:
                    break;
            }
        }

        private void bt_div_Click(object sender, EventArgs e)
        {
            operande1 = Int32.Parse(tb_resultat.Text);
            tb_resultat.Text = "";
            operateur = "/";
        }
    }
}
