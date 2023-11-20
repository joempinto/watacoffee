using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using WPC_1.login;
using WPC_1.logout;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace WPC_1
{
    public partial class Admin_GestioGrups : Form
    {
        public Admin_GestioGrups()
        {
            InitializeComponent();
        }

        private void Admin_GestioGrups_Load(object sender, EventArgs e)
        {
            string location = String.Concat("[ADMIN logged as: ", AppInformation.administrador.Username,
                    "] > Gestió de la aplicació");
            pageLocation.Text = location;
        }

        private void iniciStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_Menu admin_Menu = new admin_Menu();
            admin_Menu.Show();
        }
        private void logoutStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_Menu admin_Menu2 = new admin_Menu();
            admin_Menu2.logoutToolStripMenuItem_Click(sender, e);
        }
        private void pictureBoxLllistaGrups_Click(object sender, EventArgs e)
        {
            llistaGrups_Click(sender, e);
        }

        private void llistaGrups_Click(object sender, EventArgs e)
        {
            string header = String.Concat(AppInformation.administrador.Head, AppInformation.administrador.Token);
            LogoutInfo admin = new LogoutInfo(header);
            //Hem creat header per preparar la petició al server i obtenir el llistat de users
            doLlistaGrupsAdmin(admin);
           // doCountGrups(admin);
        }

        async void doLlistaGrupsAdmin(LogoutInfo logoutAdmin)
        {
            HttpClient httpClient = new HttpClient();
            string url = "http://localhost:8080/coffee/api/admin/r/get/all/groups";
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(logoutAdmin.Authorization);
            using HttpResponseMessage response = await httpClient.GetAsync(url);

            // Primer mirem si la resposta del server es SUCCESS. Si no ho es, mostrem error.
            if (!response.IsSuccessStatusCode)
            {
                // Si la resposta es NO SUCCESS, mostrem error 
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                MessageBox.Show("Error al fer petició. Torna a intentar-ho\n" + response, "Error", button, icon);
            }
            else
            {
                // Si la resposta es SUCCESS
                // Creem un objecte de tipus LoginHttpResponse per agafar les dades que retorna el server (Email, Token, Name i Prefix)              
                var loginHttpResponse = await response.Content.ReadFromJsonAsync<List<GroupLlista>>();

                // A AppInformation es guarda la informacio necessaria en memoria de la resposta del server.                
                if (loginHttpResponse is not null)
                {

                    //Una llista uLlista li assignem valors de la response
                    AppInformation.gLlista = loginHttpResponse;
                    //MessageBox.Show("Test\n" + AppInformation.gLlista[0]);


                    listBoxUsers.Visible = true;
                    listBoxUsers.Items.Clear();
                    totalGrups.Text = AppInformation.gLlista.Count().ToString();
                    //imprimim els users un a un
                    for (int i = 0; i < loginHttpResponse.Count; i++)
                        listBoxUsers.Items.Add("Nom Grup: " + AppInformation.gLlista[i].groupName + "  " + "Participants: " + AppInformation.gLlista[i].numMembers);
                }
                else
                {
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Warning;
                    MessageBox.Show("Torna-ho a intentar", "Token no rebut", button, icon);
                }
            }

        }
        async void doCountGrups(LogoutInfo logoutAdmin)
        {
            HttpClient httpClient = new HttpClient();
            string url = "http://localhost:8080/coffee/api/r/count/groups";
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(logoutAdmin.Authorization);
            using HttpResponseMessage response = await httpClient.GetAsync(url);

            // Primer mirem si la resposta del server es SUCCESS. Si no ho es, mostrem error.
            if (!response.IsSuccessStatusCode)
            {
                // Si la resposta es NO SUCCESS, mostrem error 
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                MessageBox.Show("Error al fer petició. Torna a intentar-ho\n" + response, "Error", button, icon);
            }
            else
            {
                // Si la resposta es SUCCESS
                // Creem un objecte de tipus LoginHttpResponse per agafar les dades que retorna el server (INT)              
                var loginHttpResponse = await response.Content.ReadAsStringAsync();

                // A AppInformation es guarda la informacio necessaria en memoria de la resposta del server.                
                if (loginHttpResponse is not null)
                {
                    //Assignem al textbox indicat la resposta amb el numero total de users                  
                    totalGrups.Text = loginHttpResponse;
                }
                else
                {
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Warning;
                    MessageBox.Show("Torna-ho a intentar", "Token no rebut", button, icon);
                }
            }
        }
    }
}
