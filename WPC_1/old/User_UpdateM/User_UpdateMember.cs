using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPC_1.old.common;
using WPC_1.old.User_addGroup;
using WPC_1.old.User_AfegirMembre;

namespace WPC_1
{
    public partial class User_UpdateMember : Form
    {
        public User_UpdateMember(int grupSel, String nicknameSel)
        {
            InitializeComponent();
            idGrupTxt.Text = grupSel.ToString();
            nicknameMembreTxt.Text = nicknameSel.ToString();
        }

        private void labelCancelUpdateMembre_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmaUpdateMembreBtn_Click(object sender, EventArgs e)
        {
            string id = idGrupTxt.Text;
            string nickname = nicknameMembreTxt.Text;
            string username = usernameTxt.Text;


            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Warning;

            // Validació dels paràmetres que introdueix l'usuari
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
            else if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("El camp username no pot estar buit", "Error", button, icon);
            }
            else
            {
                int idNum = Int32.Parse(id);

                AddNewMembre updateMember = new AddNewMembre(idNum, nickname, username);
                string header = String.Concat(AppInformation.usuari.Head, AppInformation.usuari.Token);
                UserAuthorization auth = new UserAuthorization(header);

                doUpdateMembre(auth, updateMember);
            }

            async void doUpdateMembre(UserAuthorization aut, AddNewMembre nouRegMembre)
            {
                HttpClient httpClient = new HttpClient();
                string url = "http://localhost:8080/coffee/api/groups/add/reguser/member/from/group";
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(aut.Authorization);
                using HttpResponseMessage response = await httpClient.PutAsJsonAsync<AddNewMembre>(url, nouRegMembre);

                // Primer mirem si la resposta del server: Si NO és SUCCESS mostrem error.
                if (!response.IsSuccessStatusCode)
                {
                    // Si la resposta es NO SUCCESS, mostrem error
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Warning;
                    MessageBox.Show("Request no realitzat. Torna-ho a intentar\n" + response.ToString(), "Error", button, icon);
                }
                else
                {
                    // Si la resposta es SUCCESS
                    var resposta = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Afegit membre SI registrat correctament! " + resposta, "Info");

                    // Tanquem el Formulari
                    this.Hide();
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


