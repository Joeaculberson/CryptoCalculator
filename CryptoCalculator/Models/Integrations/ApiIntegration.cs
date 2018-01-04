using EntityFrameworkCryptoCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace CryptoCalculator.Models.Integrations
{
    public abstract class ApiIntegration
    {
        protected UserApiConnection Connection { get; set; }
        protected HttpClient Client { get; set; }

        public ApiIntegration(UserApiConnection connection)
        {
            this.Connection = connection;
            this.Client = new HttpClient();
            this.Client.BaseAddress = new Uri("ENDPOINT HERE");
        }

        public virtual void GetTransactions()
        {

        }
    }
}
