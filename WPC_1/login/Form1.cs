using System.Drawing;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using WPC_1.login;
using WPC_1.register;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WPC_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEntra_Click(object sender, EventArgs e)
        {
            // Agafem el text que lusuari ha introduit als camps de text
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Warning;

            // Validació de email i password: No estan empty i que email es valid
            if (string.IsNullOrEmpty(email) )
            {
                MessageBox.Show("Email no pot estar buit", "Error", button, icon);
            }
            else if (!isEmailValid(email))
            {
                MessageBox.Show("Email no valid", "Error", button, icon);
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Contrasenya no pot estar buida", "Error", button, icon);
            } 
            else
            {
                // Creem user amb les dades introduides (email i password)
                LoginUser loginUser = new LoginUser(email, password);

                // Fem login amb el server
                doLogin(loginUser);
            }
        }

        public async void doLogin(LoginUser loginUser)
        {
            HttpClient httpClient = new HttpClient();
            string url = "http://localhost:8080/coffee/api/auth/p/login";
            using HttpResponseMessage response = await httpClient.PostAsJsonAsync<LoginUser>(url, loginUser);
            //var loginHttpResponse = await response.Content.ReadFromJsonAsync<LoginHttpResponse>();

            // Primer mirem si la resposta del server es SUCCESS. Si no ho es, mostrem error.
            if (!response.IsSuccessStatusCode)
            {
                // Si la resposta es NO SUCCESS, mostrem error
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                MessageBox.Show("Usuari desconegut", "Error", button, icon);
            }
            else
            {
                // Si la resposta es SUCCESS

                // Creem un objecte de tipus LoginHttpResponse per agafar les dades que retorna el server (Email, Token i Prefix)
               
                var loginHttpResponse = await response.Content.ReadFromJsonAsync<LoginHttpResponse>();
                                    
                // A AppInformation es guarda la informacio necessaria en memoria de la resposta del server.                

                if (loginHttpResponse is not null)
                {
                    AppInformation.usuari = new User(loginHttpResponse.head, loginHttpResponse.token,
                        loginHttpResponse.name, loginHttpResponse.email);

                    // Segons el Prefix, obrim el formulari usuari_Menu o admin_Menu.                    
                    if (loginHttpResponse.head == "CBS")
                    {
                        usuari_Menu usuariMenu = new usuari_Menu();
                        usuariMenu.Show();
                    }
                    else
                    {
                        admin_Menu adminMenuForm = new admin_Menu();
                        adminMenuForm.Show();
                    }

                    // Tanquem el Formulari
                    this.Close();
                }
                else
                {
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Warning;
                    MessageBox.Show("Torna a intentar el registre", "Token no rebut", button, icon);
                }
            }
        }

        private Boolean isEmailValid(string emailToValidate)
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
            
            //Obrim el Form4
            register_Menu frm2 = new register_Menu();
            frm2.ShowDialog();
            // Tanquem el Form1
            //this.Close();

        }
    }
}