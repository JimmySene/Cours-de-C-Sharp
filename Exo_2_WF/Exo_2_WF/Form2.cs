using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo_2_WF
{
    public partial class Form2 : Form
    {
        public Form2(string nom, string prenom)
        {
            InitializeComponent();
            tb_email.Text = nom + "." + prenom + "@jimdev.fr";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
