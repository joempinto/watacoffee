using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPC_1.login;
using WPC_1.User_addGroup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WPC_1
{
    public partial class User_AfegirMembre : Form
    {
        public User_AfegirMembre()
        {
            InitializeComponent();
        }

        private void labelCancelAddMembre_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkUsername_CheckedChanged(object sender, EventArgs e)
        {
            usernameTxt.Visible = checkUsername.Checked;
            labelUsername.Visible = checkUsername.Checked;
        }

        private void confirmaAddMembreBtn_Click(object sender, EventArgs e)
        {
            string id = idGrupTxt.Text;
            string nickname = nicknameMembreTxt.Text;


            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Warning;

            // Validació de email i password: No estan empty i que email es valid
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("El camp ID Grup no pot estar buit", "Error", button, icon);
            }
            else if (!validarInt(id))
            {
                MessageBox.Show("No s'ha introduit un numero positiu", "Error", button, icon);
            }
            else if (string.IsNullOrEmpty(nickname))
            {
                MessageBox.Show("El camp 'Nickname' no pot estar buit", "Error", button, icon);
            }
            else
            {
                if (checkUsername.Checked) //Suposem que es vol afegir un usuari registrat
                {
                    string username = usernameTxt.Text;

                    if (string.IsNullOrEmpty(username))
                    {
                        MessageBox.Show("El camp username no pot estar buit", "Error", button, icon);
                    }
                    else
                    {
                        int idNum = Int32.Parse(id);
                        MessageBox.Show("Trying to add un usuari ja registrat", "Info", button);

                        AddNewMembre newRegMember = new AddNewMembre(idNum, nickname, username);
                        string header = String.Concat(AppInformation.usuari.Head, AppInformation.usuari.Token);
                        UserAuthorization auth = new UserAuthorization(header);

                        doAddRegMembre(auth, newRegMember);
                    }

                }
                else
                {
                    int idNum = Int32.Parse(id);
                    string username = null;

                    // Creem user amb les dades introduides (idNum i nickname)
                    AddNewMembre newMember = new AddNewMembre(idNum, nickname, username);
                    string header = String.Concat(AppInformation.usuari.Head, AppInformation.usuari.Token);
                    UserAuthorization auth = new UserAuthorization(header);
                    //fem login
                    doAddRegMembre(auth, newMember);
                }


                async void doAddRegMembre(UserAuthorization aut, AddNewMembre nouRegMembre)
                {
                    HttpClient httpClient = new HttpClient();
                    string url = "http://localhost:8080/coffee/api/groups/add/member";
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(aut.Authorization);
                    using HttpResponseMessage response = await httpClient.PostAsJsonAsync<AddNewMembre>(url, nouRegMembre);

                    // Primer mirem si la resposta del server: Si NO és SUCCESS mostrem error.
                    if (!response.IsSuccessStatusCode)
                    {
                        // Si la resposta es NO SUCCESS, mostrem error
                        MessageBoxButtons button = MessageBoxButtons.OK;
                        MessageBoxIcon icon = MessageBoxIcon.Warning;
                        MessageBox.Show("Registre no realitzat. Torna-ho a intentar\n" + response.ToString(), "Error", button, icon);
                    }
                    else
                    {
                        // Si la resposta es SUCCESS
                        var resposta = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Afegit membre correctament! " + resposta, "Info");

                        // Tanquem el Formulari
                        this.Hide();
                    }
                }
            }
        }



        private Boolean validarInt(string textToValidate)
        {
            try
            {
                int num = Int32.Parse(textToValidate);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }


}
