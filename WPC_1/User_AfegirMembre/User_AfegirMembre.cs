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
        public User_AfegirMembre(int idNum)
        {
            InitializeComponent();
            idGrupTxt.Text = idNum.ToString();
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

        public void confirmaAddMembreBtn_Click(object sender, EventArgs e)
        {

            int idgroup = Int32.Parse(idGrupTxt.Text);


            string nickname = nicknameMembreTxt.Text;


            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Warning;

            // Validació de email i password: No estan empty i que email es valid
            if (string.IsNullOrEmpty(idGrupTxt.Text))
            {
                MessageBox.Show("El camp ID Grup no pot estar buit", "Error", button, icon);
            }
            else if (!validarInt(idGrupTxt.Text))
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
                        int idNum = Int32.Parse(idGrupTxt.Text);
                        MessageBox.Show("Trying to add un usuari ja registrat", "Info", button);

                        AddNewMembre newRegMember = new AddNewMembre(idNum, nickname, username);
                        string header = String.Concat(AppInformation.usuari.Head, AppInformation.usuari.Token);
                        UserAuthorization auth = new UserAuthorization(header);

                        doAddMembre(auth, newRegMember, idgroup);
                    }

                }
                else
                {
                    int idNum = Int32.Parse(idGrupTxt.Text);
                    string username = null;

                    // Creem user amb les dades introduides (idNum i nickname)
                    AddNewMembre newMember = new AddNewMembre(idNum, nickname, username);
                    string header = String.Concat(AppInformation.usuari.Head, AppInformation.usuari.Token);
                    UserAuthorization auth = new UserAuthorization(header);
                    //fem login
                    doAddMembre(auth, newMember, idgroup);

                }


                async void doAddMembre(UserAuthorization aut, AddNewMembre nouRegMembre, int idgroup)
                {
                    HttpClient httpClient = new HttpClient();
                    string url = "https://coffee-mug-0606.ew.r.appspot.com/coffee/api/groups/add/member";
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

                        User_ShowMembresGrup showListAgain = new User_ShowMembresGrup(idgroup);
                        showListAgain.Refresh();


                        MessageBox.Show("Afegit membre correctament! " + resposta, "Info", MessageBoxButtons.OK);

                        // Tanquem el Formulari
                        this.Hide();

                    }
                }
            }
        }

    }
}



