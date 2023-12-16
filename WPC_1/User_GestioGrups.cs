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
using WPC_1.User_addGroup;
using WPC_1.logout;

namespace WPC_1
{
    public partial class User_GestioGrups : Form
    {
        public User_GestioGrups()
        {
            InitializeComponent();
        }

        private void User_GestioGrups_Load(object sender, EventArgs e)
        {
            string location = String.Concat("[USER] ", AppInformation.usuari.Email,
                        " > Menu Usuari >");
            pageLocation.Text = location;
        }

        private void iniciStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            usuari_Menu user_Menu = new usuari_Menu();
            user_Menu.Show();
        }

        private void llistaGrupsTypeBtn_Click(object sender, EventArgs e)
        {
            llistatBox.Visible = true;
        }

        public void imprimirLlistatBtn_Click(object sender, EventArgs e)
        {
            listGrupsTipus.Items.Clear();

            if (rbAdmin.Checked)
            {
                string type = "admin";
                doLlistatTipus(type);

            }
            else if (rbMembre.Checked)
            {
                string type = "member";
                doLlistatTipus(type);
            }
            else if (rbTots.Checked)
            {
                string type = "all";
                doLlistatTipus(type);
            }
            else
            {
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                MessageBox.Show("Usuari desconegut o no trobat.", "Error", button, icon);
            }
        }
        public async void doLlistatTipus(string tipus)
        {
            string header = String.Concat(AppInformation.usuari.Head, AppInformation.usuari.Token);
            UserAuthorization auth = new UserAuthorization(header);

            HttpClient httpClient = new HttpClient();
            string url = String.Concat("http://localhost:8080/coffee/api/groups/get/groups?type=", tipus);
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
                var llistaTipusHttpResponse = await response.Content.ReadFromJsonAsync<List<GroupLlistaTipus>>();

                // A AppInformation es guarda la informacio necessaria en memoria de la resposta del server.                
                if (llistaTipusHttpResponse is not null)
                {
                    //Una llista gLlistaTipus li assignem valors de la response
                    AppInformation.gLlistaTipus = llistaTipusHttpResponse;

                    totalGrupsLlista.Text = AppInformation.gLlistaTipus.Count().ToString();

                    //imprimim els users un a un
                    for (int i = 0; i < llistaTipusHttpResponse.Count; i++)
                    {
                        ListViewItem item = new ListViewItem(llistaTipusHttpResponse[i].id.ToString());
                        // Place a check mark next to the item.
                        item.SubItems.Add(llistaTipusHttpResponse[i].name);
                        //Add the items to the ListView.
                        listGrupsTipus.Items.Add(item);

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

        private void listIndex_Click(object sender, EventArgs e)
        {
            var selectedItems = listGrupsTipus.SelectedItems[0];
            idGrupShow.Text = AppInformation.gLlistaTipus[selectedItems.Index].id.ToString();
            showMembresGrupBtn.Enabled = true;
            deleteGrupBtn.Enabled = true;
            pictureBoxShowMembresGrup.Enabled = true;
            pictureBoxDeleteGrup.Enabled = true;

        }

        private void selectedIndexChanged(object sender, EventArgs e)
        {
            if (listGrupsTipus.SelectedItems.Count == 0)
            {
                idGrupShow.Text = null;
                showMembresGrupBtn.Enabled = false;
                deleteGrupBtn.Enabled = false;
                pictureBoxShowMembresGrup.Enabled = false;
                pictureBoxDeleteGrup.Enabled = false;
            }
        }

        private void logoutStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();

            usuari_Menu uMenu = new usuari_Menu();
            uMenu.button1_Click(sender, e); //dologout
        }

        private void showMembresGrupBtn_Click(object sender, EventArgs e)
        {
            //Aqui haurem de fer el validateINT
            int idGrup = Int32.Parse(idGrupShow.Text);


            User_ShowMembresGrup showMembres = new User_ShowMembresGrup(idGrup);
            showMembres.Show();
            showMembres.updateTableMembers_Click(sender, e, idGrup);

        }

        private void deleteGrupBtn_Click(object sender, EventArgs e)
        {
            var selectedItems = listGrupsTipus.SelectedItems[0];
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Està segur que vol eliminar el grup amb " +
                "\nidGroup " + AppInformation.gLlistaTipus[selectedItems.Index].id +

                "\nNom " + AppInformation.gLlistaTipus[selectedItems.Index].name +

                " ?", "Atenció!", button, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                int idGroup = AppInformation.gLlistaTipus[selectedItems.Index].id;
                string header = String.Concat(AppInformation.usuari.Head, AppInformation.usuari.Token);
                UserAuthorization auth = new UserAuthorization(header);

                doEliminaGrup(auth, idGroup);

                imprimirLlistatBtn_Click(sender, e);

                selectedIndexChanged(sender, e);
            }
            else
            {
                listGrupsTipus.Items.Clear();
                totalGrupsLlista.Text = null;
                selectedIndexChanged(sender, e);
            }

        }

        private async void doEliminaGrup(UserAuthorization aut, int groupID)
        {
            HttpClient httpClient = new HttpClient();
            string url = String.Concat("http://localhost:8080/coffee/api/groups/delete/group/", groupID);
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
                listGrupsTipus.Items.Clear();
                totalGrupsLlista.Text = null;


            }
        }

        private void creaGrupBtn_Click_1(object sender, EventArgs e)
        {
            User_addGrup addGroupMenu = new User_addGrup();
            addGroupMenu.Show();
        }
    }

    /*private Boolean validarInt(string textToValidate)
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
    }*/
}


