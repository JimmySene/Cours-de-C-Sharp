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
        /*int operande1 = 0, operande2 = 0, resultat = 0;
        string operateur;*/

        struct Calcul
        {
            public int op1;
            public string operateur;
            public int op2;
            public int resultat;
        }

        List<Calcul> calculs = new List<Calcul>();
        Calcul calculActuel;
        string memoire = "0";
        bool ruban = false;
        
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
            calculActuel.op1 = 0;
        }

        private void bt_plus_Click(object sender, EventArgs e)
        {

            calculActuel.op1 = Int32.Parse(tb_resultat.Text);
            tb_resultat.Text = "";
            calculActuel.operateur = "+";

        }

        private void bt_moins_Click(object sender, EventArgs e)
        {

            calculActuel.op1 = Int32.Parse(tb_resultat.Text);
            tb_resultat.Text = "";
            calculActuel.operateur = "-";
        }

        private void bt_fois_Click(object sender, EventArgs e)
        {
            calculActuel.op1 = Int32.Parse(tb_resultat.Text);
            tb_resultat.Text = "";
            calculActuel.operateur = "*";
        }

        private void bt_res_Click(object sender, EventArgs e)
        {
            switch(calculActuel.operateur)
            {
                case "+":
                    calculActuel.op2 = Int32.Parse(tb_resultat.Text);
                    calculActuel.resultat = calculActuel.op1 + calculActuel.op2;
                    tb_resultat.Text = calculActuel.resultat.ToString();
                    calculs.Add(calculActuel);
                    calculActuel.op1 = calculActuel.resultat;
                    break;
                case "-":
                    calculActuel.op2 = Int32.Parse(tb_resultat.Text);
                    calculActuel.resultat = calculActuel.op1 - calculActuel.op2;
                    tb_resultat.Text = calculActuel.resultat.ToString();
                    calculs.Add(calculActuel);
                    calculActuel.op1 = calculActuel.resultat;
                    break;
                case "*":
                    calculActuel.op2 = Int32.Parse(tb_resultat.Text);
                    calculActuel.resultat = calculActuel.op1 * calculActuel.op2;
                    tb_resultat.Text = calculActuel.resultat.ToString();
                    calculs.Add(calculActuel);
                    calculActuel.op1 = calculActuel.resultat;
                    break;
                case "/":
                    if (tb_resultat.Text != "0" && tb_resultat.Text != "Error mamene")
                    {
                        calculActuel.op2 = Int32.Parse(tb_resultat.Text);
                        calculActuel.resultat = calculActuel.op1 / calculActuel.op2;
                        tb_resultat.Text = calculActuel.resultat.ToString();
                        calculs.Add(calculActuel);
                        calculActuel.op1 = calculActuel.resultat;
                    } else
                    {
                        tb_resultat.Text = "Error mamene";
                    }
                    break;
                default:
                    break;
            }
            rtb_ruban.Clear();
            foreach(Calcul calc in calculs)
            {
                rtb_ruban.Text += calc.op1 + " " + calc.operateur + " " + calc.op2 + " = " + calc.resultat;
                rtb_ruban.Text += Environment.NewLine;
                
            }
        }

        private void bt_div_Click(object sender, EventArgs e)
        {
            calculActuel.op1 = Int32.Parse(tb_resultat.Text);
            tb_resultat.Text = "";
            calculActuel.operateur = "/";
        }

        private void bt_m_Click(object sender, EventArgs e)
        {
            if (tb_resultat.Text.Length != 0)
            {
                memoire = tb_resultat.Text;
                tb_resultat.Text = "";
            }
            else
                tb_resultat.Text = memoire;
        }

        private void bt_r_Click(object sender, EventArgs e)
        {
            if (ruban)
            {
                this.Width = 300;
                ruban = false;
            }
            else
            {
                this.Width = 613;
                ruban = true;
            }
                
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
