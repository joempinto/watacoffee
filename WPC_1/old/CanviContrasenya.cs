/*
 * created by JMPinto
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPC_1.login;
using WPC_1.register;
using WPC_1.delete;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using WPC_1.old.logout;
using WPC_1.old.common;

namespace WPC_1
{
    public partial class CanviContrasenya : Form
    {
        public CanviContrasenya()
        {
            InitializeComponent();
        }

        private void buttonConfirmaRegister_Click(object sender, EventArgs e)
        {
            // Agafem el text que l'usuari ha introduït als camps de text

            string newPwd1 = newPassword1.Text;
            string newPwd2 = newPassword2.Text;

            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Warning;

            if (string.IsNullOrEmpty(newPwd1))
            {
                MessageBox.Show("La nova contrasenya no pot estar buida", "Error", button, icon);
            }
            else if (!string.Equals(newPwd1, newPwd2))
            {
                MessageBox.Show("Les contrasenyes introduïdes no són iguals", "Error", button, icon);
            }
            else
            {
                string header = String.Concat(AppInformation.usuari.Head, AppInformation.usuari.Token);
                LogoutInfo logoutUser = new LogoutInfo(header);

                //fem canvi de contrasenya                
                doCanviPassword(logoutUser, newPwd1);
            }

            async void doCanviPassword(LogoutInfo logoutUser, string password)
            {
                HttpClient httpClient = new HttpClient();
                string url = "http://localhost:8080/coffee/api/auth/modPassword";

                // using HttpResponseMessage response = await httpClient.PutAsJsonAsync<ChangePwd>(url, newPassword);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(logoutUser.Authorization);
                using HttpResponseMessage response = await httpClient.PutAsJsonAsync<String>(url, password);


                // Primer mirem si la resposta del server es SUCCESS. Si no ho es, mostrem error.
                if (!response.IsSuccessStatusCode)
                {
                    // Si la resposta es NO SUCCESS, mostrem error
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Warning;
                    MessageBox.Show("Canvi de contrasenya no realitzat. Torna-ho a intentar " + response, "Error", button, icon);

                }
                else
                {
                    // Si la resposta es SUCCESS

                    var resposta = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Canvi correcte! " + resposta, "Info");
                    this.Close();

                }
            }

        }

        private void labelCancelCanviPwd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
