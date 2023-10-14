using System.Net.Http.Json;
using System.Net.Mail;
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WPC_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private async void buttonEntra_Click(object sender, EventArgs e)
        {
            // Validació que email i password no estan empty
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Warning;

            if (string.IsNullOrEmpty(email) )
            {
                MessageBox.Show("Email no pot estar buit", "Error", button, icon);
            } else if (!isEmailValid(email))
            {
                MessageBox.Show("Email no valid", "Error", button, icon);
            } else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Contrasenya no pot estar buida", "Error", button, icon);
            } else
            {
                LoginUser loginUser = new LoginUser(email, password);

                // Validar amb el server, si usuari existeix
                HttpResponseMessage response = await validateUserInServer(loginUser);
                
                if (!response.IsSuccessStatusCode) 
                {
                    MessageBox.Show("Usuari desconegut", "Error", button, icon);
                }
                else
                {
                    // Guardar Email, Prefix i Token de la HttpResponseMessage
                    // LoginHttpResponse loginHttpResponse = new LoginHttpResponse();
                    response.Content.ReadFromJsonAsync<LoginHttpResponse>();

                    this.Close();

                    // Segons el Prefix, obrir usuari_Menu o usuari_Admin
                    usuari_Menu frm3 = new usuari_Menu();
                    frm3.ShowDialog();
                }

            }
        }

        public async Task<HttpResponseMessage> validateUserInServer(LoginUser loginUser)
        {

            HttpClient httpClient = new HttpClient();
            string test = "http://localhost:8080/coffee/api/auth/p/login";
            using HttpResponseMessage response = await httpClient.PostAsJsonAsync<LoginUser>(
                String.Concat(test),
                loginUser
            );

            return response;

        }

        private Boolean isEmailValid(string emailToValidate)
        {
            try
            {
                MailAddress email = new MailAddress(emailToValidate);
                return true;
            } catch (FormatException)
            {
                return false;
            }
        }


        private void labelDonaAlta_Click(object sender, EventArgs e)
        {
            register_Menu frm2 = new register_Menu();
            frm2.ShowDialog();
        }

    }
}