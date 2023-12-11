using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPC_1.old.common;

namespace WPC_1
{
    public partial class User_PayMenu : Form
    {
        public User_PayMenu()
        {
            InitializeComponent();
        }

        private void User_PayMenu_Load(object sender, EventArgs e)
        {
            string location = String.Concat("[USER] ", AppInformation.usuari.Email,
                        " > Menu Usuari > Pagaments >");
            pageLocation.Text = location;
        }
    }

    //Probar si sirve para actualizar tabla
    /*public MasterPage()
    {
        IObservable.AgregarObservador(this);
    }*/
}
