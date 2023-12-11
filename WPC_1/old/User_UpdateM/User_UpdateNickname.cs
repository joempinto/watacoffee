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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using WPC_1.old.common;
using WPC_1.old.User_addGroup;
using WPC_1.old.User_AfegirMembre;

namespace WPC_1
{
    public partial class User_UpdateNickname : Form
    {
        public User_UpdateNickname(int grupSel, String nicknameSel)
        {
            InitializeComponent();
            idGrupTxt.Text = grupSel.ToString();
            nicknameAnticTxt.Text = nicknameSel.ToString();
        }

        private void labelCancelUpdateMembre_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmaUpdateMembreBtn_Click(object sender, EventArgs e)
        {

            string id = idGrupTxt.Text;
            string nickname = nicknameAnticTxt.Text;
            string nouNickname = nouNicknameTxt.Text;

            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Warning;

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
                MessageBox.Show("El camp 'Nickname antic' no pot estar buit", "Error", button, icon);
            }
            else if (string.IsNullOrEmpty(nouNickname))
            {
                MessageBox.Show("El camp 'Nou Nickname' no pot estar buit", "Error", button, icon);
            }
            else
            {
                int idNum = Int32.Parse(id);

                ChangeNicknameMembre updateMember = new ChangeNicknameMembre(idNum, nickname, nouNickname);
                string header = String.Concat(AppInformation.usuari.Head, AppInformation.usuari.Token);
                UserAuthorization auth = new UserAuthorization(header);

                doUpdateMembre(auth, updateMember);
            }

            async void doUpdateMembre(UserAuthorization aut, ChangeNicknameMembre updated)
            {
                HttpClient httpClient = new HttpClient();
                string url = "http://localhost:8080/coffee/api/groups/update/nickname/group";
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(aut.Authorization);
                using HttpResponseMessage response = await httpClient.PutAsJsonAsync<ChangeNicknameMembre>(url, updated);

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
   
