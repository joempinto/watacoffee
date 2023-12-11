using Json.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WPC_1.data;
using WPC_1.old.register;

namespace WPC_1.repositories
{
    /*
    //auth
    private const string REGISTER = "/auth/p/register";
    private const string LOGIN = "/auth/p/login";
    private const string LOGOUT = "/auth/p/logout";
    private const string MODPASSWORD = "/auth/modPassword";
    private const string DELETE = "/auth/delete";
    //admin
    private const string ADMIN_LOGIN = "/admin/p/login";
    private const string ADMIN_LOGOUT = "admin/r/logout";
    private const string ADMIN_ALLUSERS = "/admin/r/get/all/users";
    private const string ADMIN_ALLGROUPS = "/admin/r/get/all/groups";
    private const string ADMIN_COUNTUSERS = "/admin/r/count/users";
    private const string ADMIN_COUNTGROUPS = "/admin/r/count/groups";
  
    //payments
    private const string ADD_PAYMENT = "/payments/add";
    private const string GET_PAYMENTS_USER = "/payments/get/by/user?userId={userId}&groupId={groupId}&initDate={startDate}&endDate={endDate}";
    private const string GET_PAYMENTS_GRUP = "/payments/get/by/group?groupId={groupId}&initDate={startDate}&endDate={endDate}";
    private const string GET_ALL_PAYMENTS_GRUP = "/payments/get/totals/by/group?groupId={groupId}&initDate={startDate}&endDate={endDate}";
    */

    public class UserRepository
    {
        //REGISTER = "/auth/p/register";
        async void doRegister(RegisterUser registerUser)
        {
            string registerUserJson = JsonSerializer.Serialize(registerUser);
            var request = Webservice.executeRequest(Webservice.REGISTER, registerUserJson);

                // Si la resposta es SUCCESS
                // Creem un objecte de tipus LoginHttpResponse per agafar les dades que retorna el server (Head, Token, Email i Nom)
                var registerHttpResponse = await response.Content.ReadFromJsonAsync<responses.UsuariHttpResponse>();


                // A AppInformation es guarda la informacio necessaria en memoria de la resposta del server. 

                if (registerHttpResponse is not null)
                {
                   new User(registerHttpResponse.Head, registerHttpResponse.Token,
                        registerHttpResponse.Name, registerHttpResponse.Email);

                    // Segons el Prefix, obrim el formulari usuari_Menu o admin_Menu.                    
                    if (registerHttpResponse?.Head == "CBS")
                    {
                        this.Hide();
                        usuari_Menu usuariMenu = new usuari_Menu();
                        usuariMenu.Show();
                    }
                    else
                    {
                        this.Hide();
                        admin_Menu adminMenuForm = new admin_Menu();
                        adminMenuForm.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Torna a intentar el registre", "Token no rebut", button, icon);
                }
            }
        }
    }
}
