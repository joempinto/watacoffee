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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using WPC_1.common;
using System.CodeDom;

namespace WPC_1
{
    public partial class User_PayMenu : Form
    {
        public User_PayMenu()
        {
            InitializeComponent();
        }

        private void User_PayMenu_Load(object sender, EventArgs e)
        {
            string location = String.Concat("[USER] ", AppInformation.usuari.Email,
                        " > Menu Usuari > Pagaments >");
            pageLocation.Text = location;
        }
        //LListem grups
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

            var selectedGrup = listGrupsTipus.SelectedItems[0];
            grupEscollit.Text = AppInformation.gLlistaTipus[selectedGrup.Index].name;

            //carreguem les dates dels membres del grup al listMembres

            int groupId = AppInformation.gLlistaTipus[selectedGrup.Index].id;
            numGrupTxt.Text = groupId.ToString();
            listMembres.Items.Clear();
            doLlistaMembres(groupId);
        }

        private async void doLlistaMembres(int idGrup)
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

                    //imprimim els users un a un

                    for (int i = 0; i < llistaMembresHttpResponse.Count; i++)
                    {
                        ListViewItem item = new ListViewItem(llistaMembresHttpResponse[i].memberId.ToString());

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
                membreEscollit.Text = AppInformation.membresLlista[selectedMembre.Index].nickname;
                numMembreTxt.Text = AppInformation.membresLlista[selectedMembre.Index].memberId.ToString();
            }
            else
            {
                return;
            }
        }

        private void buttonConfirmaPayment_Click(object sender, EventArgs e)
        {
            string q = quantitatTxt.Text;
            string dataP = formatDate(dataPagament);


            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Warning;

            // Validació de email i password: No estan empty i que la quantitat es valida
            if (string.IsNullOrEmpty(q) || string.IsNullOrEmpty(membreEscollit.Text) || string.IsNullOrEmpty(grupEscollit.Text))
            {
                MessageBox.Show("No hi poden haver camps buits", "Error", button, icon);
            }

            else if (q.Contains(',') || (!validarFloat(q)))
            {
                MessageBox.Show("Format de Quantitat no valid. \nExemple: 45.71", "Error", button, icon);
            }
            else
            {
                float quantitat = float.Parse(q);

                AddPayment payment = new AddPayment(quantitat, dataP, Int32.Parse(numGrupTxt.Text), Int32.Parse(numMembreTxt.Text));

                string header = String.Concat(AppInformation.usuari.Head, AppInformation.usuari.Token);
                UserAuthorization auth = new UserAuthorization(header);

                //fem canvi de contrasenya                
                doAddPayment(auth, payment);
            }

            async void doAddPayment(UserAuthorization aut, AddPayment pagament)
            {
                HttpClient httpClient = new HttpClient();
                string url = "http://localhost:8080/coffee/api/payments/add";

                // using HttpResponseMessage response = await httpClient.PutAsJsonAsync<ChangePwd>(url, newPassword);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(aut.Authorization);
                using HttpResponseMessage response = await httpClient.PutAsJsonAsync<AddPayment>(url, pagament);


                // Primer mirem si la resposta del server es SUCCESS. Si no ho es, mostrem error.
                if (!response.IsSuccessStatusCode)
                {
                    // Si la resposta es NO SUCCESS, mostrem error
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Warning;
                    MessageBox.Show("Procés no realitzat. Torna-ho a intentar " + response, "Error", button, icon);

                }
                else
                {
                    // Si la resposta es SUCCESS

                    var resposta = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Pagament afegit correctament!\n " + resposta, "Info");
                    User_LlistaMembresDeGrupPagaments llistatP = new User_LlistaMembresDeGrupPagaments(Int32.Parse(numGrupTxt.Text), grupEscollit.Text);
                    llistatP.ShowDialog();
                }
            }
        }

        private Boolean validarFloat(string textToValidate)
        {
            try
            {
                float num = float.Parse(textToValidate);
                return true;
            }
            catch (FormatException)
            {
                return false;
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

        private void labelCancelAddPagament_Click(object sender, EventArgs e)
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
   
