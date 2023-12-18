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
using WPC_1.responses;
using WPC_1.User_addGroup;

namespace WPC_1
{
    public partial class User_LlistaMembresDeGrupPagaments : Form
    {
        public User_LlistaMembresDeGrupPagaments(int GRUPID, string nomGrup)
        {
            InitializeComponent();
            numGrupTxt.Text = GRUPID.ToString();
            labelNomGrup.Text = nomGrup;
        }

        private void labelCancelCanviPwd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public async void User_LlistaMembresDeGrupPagaments_Load(object sender, EventArgs e)
        {
            string header = String.Concat(AppInformation.usuari.Head, AppInformation.usuari.Token);
            UserAuthorization auth = new UserAuthorization(header);

            HttpClient httpClient = new HttpClient();
            string url = String.Concat("http://localhost:8080/coffee/api/payments/get/by/group?groupId=", Int32.Parse(numGrupTxt.Text));
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

    }
}
