using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPC_1.login;
using WPC_1.logout;

namespace WPC_1
{
    public partial class Admin_GestioUsers : Form
    {
        public Admin_GestioUsers()
        {
            InitializeComponent();
        }

        private void Admin_GestioUsers_load(object sender, EventArgs e)
        {
            string location = String.Concat(AppInformation.administrador.Username,
                " > Gestió de la aplicació");
            pageLocation.Text = location;
        }
        private void llistaUsers_Click(object sender, EventArgs e) //Llistem els users: name/email
        {
            //Ja hem iniciat la sessió amb el header (el head i el token)
            //En aquest cas el header, als ésser un admin, haurà de ser 'MTTL'

            string header = String.Concat(AppInformation.administrador.Head, AppInformation.administrador.Token);
            LogoutInfo admin = new LogoutInfo(header);
            //Hem creat header per preparar la petició al server i obtenir el llistat de users
            doLlistaUsersAdmin(admin);
        }

        async void doLlistaUsersAdmin(LogoutInfo logoutAdmin)
        {
            HttpClient httpClient = new HttpClient();
            string url = "http://localhost:8080/coffee/api/admin/r/logout";
            //MessageBox.Show(logoutUser.Authorization);
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(logoutAdmin.Authorization);
            using HttpResponseMessage response = await httpClient.PostAsJsonAsync(url, logoutAdmin);


            // Primer mirem si la resposta del server es SUCCESS. Si no ho es, mostrem error.
            if (!response.IsSuccessStatusCode)
            {
                // Si la resposta es NO SUCCESS, mostrem error 
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                MessageBox.Show("Error al fer petició. Torna a intentar-ho\n"+response, "Error", button, icon);
            }
            else
            {
                // Si la resposta es SUCCESS
                // Creem un objecte de tipus LoginHttpResponse per agafar les dades que retorna el server (Email, Token, Name i Prefix)
                MessageBox.Show("Entrem al ELSE\n" + response, "Error");
                var loginHttpResponse = await response.Content.ReadFromJsonAsync<List<UserLlista>>();

                // A AppInformation es guarda la informacio necessaria en memoria de la resposta del server.                
                if (loginHttpResponse is not null)
                {
                    MessageBox.Show("response: \n" + loginHttpResponse);
                    
                    //Una llista uLlista li assignem valors de la response
                    AppInformation.uLlista = loginHttpResponse;
                    MessageBox.Show("uLlista values: \n" + AppInformation.uLlista);
                }
                else
                {
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Warning;
                    MessageBox.Show("Torna a intentar el login", "Token no rebut", button, icon);
                }
            }

        }
    }
}
