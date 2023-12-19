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
using WPC_1.logout;
using System.Net.Http.Json;
using System.Net.Http.Headers;

namespace WPC_1
{
    public partial class admin_Menu : Form
    {
        public admin_Menu()
        {
            InitializeComponent();
        }

        private void admin_Menu_Load(object sender, EventArgs e)
        {
            label4.Text = String.Concat("[ADMIN logged as: ", AppInformation.administrador.Username, " ]");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fem logout del ADMIN
            // Creem logoutuser assignant les dades que tenim en memoria a Appinformation (head i token)            
            string header = String.Concat(AppInformation.administrador.Head, AppInformation.administrador.Token);
            LogoutInfo logoutAdmin = new LogoutInfo(header);
            //fem logout
            doLogoutAdmin(logoutAdmin);


            async void doLogoutAdmin(LogoutInfo logoutAdmin)
            {
                HttpClient httpClient = new HttpClient();
                string url = "https://coffee-mug-0606.ew.r.appspot.com/coffee/api/admin/r/logout";
                //MessageBox.Show(logoutUser.Authorization);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(logoutAdmin.Authorization);
                using HttpResponseMessage response = await httpClient.PostAsJsonAsync<LogoutInfo>(url, logoutAdmin);


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

                    // Tanquem el Formulari
                    this.Hide();
                    Login_inici inici = new Login_inici();
                    inici.ShowDialog();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_GestioUsers gestioUsers = new Admin_GestioUsers();
            gestioUsers.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Tanquem el Formulari
            this.Hide();
            Admin_GestioUsers gestioUsers = new Admin_GestioUsers();
            gestioUsers.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_GestioGrups gestioGroups = new Admin_GestioGrups();
            gestioGroups.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_GestioGrups gestioGroups = new Admin_GestioGrups();
            gestioGroups.ShowDialog();
        }
    }
}
