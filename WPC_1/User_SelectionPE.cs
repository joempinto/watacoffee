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
    public partial class User_SelectionPE : Form
    {
        public User_SelectionPE()
        {
            InitializeComponent();
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            addPagamentBtn.Visible = true;
            deletePagamentBtn.Visible = true;
        }

        private void labelCancelSelecPE_Click(object sender, EventArgs e)
        {
            usuari_Menu menuUser = new usuari_Menu();
            menuUser.Show();
            this.Close();
            //TODO tancar també el formulari User_menu
        }

        private void pictureBoxPay_Click(object sender, EventArgs e)
        {
            payBtn_Click(sender, e);
        }

        private void grafsBtn_Click(object sender, EventArgs e)
        {
            User_Graphs grafics = new User_Graphs();
            grafics.Show();
            this.Close();
            //TODO tancar també el formulari User_menu
        }

        private void pictureBoxGrafs_Click(object sender, EventArgs e)
        {
            grafsBtn_Click(sender, e);
        }

        private void addPagamentBtn_Click(object sender, EventArgs e)
        {
            User_PayMenu payMenu = new User_PayMenu();
            payMenu.Show();
            this.Close();
        }

        private void deletePagamentBtn_Click(object sender, EventArgs e)
        {
            User_deletePagament deleteMenu = new User_deletePagament();
            deleteMenu.Show();
            this.Close();
        }
    }
}
