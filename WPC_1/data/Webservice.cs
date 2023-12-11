using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WPC_1.old.register;

namespace WPC_1.data
{
    public static class Webservice
    {
         static HttpClient httpClient = new HttpClient();

        //server
         const string ADDRESS = "http://localhost:8080";
        private const string API = "/coffee/api";

        //auth
       public static string REGISTER = "/auth/p/register";
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
        //groups
        private const string ADD_GROUP = "/groups/add/group";
        private const string GET_GROUPS = "/groups/get/groups";
        private const string ADD_MEMBER = "/groups/add/member";
        private const string GETMEMBERS_GRUP = "/groups/get/members/group/{id}";
        private const string UPDATE_NICKNAME = "/groups/update/nickname/group";
        private const string DELETE_MEMBER = "/groups/delete/member/from/group/{memberId}/{groupId}";
        private const string DELETE_GROUP = "/groups/delete/group/{groupId}";
        private const string ADD_MEMBRE_GROUP = "/groups/add/reguser/member/from/group";
        //payments
        private const string ADD_PAYMENT = "/payments/add";
        private const string GET_PAYMENTS_USER = "/payments/get/by/user?userId={userId}&groupId={groupId}&initDate={startDate}&endDate={endDate}";
        private const string GET_PAYMENTS_GRUP = "/payments/get/by/group?groupId={groupId}&initDate={startDate}&endDate={endDate}";
        private const string GET_ALL_PAYMENTS_GRUP = "/payments/get/totals/by/group?groupId={groupId}&initDate={startDate}&endDate={endDate}";

        async static public string executeRequest(string url, string data)
        {
            var content = new StringContent(data, Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await httpClient.PostAsync(url, content);
            if (!response.IsSuccessStatusCode)
            {
                return "";
            } 
            else
            {
                var registerHttpResponse = await response.Content.ReadFromJsonAsync<responses.UsuariHttpResponse>();
                return "";
            }

        }
    }
}
