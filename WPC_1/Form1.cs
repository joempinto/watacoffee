using System.Net.Mail;

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
            }else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Contrasenya no pot estar buida", "Error", button, icon);
            }            

            // Validar amb el server, si usuari existeix

            // Si response del server es GOOD
            // usuari_Menu frm3 = new usuari_Menu();
            //frm3.ShowDialog();

            // Si response del server es ERROR
            // Mostrar un message dérror

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