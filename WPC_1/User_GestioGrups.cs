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
    public partial class User_GestioGrups : Form
    {
        public User_GestioGrups()
        {
            InitializeComponent();
        }

        private void User_GestioGrups_Load(object sender, EventArgs e)
        {
            string location = String.Concat("[USER] ", AppInformation.usuari.Email,
                        " > Gestió de la aplicació");
            pageLocation.Text = location;
        }

        private void iniciStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            usuari_Menu user_Menu = new usuari_Menu();
            user_Menu.Show();
        }

        private void creaGrupBtn_Click(object sender, EventArgs e)
        {
            User_addGrup addGroupMenu = new User_addGrup();
            addGroupMenu.Show();
        }
    }
}
