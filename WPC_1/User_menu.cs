/*
 * created by JMPinto
 */
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPC_1.login;
using WPC_1.logout;
using WPC_1.delete;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            //MessageBox.Show(AppInformation.usuari.ToString());
        }

        private void button1_Click(object sender, EventArgs e) //LOGOUT BUTTON
        {
            //Farem LOGOUT de la sessió amb el header (el head i el token)
            //En aquest cas el header, per ser un usuari, haurà de ser 'CBS'

            // Creem logoutuser assignant les dades que tenim en memoria a Appinformation (head i token)            
            string header = String.Concat(AppInformation.usuari.Head, AppInformation.usuari.Token);
            LogoutInfo logoutUser = new LogoutInfo(header);
            //fem logout
            doLogout(logoutUser);
        }

        async void doLogout(LogoutInfo logoutUser)
        {
            HttpClient httpClient = new HttpClient();
            string url = "http://localhost:8080/coffee/api/auth/logout";
            //MessageBox.Show(logoutUser.Authorization);
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(logoutUser.Authorization);
            using HttpResponseMessage response = await httpClient.PostAsJsonAsync<LogoutInfo>(url, logoutUser);


            // Primer mirem si la resposta del server es SUCCESS. Si no ho es, mostrem error.
            if (!response.IsSuccessStatusCode)
            {
                // Si la resposta es NO SUCCESS, mostrem error
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                MessageBox.Show("Error al fer logout. Torna a intentar-ho", "Error", button, icon);
            }
            else
            {
                // Si la resposta es SUCCESS

                // Creem un objecte de tipus String per agafar les dades que retorna el server (String confirmant logout)               
                //String message = await reader.ReadToEndAsync();
                var resposta = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Logout correcte! " + resposta, "Info");

                //S'HA ARREGLAR: crea nou form1 i es queda obert - tindriem dos Form1 oberts
                Login_inici inici = new Login_inici();
                inici.ShowDialog();


                // Tanquem el Formulari
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e) //DELETE BUTTON
        {
            //Farem DELETE de la sessió amb el header (el head i el token)
            //En aquest cas el header, per ser un usuari, haurà de ser 'CBS'

            // Creem deleteUser assignant les dades que tenim en memoria a Appinformation (head i token)            
            string header = String.Concat(AppInformation.usuari.Head, AppInformation.usuari.Token);
            DeleteInfo deleteUser = new DeleteInfo(header);
            //fem logout
            doDelete(deleteUser);

        }

        async void doDelete(DeleteInfo deleteUser)
        {
            HttpClient httpClient = new HttpClient();
            string url = "http://localhost:8080/coffee/api/auth/delete";
            //MessageBox.Show(deleteUser.Authorization);
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(deleteUser.Authorization);
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

                //S'HA ARREGLAR: crea nou form1 i es queda obert - tindriem dos Form1 oberts
                Login_inici inici = new Login_inici();
                inici.ShowDialog();

                // Tanquem el Formulari
                this.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CanviContrasenya modPass = new CanviContrasenya();
            modPass.Show();
        }
    }
}
