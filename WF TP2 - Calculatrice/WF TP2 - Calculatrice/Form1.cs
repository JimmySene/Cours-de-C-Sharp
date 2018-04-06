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

        struct Calcul
        {
            public double op1;
            public string operateur;
            public double op2;
            public double resultat;
        }

        List<Calcul> calculs = new List<Calcul>();
        Calcul calculActuel;
        
        string memoire = "0";
        bool ruban = false; // RUBAN CACHÉ PAR DEFAUT

        public Form1()
        {
            InitializeComponent();
            rtb_ruban.Text += "Il y a " + calculs.Count + " opérations.";
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

        private void bt_c_Click(object sender, EventArgs e) // BOUTON CLEAR
        {
            tb_resultat.Text = "";
            calculActuel.op1 = 0;
        }

        private void bt_plus_Click(object sender, EventArgs e) // BOUTON ADDITION
        {

            
            calculActuel.op1 = Convert.ToDouble(tb_resultat.Text); 
            tb_resultat.Text = "";
            calculActuel.operateur = "+";

        }

        private void bt_moins_Click(object sender, EventArgs e) // BOUTON SOUSTRACTION
        {

            calculActuel.op1 = Convert.ToDouble(tb_resultat.Text);
            tb_resultat.Text = "";
            calculActuel.operateur = "-";
        }

        private void bt_fois_Click(object sender, EventArgs e) // BOUTON MULTIPLICATION
        {
            calculActuel.op1 = Convert.ToDouble(tb_resultat.Text);
            tb_resultat.Text = "";
            calculActuel.operateur = "*";
        }

        private void bt_div_Click(object sender, EventArgs e) // BOUTON DIVISION
        {
            calculActuel.op1 = Convert.ToDouble(tb_resultat.Text);  
            tb_resultat.Text = "";
            calculActuel.operateur = "/";
        }

        private void bt_res_Click(object sender, EventArgs e) // BOUTON RESULTAT
        {
            switch(calculActuel.operateur) // TESTE OPÉRATEUR
            {
                case "+":
                    calculActuel.op2 = Convert.ToDouble(tb_resultat.Text); 
                    calculActuel.resultat = calculActuel.op1 + calculActuel.op2;
                    tb_resultat.Text = calculActuel.resultat.ToString();
                    calculs.Add(calculActuel);
                    calculActuel.op1 = calculActuel.resultat;
                    break;
                case "-":
                    calculActuel.op2 = Convert.ToDouble(tb_resultat.Text); 
                    calculActuel.resultat = calculActuel.op1 - calculActuel.op2;
                    tb_resultat.Text = calculActuel.resultat.ToString();
                    calculs.Add(calculActuel);
                    calculActuel.op1 = calculActuel.resultat;
                    break;
                case "*":
                    calculActuel.op2 = Convert.ToDouble(tb_resultat.Text); 
                    calculActuel.resultat = calculActuel.op1 * calculActuel.op2;
                    tb_resultat.Text = calculActuel.resultat.ToString();
                    calculs.Add(calculActuel);
                    calculActuel.op1 = calculActuel.resultat;
                    break;
                case "/":
                    if (tb_resultat.Text != "0" && tb_resultat.Text != "Error mamene") // TESTE DIVISION PAR 0
                    {
                        calculActuel.op2 = Convert.ToDouble(tb_resultat.Text); 
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

            /* STOCKAGE DU CALCUL DANS LE RUBAN */

            rtb_ruban.Clear();
            foreach(Calcul calc in calculs)
            {
                rtb_ruban.Text += calc.op1 + " " + calc.operateur + " " + calc.op2 + " = " + calc.resultat;
                rtb_ruban.Text += Environment.NewLine;
                
            }
            rtb_ruban.Text += "Il y a " + calculs.Count + " opérations.";
        }

        private void bt_m_Click(object sender, EventArgs e) // BOUTON MÉMOIRE
        {
            if (tb_resultat.Text.Length != 0) // ON A ENTRÉ QUELQUE CHOSE DONC ON STOCK EN MÉMOIRE
            {
                memoire = tb_resultat.Text;
                tb_resultat.Text = "";
            }
            else // IL N'Y A RIEN D'ENTRÉ DONC ON AFFICHE LA VALEUR STOCKÉ DANS LA MÉMOIRE
                tb_resultat.Text = memoire;
        }

        private void bt_r_Click(object sender, EventArgs e) // BOUTON RUBAN
        {
            if (ruban) // CACHE LE RUBAN
            {
                this.Width = 300;
                ruban = false;
            }
            else // AFFICHE LE RUBAN
            {
                this.Width = 613;
                ruban = true;
            }
                
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // calculActuel.op1 = Convert.ToDouble(tb_resultat.Text);
            tb_resultat.Text =  Convert.ToString(Convert.ToDouble(tb_resultat.Text) * Convert.ToDouble(tb_resultat.Text) * Convert.ToDouble(tb_resultat.Text));
        }
    }
}
