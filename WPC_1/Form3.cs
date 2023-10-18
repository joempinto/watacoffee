using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPC_1
{
    public partial class usuari_Menu : Form
    {
        public usuari_Menu()
        {
            InitializeComponent();
        }
        private void admin_Menu_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void usuari_Menu_Load(object sender, EventArgs e)
        {
            MessageBox.Show(AppInformation.usuari.ToString());
        }
    }
}
