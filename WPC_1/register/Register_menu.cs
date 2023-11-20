/*
 * created by JMPinto
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Mail;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPC_1.login;
using WPC_1.register;

namespace WPC_1

{
    public partial class register_Menu : Form
    {
        public register_Menu()
        {
            InitializeComponent();
        }
        private void buttonConfirmaRegister_Click(object sender, EventArgs e)
        {
            // Agafem el text que l'usuari ha introduït als camps de text
            string nom = registerNom.Text;
            string email = registerEmail.Text;
            string password1 = registerPassword1.Text;
            string password2 = registerPassword2.Text;

            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Warning;

            // Validació de email i password: No estan empty i que email es valid
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email no pot estar buit", "Error", button, icon);
            }            
            else if (!emailValidation(email)) //s'ha introduit un email malament
            {                
                MessageBox.Show("Email no valid", "Error", button, icon);
            }
            else if (string.IsNullOrEmpty(password1))
            {
                MessageBox.Show("La Contrasenya no pot estar buida", "Error", button, icon);
            }
            else if (!string.Equals(password1, password2))
            {
                MessageBox.Show("Les contrasenyes introduïdes no són iguals", "Error", button, icon);
            }
            else
            {
                MessageBox.Show("Dades correctes: procedim al Registre.", "Information", button, MessageBoxIcon.Information);

                // Creem user amb les dades introduides (nom, email i password)
                RegisterUser registerUser = new RegisterUser(nom, email, password1);

                //Fem register al server
                doRegister(registerUser);
            }

            async void doRegister(RegisterUser registerUser)
            {
                HttpClient httpClient = new HttpClient();
                string url = "http://localhost:8080/coffee/api/auth/p/register";
                using HttpResponseMessage response = await httpClient.PostAsJsonAsync<RegisterUser>(url, registerUser);

                // Primer mirem si la resposta del server: Si NO és SUCCESS mostrem error.
                if (!response.IsSuccessStatusCode)
                {
                    // Si la resposta es NO SUCCESS, mostrem error
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Warning;
                    //MessageBox.Show("Registre no realitzat. Torna-ho a intentar", "Error", button, icon);
                    MessageBox.Show("Registre no realitzat. Torna-ho a intentar\n" + response.ToString(), "Error", button, icon);
                }
                else
                {
                    // Si la resposta es SUCCESS

                    // Creem un objecte de tipus LoginHttpResponse per agafar les dades que retorna el server (Head, Token, Email i Nom)
                    var registerHttpResponse = await response.Content.ReadFromJsonAsync<RegisterHttpResponse>();


                    // A AppInformation es guarda la informacio necessaria en memoria de la resposta del server. 

                    if (registerHttpResponse is not null)
                    {
                        AppInformation.usuari = new User(registerHttpResponse.Head, registerHttpResponse.Token,
                            registerHttpResponse.Username, registerHttpResponse.Email);

                        // Segons el Prefix, obrim el formulari usuari_Menu o admin_Menu.                    
                        if (registerHttpResponse?.Head == "CBS")
                        {
                            this.Hide();
                            usuari_Menu usuariMenu = new usuari_Menu();
                            usuariMenu.Show();
                        }
                        else
                        {
                            this.Hide();
                            admin_Menu adminMenuForm = new admin_Menu();
                            adminMenuForm.Show();
                        }                        

                    }
                    else
                    {
                        MessageBox.Show("Torna a intentar el registre", "Token no rebut", button, icon);
                    }
                }
            }

        }
        private Boolean emailValidation(string emailToValidate)
        {
            try
            {
                MailAddress email = new MailAddress(emailToValidate);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void labelCancelAltaUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_inici frm1 = new Login_inici();
            frm1.ShowDialog();
        }
    }
}
