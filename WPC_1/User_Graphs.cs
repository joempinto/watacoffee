using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPC_1.responses;
using WPC_1.User_addGroup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WPC_1
{
    public partial class User_Graphs : Form
    {
        public User_Graphs()
        {
            InitializeComponent();
            doLlistatTipus();
        }

        public void User_Graphs_Load(object sender, EventArgs e)
        {
            string location = String.Concat("[USER] ", AppInformation.usuari.Email,
                        " > Menu Usuari > PagamentsiEstadistiques > Estadístiques");
            pageLocation.Text = location;

        }

        //CARREGUEM DADES A LA TAULA DE GRUPS (tots els grups on participa l'usuari)
        public async void doLlistatTipus()
        {

            string header = String.Concat(AppInformation.usuari.Head, AppInformation.usuari.Token);
            UserAuthorization auth = new UserAuthorization(header);

            HttpClient httpClient = new HttpClient();
            string url = String.Concat("https://coffee-mug-0606.ew.r.appspot.com/coffee/api/groups/get/groups?type=", "all");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(auth.Authorization);
            using HttpResponseMessage response = await httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Error al carregar les dades del server");
            }
            else
            {
                // Si la resposta es SUCCESS                        
                var llistaTipusHttpResponse = await response.Content.ReadFromJsonAsync<List<GroupLlistaTipus>>();

                // A AppInformation es guarda la informacio necessaria en memoria de la resposta del server.                
                if (llistaTipusHttpResponse is not null)
                {
                    //Una llista gLlistaTipus li assignem valors de la response
                    AppInformation.gLlistaTipus = llistaTipusHttpResponse;

                    //imprimim els users un a un
                    for (int i = 0; i < llistaTipusHttpResponse.Count; i++)
                    {
                        ListViewItem item = new ListViewItem(llistaTipusHttpResponse[i].name.ToString());

                        //Add the items to the ListView.
                        listGrupsTipus.Items.Add(item);
                    }
                }
                else
                {
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Warning;
                    MessageBox.Show("Torna-ho a intentar", "Error", button, icon);
                }
            }
        }

        private void listGrupsTipus_SelectedIndexChanged(object sender, EventArgs e)
        {

            var selectedGrup = listGrupsTipus.SelectedItems[0];
            int groupId = AppInformation.gLlistaTipus[selectedGrup.Index].id;
            numGrupTxt.Text = groupId.ToString();

            listMembres.Items.Clear();
            //carreguem les dates dels membres del grup al listMembres
            doLlistaMembres(groupId);

        }

        //CARREGUEM DADES A LA TAULA DE MEMBRES 
        private async void doLlistaMembres(int idGrup)
        {
            string header = String.Concat(AppInformation.usuari.Head, AppInformation.usuari.Token);
            UserAuthorization auth = new UserAuthorization(header);

            HttpClient httpClient = new HttpClient();
            string url = String.Concat("https://coffee-mug-0606.ew.r.appspot.com/coffee/api/groups/get/members/group/", idGrup);
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

                    //imprimim els users un a un

                    for (int i = 0; i < llistaMembresHttpResponse.Count; i++)
                    {
                        ListViewItem item = new ListViewItem(llistaMembresHttpResponse[i].nickname.ToString());

                        // item.SubItems.Add(llistaMembresHttpResponse[i].memberId.ToString());
                        item.SubItems.Add(llistaMembresHttpResponse[i].nickname);
                        // item.SubItems.Add(llistaMembresHttpResponse[i].username);
                        item.SubItems.Add(llistaMembresHttpResponse[i].isAdmin.ToString());

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

        private void listMembres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listMembres.SelectedItems.Count > 0)
            {
                var selectedMembre = listMembres.SelectedItems[0];
                numMembreTxt.Text = AppInformation.membresLlista[selectedMembre.Index].memberId.ToString();
            }
            else
            {
                return;
            }
        }

        private void checkBoxFiltreDates_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxFiltreDates.Checked)
            {
                groupBoxFiltreDates.Enabled = false;
            }
            else
            {
                groupBoxFiltreDates.Enabled = true;
                string dataI = formatDate(dataInici);
                string dataF = formatDate(dataFinal);
            }
        }

        private string formatDate(DateTimePicker date)
        {
            string day = date.Value.Day.ToString();
            if (day.Count() < 2)
                day = string.Concat("0", day);
            string month = date.Value.Month.ToString();
            string year = date.Value.Year.ToString();

            string formatedDate = string.Concat(year, "-", month, "-", day);

            return formatedDate;
        }

        private void comboBoxSelDades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSelDades.SelectedIndex == 3)
            {
                labelNickname.Visible = true;
                nicknameTxt.Visible = true;
            }
            else
            {
                labelNickname.Visible = false;
                nicknameTxt.Visible = false;
            }
        }

        private void buttonOKMostraDades_Click(object sender, EventArgs e)
        {
            // listDadesResult.Clear();
            // listViewReq1.Clear ();
            // listViewReq3.Clear ();

            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Warning;

            if (numGrupTxt.Text.Count() <= 0)
            {
                MessageBox.Show("El camp de grup no poden estar buits", "Error", button, icon);
            }
            else if (string.IsNullOrEmpty(numMembreTxt.Text))
            {
                MessageBox.Show("El camp membre no poden estar buits", "Error", button, icon);
            }
            else if (comboBoxSelDades.SelectedIndex == -1)
            {
                MessageBox.Show("El camp 'Dades a mostrar?' no pot estar buit", "Error", button, icon);
            }
            else
            {
                string header = String.Concat(AppInformation.usuari.Head, AppInformation.usuari.Token);
                UserAuthorization auth = new UserAuthorization(header);

                if (comboBoxSelDades.SelectedIndex == 0)
                {
                    //dades per usuari
                    labelNickname.Visible = false;
                    nicknameTxt.Visible = false;
                    string url1 = string.Concat("https://coffee-mug-0606.ew.r.appspot.com/coffee/api/payments/get/by/member?memberId=", Int32.Parse(numMembreTxt.Text), "&groupId=", Int32.Parse(numGrupTxt.Text));

                    if (checkBoxFiltreDates.Checked)
                    {
                        url1 = string.Concat(url1, "&initDate=", formatDate(dataInici), "&endDate=", formatDate(dataFinal));
                    }

                    doLlistatPerUsuari(auth, url1);

                }
                else if (comboBoxSelDades.SelectedIndex == 1)
                {
                    //dades del grup
                    labelNickname.Visible = false;
                    nicknameTxt.Visible = false;
                    string url1 = string.Concat("https://coffee-mug-0606.ew.r.appspot.com/coffee/api/payments/get/by/group?groupId=", Int32.Parse(numGrupTxt.Text));

                    if (checkBoxFiltreDates.Checked)
                    {
                        url1 = string.Concat(url1, "&initDate=", formatDate(dataInici), "&endDate=", formatDate(dataFinal));
                    }


                    doLlistatPerGrup(auth, url1);
                }
                else if (comboBoxSelDades.SelectedIndex == 2)
                {
                    //dades dels totals
                    labelNickname.Visible = false;
                    nicknameTxt.Visible = false;
                    string url1 = string.Concat("https://coffee-mug-0606.ew.r.appspot.com/coffee/api/payments/get/totals/by/group?groupId=", Int32.Parse(numGrupTxt.Text));

                    if (checkBoxFiltreDates.Checked)
                    {
                        url1 = string.Concat(url1, "&initDate=", formatDate(dataInici), "&endDate=", formatDate(dataFinal));
                    }

                    doLlistatTotalsAcumulats(auth, url1);
                }
                else if (comboBoxSelDades.SelectedIndex == 3)
                {
                    //dades per nickname

                    string nick = nicknameTxt.Text;

                    string url1 = string.Concat("https://coffee-mug-0606.ew.r.appspot.com/coffee/api/payments/get/totals/by/member?groupId=", Int32.Parse(numGrupTxt.Text), "&memberNickname=", nick);

                    if (checkBoxFiltreDates.Checked)
                    {
                        url1 = string.Concat(url1, "&initDate=", formatDate(dataInici), "&endDate=", formatDate(dataFinal));
                    }

                    doLlistatTotalsAcumulats(auth, url1);
                }
            }
        }

        //LLISTEM ELS PAGAMENTS D'UN USUARI
        private async void doLlistatPerUsuari(UserAuthorization auth, string url)
        {
            int groupID = Int32.Parse(numGrupTxt.Text);
            int memberID = Int32.Parse(numMembreTxt.Text);

            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(auth.Authorization);
            using HttpResponseMessage response = await httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                // Si la resposta es NO SUCCESS, mostrem error 
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                MessageBox.Show("Error al fer petició PER USUARI. Torna a intentar-ho\n" + response, "Error", button, icon);
            }
            else
            {
                // Si la resposta es SUCCESS
                // Creem un objecte resposta per agafar les dades que retorna el server

                var llistaTipusHttpResponse = await response.Content.ReadFromJsonAsync<UsuariPagamentsResponse<PagamentInfoResponse>>();

                // A AppInformation es guarda la informacio necessaria en memoria de la resposta del server.                
                if (llistaTipusHttpResponse is not null)
                {
                    //Una llista amb els objectes declarats (llistat amb nickname i els seus pagaments
                    ResponseData.listUserPayments = llistaTipusHttpResponse;
                    listViewReq1.BringToFront();

                    //ListViewItem item = new ListViewItem(llistaTipusHttpResponse.nickname);
                    //imprimim els users un a un
                    for (int i = 0; i < llistaTipusHttpResponse.paymentData.Count; i++)
                    {
                        ListViewItem item = new ListViewItem(llistaTipusHttpResponse.nickname);
                        // Place a check mark next to the item.
                        item.SubItems.Add(llistaTipusHttpResponse.paymentData[i].amount.ToString());
                        item.SubItems.Add(llistaTipusHttpResponse.paymentData[i].paymentDate.ToString());


                        //Add the items to the ListView.
                        listViewReq1.Items.Add(item);

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

        //LLISTEM ELS PAGAMENTS FETS AL GRUP
        private async void doLlistatPerGrup(UserAuthorization auth, string url)
        {
            int groupID = Int32.Parse(numGrupTxt.Text);
            int memberID = Int32.Parse(numMembreTxt.Text);

            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(auth.Authorization);
            using HttpResponseMessage response = await httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                // Si la resposta es NO SUCCESS, mostrem error 
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                MessageBox.Show("Error al fer petició PER USUARI. Torna a intentar-ho\n" + response, "Error", button, icon);
            }
            else
            {
                // Si la resposta es SUCCESS
                // Creem un objecte resposta per agafar les dades que retorna el server                
                var llistaTipusHttpResponse = await response.Content.ReadFromJsonAsync<List<GrupPagamentInfoResponse>>();

                // A AppInformation es guarda la informacio necessaria en memoria de la resposta del server.                
                if (llistaTipusHttpResponse is not null)
                {
                    //Una llista amb els objectes declarats (llistat amb nickname i els seus pagaments
                    ResponseData.listGrupPayInfo = llistaTipusHttpResponse;
                    listDadesResult.BringToFront();

                    //imprimim els users un a un
                    for (int i = 0; i < llistaTipusHttpResponse.Count; i++)
                    {
                        ListViewItem item = new ListViewItem(llistaTipusHttpResponse[i].nickname);
                        // Place a check mark next to the item.
                        item.SubItems.Add(llistaTipusHttpResponse[i].amount.ToString());
                        item.SubItems.Add(llistaTipusHttpResponse[i].date);
                        item.SubItems.Add(llistaTipusHttpResponse[i].member.ToString());

                        //Add the items to the ListView.
                        listDadesResult.Items.Add(item);
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
        //LLISTEM ELS TOTALS ACUMULATS
        private async void doLlistatTotalsAcumulats(UserAuthorization auth, string url)
        {
            int groupID = Int32.Parse(numGrupTxt.Text);
            int memberID = Int32.Parse(numMembreTxt.Text);

            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(auth.Authorization);
            using HttpResponseMessage response = await httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                // Si la resposta es NO SUCCESS, mostrem error 
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                MessageBox.Show("Error al fer petició PER USUARI. Torna a intentar-ho\n" + response, "Error", button, icon);
            }
            else
            {
                // Si la resposta es SUCCESS
                // Creem un objecte resposta per agafar les dades que retorna el server                
                var llistaTipusHttpResponse = await response.Content.ReadFromJsonAsync<List<GrupMembreTotalPagamentResponse>>();

                // A AppInformation es guarda la informacio necessaria en memoria de la resposta del server.                
                if (llistaTipusHttpResponse is not null)
                {
                    //Una llista amb els objectes declarats (llistat amb nickname i els seus pagaments
                    ResponseData.listGrupTotals = llistaTipusHttpResponse;
                    listViewReq3.BringToFront();

                    //imprimim els users un a un
                    for (int i = 0; i < llistaTipusHttpResponse.Count; i++)
                    {
                        ListViewItem item = new ListViewItem(llistaTipusHttpResponse[i].nickname);
                        // Place a check mark next to the item.
                        item.SubItems.Add(llistaTipusHttpResponse[i].totalAmount.ToString());
                        item.SubItems.Add(llistaTipusHttpResponse[i].memberId.ToString());

                        //Add the items to the ListView.
                        listViewReq3.Items.Add(item);
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

        private void labelCancelEstadistiques_Click(object sender, EventArgs e)
        {
            User_SelectionPE selectionPE = new User_SelectionPE();
            selectionPE.Show();
            this.Close();
        }

        private void iniciStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            usuari_Menu user_Menu = new usuari_Menu();
            user_Menu.Show();
        }

        private void logoutStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            usuari_Menu uMenu = new usuari_Menu();
            uMenu.button1_Click(sender, e); //dologout
        }
    }
}
