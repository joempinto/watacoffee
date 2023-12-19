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
using WPC_1.logout;
using WPC_1.register;
using WPC_1.User_addGroup;

namespace WPC_1
{
    public partial class User_addGrup : Form
    {
        public User_addGrup()
        {
            InitializeComponent();            
        }
        private void labelCancelAddGrup_Click(object sender, EventArgs e)
        {            
            this.Hide();
        }

        private void confirmaAddGrupBtn_Click(object sender, EventArgs e)
        {
            // Agafem el text que l'usuari ha introduït als camps de text
            string memberName = memberAdminGrup.Text;
            string groupName = nomGrup.Text;

            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Warning;

            // Validació de memberName i groupName: No estan empty
            if (string.IsNullOrEmpty(memberName))
            {
                MessageBox.Show("El camp 'Admin de grup' no pot estar buit", "Error", button, icon);
            }
            else if (string.IsNullOrEmpty(groupName))
            {
                MessageBox.Show("El camp 'Nom de grup' no pot estar buida", "Error", button, icon);
            }
            else
            {
                MessageBox.Show("Dades correctes: procedim a afegir-ne el nou grup.", "Information", button, MessageBoxIcon.Information);

                // Creem nouGrup amb les dades introduides (memberName i groupName)
                string header = String.Concat(AppInformation.usuari.Head, AppInformation.usuari.Token);
                UserAuthorization auth = new UserAuthorization(header);
                AddGroup nouGrup = new AddGroup(memberName, groupName);

                //Fem register al server
                doAfegirGrup(auth, nouGrup);
            }

            async void doAfegirGrup(UserAuthorization aut, AddGroup nouGrup)
            {
                HttpClient httpClient = new HttpClient();
                string url = "https://coffee-mug-0606.ew.r.appspot.com/coffee/api/groups/add/group";
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(aut.Authorization);
                using HttpResponseMessage response = await httpClient.PostAsJsonAsync<AddGroup>(url, nouGrup);

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

                    // Creem un objecte de tipus AddGroupHttpResponse per agafar les dades que retorna el server (Head, Token, Email i Nom)
                    var addGroupHttpResponse = await response.Content.ReadFromJsonAsync<AddGroupHttpResponse>();
                    //MessageBox.Show(addGroupHttpResponse.ToString());


                    // A AppInformation es guarda la informacio necessaria en memoria de la resposta del server. 

                    if (addGroupHttpResponse is not null)
                    {
                        AppInformation.grup = new Group(addGroupHttpResponse.id.ToString(), addGroupHttpResponse.name);


                        this.Hide();
                       // User_GestioGrups usuariMenu = new User_GestioGrups();
                       // usuariMenu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Torna a intentar afegir un grup", "Error", button, icon);
                    }
                    this.Hide();
                }
            }
        }        
    }
}
