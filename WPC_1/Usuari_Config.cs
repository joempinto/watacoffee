using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPC_1.User_addGroup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WPC_1
{
    public partial class Usuari_Config : Form
    {
        public Usuari_Config()
        {
            InitializeComponent();
        }

        private void Usuari_Config_Load(object sender, EventArgs e)
        {
            string location = String.Concat("[USER] ", AppInformation.usuari.Email,
                        " > Menu Usuari >");
            pageLocation.Text = location;
        }

        private void labelEsborra_Click(object sender, EventArgs e)
        {
            //Preguntem si usuari està segur de fer del delete del perfil a la app
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            MessageBox.Show("Està segur que vol iniciar el procés per eliminar el perfil a WPC?.", "Atenció!", button, icon);

            //Farem DELETE de la sessió amb el header (el head i el token)
            //En aquest cas el header, per ser un usuari, haurà de ser 'CBS'

            // Creem deleteUser assignant les dades que tenim en memoria a Appinformation (head i token)            
            string header = String.Concat(AppInformation.usuari.Head, AppInformation.usuari.Token);
            UserAuthorization auth = new UserAuthorization(header);
            //fem logout
            doDelete(auth);

        }

        async void doDelete(UserAuthorization aut)
        {
            HttpClient httpClient = new HttpClient();
            string url = "http://localhost:8080/coffee/api/auth/delete";            
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(aut.Authorization);
            using HttpResponseMessage response = await httpClient.DeleteAsync(url);


            // Primer mirem si la resposta del server es SUCCESS. Si no ho es, mostrem error.
            if (!response.IsSuccessStatusCode)
            {

                // Si la resposta es NO SUCCESS, mostrem error
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                MessageBox.Show("Error al fer DELETE. Torna a intentar-ho \n" + response, "Error", button, icon);
            }
            else
            {
                // Si la resposta es SUCCESS

                // Creem un objecte de tipus String per agafar les dades que retorna el server (String confirmant delete)                               
                var resposta = await response.Content.ReadAsStringAsync();
                MessageBox.Show("DELETE correcte! " + resposta, "Info");

                // Tanquem el Formulari
                this.Close();
                //crea nou form1 i es queda obert - tindriem dos Form1 oberts
                Login_inici inici = new Login_inici();
                inici.ShowDialog();
            }
        }

        private void pictureBoxEsborra_Click(object sender, EventArgs e)
        {
            labelEsborra_Click(sender, e);
        }

        private void labelCanviPwd_Click(object sender, EventArgs e)
        {
            CanviContrasenya modPass = new CanviContrasenya();
            modPass.Show();
        }

        private void pictureBoxCanviPwd_Click(object sender, EventArgs e)
        {
            labelCanviPwd_Click(sender, e);
        }

        private void iniciStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            usuari_Menu user_Menu = new usuari_Menu();
            user_Menu.Show();
        }

        private void logoutStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            usuari_Menu user_Menu = new usuari_Menu();
            user_Menu.button1_Click(sender, e); //dologout
        }

        private void labelShowInfo_Click(object sender, EventArgs e)
        {
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            MessageBox.Show("INFORMACIÓ USUARI\n"
                + "USERNAME: " + AppInformation.usuari.Username
                + "\nEMAIL: " + AppInformation.usuari.Email, "Info de Compte", button, icon);
        }
    }
}
