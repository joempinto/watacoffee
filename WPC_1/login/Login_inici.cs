/*
 * created by JMPinto
 */

using System.Drawing;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using WPC_1.login;
using WPC_1.register;
using WPC_1.delete;
using WPC_1.logout;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WPC_1
{
    public partial class Login_inici : Form
    {
        public Login_inici()
        {
            InitializeComponent();
        }

        private void buttonEntra_ClickAsync(object sender, EventArgs e)
        {
            // Agafem el text que lusuari ha introduit als camps de text
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Warning;                   

            // Validació de email i password: No estan empty i que email es valid
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email no pot estar buit", "Error", button, icon);
            }
            //Definir si té '@' és que el format de email NO és correcte
            //Si no té '@' s'entèn que s'ha introduït un USERNAME, és a dir, un login de ADMIN
            else if (email.Contains('@') && (!emailValidation(email)))
            {
                MessageBox.Show("Email no valid", "Error", button, icon);      
            }              
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Contrasenya no pot estar buida", "Error", button, icon);
            }            
            else
            {
                if (!email.Contains('@')) //Suposem que és el ADMIN qui intenta fer login
                {
                    MessageBox.Show("Admin trying to log in", "ADMIN", button, icon);
                    //string adminName = email;
                    LoginAdmin loginAdmin = new LoginAdmin(email,password);
                    doLoginAdmin(loginAdmin);
                }
                else
                {
                    // Creem user amb les dades introduides (email i password)
                    LoginUser loginUser = new LoginUser(email, password);

                    //fem login
                    doLogin(loginUser);
                }
            }
        }

        async void doLoginAdmin(LoginAdmin loginAdmin)
        {
            HttpClient httpClient = new HttpClient();
            string url = "http://localhost:8080/coffee/api/admin/p/login";
            using HttpResponseMessage responseAdmin = await httpClient.PostAsJsonAsync<LoginAdmin>(url, loginAdmin);

            // Primer mirem si la resposta del server es SUCCESS. Si no ho es, mostrem error.
            if (!responseAdmin.IsSuccessStatusCode)
            {
                // Si la resposta es NO SUCCESS, mostrem error
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                MessageBox.Show(responseAdmin.ToString(), "Error", button, icon);
                MessageBox.Show("ADMIN desconegut o no trobat.", "Error", button, icon);
            }
            else
            {
                // Si la resposta es SUCCESS
                // Creem un objecte de tipus LoginHttpResponse per agafar les dades que retorna el server (Email, Token, Name i Prefix)

                var loginHttpResponse = await responseAdmin.Content.ReadFromJsonAsync<LoginHttpResponseAdmin>();

                // A AppInformation es guarda la informacio necessaria en memoria de la resposta del server.                
                if (loginHttpResponse is not null)
                {
                    AppInformation.administrador = new Admin(loginHttpResponse.Head, 
                        loginHttpResponse.Token, loginHttpResponse.Username);
                    //MessageBox.Show(AppInformation.usuari.head + AppInformation.usuari.token +  AppInformation.usuari.nom + AppInformation.usuari.email);

                    // Segons el Prefix, obrim el formulari usuari_Menu o admin_Menu.                    
                    if (loginHttpResponse.Head == "CBS")
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
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Warning;
                    MessageBox.Show("Torna a intentar el login", "Token no rebut", button, icon);
                }
            }
        }

        async void doLogin(LoginUser loginUser)
        {
            HttpClient httpClient = new HttpClient();
            string url = "http://localhost:8080/coffee/api/auth/p/login";
            using HttpResponseMessage response = await httpClient.PostAsJsonAsync<LoginUser>(url, loginUser);           

            // Primer mirem si la resposta del server es SUCCESS. Si no ho es, mostrem error.
           if (!response.IsSuccessStatusCode)
            {
                // Si la resposta es NO SUCCESS, mostrem error
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                MessageBox.Show("Usuari desconegut o no trobat.", "Error", button, icon);
            }
            else
            {
                // Si la resposta es SUCCESS
                // Creem un objecte de tipus LoginHttpResponse per agafar les dades que retorna el server (Email, Token, Name i Prefix)
                
                var loginHttpResponse = await response.Content.ReadFromJsonAsync<LoginHttpResponse>();
                
                // A AppInformation es guarda la informacio necessaria en memoria de la resposta del server.                
                if (loginHttpResponse is not null)
                {
                    AppInformation.usuari = new User(loginHttpResponse.Head, loginHttpResponse.Token,
                        loginHttpResponse.Name, loginHttpResponse.Email);
                    //MessageBox.Show(AppInformation.usuari.head + AppInformation.usuari.token +  AppInformation.usuari.nom + AppInformation.usuari.email);

                    // Segons el Prefix, obrim el formulari usuari_Menu o admin_Menu.                    
                    if (loginHttpResponse.Head == "CBS")
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
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Warning;
                    MessageBox.Show("Torna a intentar el login", "Token no rebut", button, icon);
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
        private void labelDonaAlta_Click(object sender, EventArgs e)
        {
            //Tanquem el Form1
            this.Hide();
            //Obrim el Form2
            register_Menu frm2 = new register_Menu();
            frm2.ShowDialog();
            

        }
    }
}

 
