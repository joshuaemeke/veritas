using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Veritas.Services
{
    public class VeritasServices
    {
        string apiUrl = ConfigurationManager.AppSettings["apiUrl"];

        public async Task<bool> Login(string email, string password)
        {
            var uri = apiUrl + "users/login";
            using (HttpClient httpClient = new HttpClient())
            {
                var formContent = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("email", email),
                    new KeyValuePair<string, string>("password", password)
                });
                var response = await httpClient.PostAsync(uri.ToString(), formContent);

                var h = 1 + 1;

            }

            return true;
        }
    }
}