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
using WPC_1.responses;
using WPC_1.User_addGroup;

namespace WPC_1
{
    public partial class User_deletePagament : Form
    {
        public User_deletePagament()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listGrupsTipus.Items.Clear();

            if (comboBox1.SelectedIndex == 0)
            {
                string type = "admin";
                doLlistatTipus(type);

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                string type = "member";
                doLlistatTipus(type);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                string type = "all";
                doLlistatTipus(type);
            }
        }
        async void doLlistatTipus(string tipus)
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

                    //imprimim els users un a un
                    for (int i = 0; i < llistaTipusHttpResponse.Count; i++)
                    {
                        ListViewItem item = new ListViewItem(llistaTipusHttpResponse[i].id.ToString());
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

        private void listGrupsTipus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listGrupsTipus.SelectedItems.Count > 0)
            {
                var selectedGrup = listGrupsTipus.SelectedItems[0];

                //carreguem les dates dels membres del grup al listMembres
                int groupId = AppInformation.gLlistaTipus[selectedGrup.Index].id;
                numGrupTxt.Text = groupId.ToString();
                listPagamentsGrup.Items.Clear();
                doLlistaPaymentsGrup(groupId);
            }
            else
            {
                return;
            }
        }

        public async void doLlistaPaymentsGrup(int groupId)
        {
            string header = String.Concat(AppInformation.usuari.Head, AppInformation.usuari.Token);
            UserAuthorization auth = new UserAuthorization(header);

            HttpClient httpClient = new HttpClient();
            string url = String.Concat("http://localhost:8080/coffee/api/payments/get/by/group?groupId=", groupId);
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
                var llistaPagamentsHttpResponse = await response.Content.ReadFromJsonAsync<List<GrupPagamentInfoResponse>>();

                // A AppInformation es guarda la informacio necessaria en memoria de la resposta del server.                
                if (llistaPagamentsHttpResponse is not null)
                {
                    //imprimim els users un a un
                    ResponseData.listGrupPayInfo = llistaPagamentsHttpResponse;

                    for (int i = 0; i < llistaPagamentsHttpResponse.Count; i++)
                    {
                        ListViewItem item = new ListViewItem(llistaPagamentsHttpResponse[i].member.ToString());
                        item.SubItems.Add(llistaPagamentsHttpResponse[i].nickname);
                        item.SubItems.Add(llistaPagamentsHttpResponse[i].amount.ToString());
                        item.SubItems.Add(llistaPagamentsHttpResponse[i].date);
                        //if (item.SubItems.Add(llistaPagamentsHttpResponse[i].teTicket.ToString())
                        // diskImage.Visible=True;

                        //Add the items to the ListView.
                        listPagamentsGrup.Items.Add(item);
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

        private void listPagamentsGrup_SelectedIndexChanged(object sender, EventArgs e)
        {
            eliminaPagamentBtn.Enabled = true;

            var selectedPayment = listPagamentsGrup.SelectedItems[0];
            numPagamentTxt.Text = ResponseData.listGrupPayInfo[selectedPayment.Index].paymentId.ToString();

        }

        private void eliminaPagamentBtn_Click(object sender, EventArgs e)
        {
            //var selectedGrup = listGrupsTipus.SelectedItems[0];
            var selectedPayment = listPagamentsGrup.SelectedItems[0];
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result = MessageBox.Show("Està segur que vol eliminar el pagament de " +
                "\nnickname: " + ResponseData.listGrupPayInfo[selectedPayment.Index].nickname +
                "\ni import de: " + ResponseData.listGrupPayInfo[selectedPayment.Index].amount.ToString() +
                " ?", "Atenció!", button, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int idGroup = Int32.Parse(numGrupTxt.Text);
                int idpayment = ResponseData.listGrupPayInfo[selectedPayment.Index].paymentId;
                string header = String.Concat(AppInformation.usuari.Head, AppInformation.usuari.Token);
                UserAuthorization auth = new UserAuthorization(header);

                doEliminaPayment(auth, idGroup, idpayment);

                eliminaPagamentBtn.Enabled = false;

            }
            else
            {
                listPagamentsGrup.Items.Clear();
                eliminaPagamentBtn.Enabled = false;
                doLlistaPaymentsGrup(Int32.Parse(numGrupTxt.Text));
            }

        }
        private async void doEliminaPayment(UserAuthorization aut, int groupID, int payID)
        {
            HttpClient httpClient = new HttpClient();
            string url = String.Concat("http://localhost:8080/coffee/api/payments/delete?groupId=", groupID, "&paymentId=", payID);
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

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            listPagamentsGrup.Items.Clear();
            doLlistaPaymentsGrup(Int32.Parse(numGrupTxt.Text));
        }

        private void labelCancelListMembres_Click(object sender, EventArgs e)
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

