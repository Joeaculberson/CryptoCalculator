using EntityFrameworkCryptoCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CryptoCalculator.Models.Integrations
{
    public class Binance : ApiIntegration
    {
        public Binance(UserApiConnection connection) : base(connection)
        {

        }
    }
}