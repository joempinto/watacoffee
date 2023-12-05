using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPC_1.User_addGroup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WPC_1
{
    public partial class User_ShowMembresGrup : Form
    {
        public User_ShowMembresGrup()
        {
            InitializeComponent();
        }

        public void User_ShowMembresGrup_Load(object sender, EventArgs e, int id)
        {
            listMembres.Items.Clear();

            doLlistaMembres(id);
        }

        async void doLlistaMembres(int idGrup)
        {
            string header = String.Concat(AppInformation.usuari.Head, AppInformation.usuari.Token);
            UserAuthorization auth = new UserAuthorization(header);

            HttpClient httpClient = new HttpClient();
            string url = String.Concat("http://localhost:8080/coffee/api/groups/get/members/group/", idGrup);
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(auth.Authorization);
            using HttpResponseMessage response = await httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                // Si la resposta es NO SUCCESS, mostrem error 
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                MessageBox.Show("Error al fer petició. Torna a intentar-ho\n" + response, "Error", button, icon);
            }
            else
            {
                // Si la resposta es SUCCESS
                // Creem un objecte de tipus LoginHttpResponse per agafar les dades que retorna el server (Email, Token, Name i Prefix)              
                var llistaMembresHttpResponse = await response.Content.ReadFromJsonAsync<List<MembresLlista>>();

                // A AppInformation es guarda la informacio necessaria en memoria de la resposta del server.                
                if (llistaMembresHttpResponse is not null)
                {
                    //Una llista gLlistaTipus li assignem valors de la response
                    AppInformation.membresLlista = llistaMembresHttpResponse;

                    totalParticipantsGroup.Text = AppInformation.membresLlista.Count().ToString();
                    //imprimim els users un a un


                    for (int i = 0; i < llistaMembresHttpResponse.Count; i++)
                    {
                        ListViewItem item = new ListViewItem(llistaMembresHttpResponse[i].groupId.ToString());
                        // Place a check mark next to the item.
                        item.SubItems.Add(llistaMembresHttpResponse[i].userId.ToString());
                        item.SubItems.Add(llistaMembresHttpResponse[i].nickname);
                        item.SubItems.Add(llistaMembresHttpResponse[i].username);
                        item.SubItems.Add(llistaMembresHttpResponse[i].admin.ToString());

                        //Add the items to the ListView.
                        listMembres.Items.Add(item);

                    }

                }
                else
                {
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Warning;
                    MessageBox.Show("Torna-ho a intentar", "Token no rebut", button, icon);
                }
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listIndex_Click(object sender, EventArgs e)
        {
            var selectedItems = listMembres.SelectedItems[0];
             
            addMemberGrupBtn.Enabled = true;
            updateMemberBtn.Enabled = true;
            eliminaMemberBtn.Enabled = true;

        }

        private void selectedIndexChanged(object sender, EventArgs e)
        {
            if (listMembres.SelectedItems.Count == 0)
            {

                addMemberGrupBtn.Enabled = false;
                updateMemberBtn.Enabled = false;
                eliminaMemberBtn.Enabled = false;
            }
        }

        private void addMemberGrupBtn_Click(object sender, EventArgs e)
        {
            var selectedItems = listMembres.SelectedItems[0];
            User_AfegirMembre addMembre = new User_AfegirMembre();
            addMembre.Show();
            
        }

        private void updateMemberBtn_Click(object sender, EventArgs e)
        {
            User_UpdateMember updateMembre = new User_UpdateMember();
            updateMembre.Show();
        }

        private void eliminaMemberBtn_Click(object sender, EventArgs e)
        {

            var selectedItems = listMembres.SelectedItems[0];
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result = MessageBox.Show("Està segur que vols eliminar l'usuari amb " +
                "\nnickname " + AppInformation.membresLlista[selectedItems.Index].nickname +

                "\nidGroup " + AppInformation.membresLlista[selectedItems.Index].groupId +
                "\nidUser " + AppInformation.membresLlista[selectedItems.Index].userId +

                " ?", "Atenció!", button, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                int idGroup = AppInformation.membresLlista[selectedItems.Index].groupId;
                int idUser = AppInformation.membresLlista[selectedItems.Index].userId;
                string header = String.Concat(AppInformation.usuari.Head, AppInformation.usuari.Token);
                UserAuthorization auth = new UserAuthorization(header);

                doEliminaParticipant(auth, idGroup, idUser);

                User_ShowMembresGrup_Load(sender, e, idGroup);
            }
            else
            {
                selectedIndexChanged(sender, e);
            }

        }

        private async void doEliminaParticipant(UserAuthorization aut, int groupID, int userID)
        {
            HttpClient httpClient = new HttpClient();
            string url = String.Concat("http://localhost:8080/coffee/api/groups/delete/member/from/group/", userID, "/", groupID);
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(aut.Authorization);
            using HttpResponseMessage response = await httpClient.DeleteAsync(url);


            // Primer mirem si la resposta del server es SUCCESS. Si no ho es, mostrem error.
            if (!response.IsSuccessStatusCode)
            {

                // Si la resposta es NO SUCCESS, mostrem error
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                MessageBox.Show("Error al fer DELETE. Torna a intentar-ho \n" + response, "Error", button, icon);
            }
            else
            {
                // Si la resposta es SUCCESS

                // Creem un objecte de tipus String per agafar les dades que retorna el server (String confirmant delete)                               
                var resposta = await response.Content.ReadAsStringAsync();
                MessageBox.Show("DELETE correcte! > " + resposta, "Info");


            }
        }
    }
}
