using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntityFrameworkCryptoCalculator;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace CryptoCalculator.Models.Integrations
{
    public class NiceHash : ApiIntegration{

        public NiceHash(UserApiConnection connection) : base(connection)
        {
            
        }

        public async override void GetTransactions()
        {
            Uri uri = new Uri("method=orders.get&my&id=" + this.Connection.API_KEY + "&key=" + this.Connection.API_SECRET + "&location=0&algo=0");
            HttpResponseMessage response = await this.Client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                String body = response.Content.ToString();
                JObject json = JObject.Parse(body);
            }
        }
    }
}