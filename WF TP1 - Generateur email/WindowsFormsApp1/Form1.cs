using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nom = tb_nom.Text;
            String prenom = tb_prenom.Text;
            String societe = tb_societe.Text;

            String email = prenom.Substring(0, 3) + "_" + nom + "@" + societe + ".com";
            tb_email.Text = email.ToLower();
        }

        private void tb_nom_Leave(object sender, EventArgs e)
        {
            string nom = tb_nom.Text.ToUpper();
            tb_nom.Text = nom;
        }

        private void tb_prenom_Leave(object sender, EventArgs e)
        {
            string prenom = tb_prenom.Text.ToLower();
            tb_prenom.Text = prenom;
        }
    }
}
