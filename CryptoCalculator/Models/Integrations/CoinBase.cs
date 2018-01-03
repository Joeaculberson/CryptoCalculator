using EntityFrameworkCryptoCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CryptoCalculator.Models.Integrations
{
    public class CoinBase : ApiIntegration
    {
        public CoinBase(UserApiConnection connection) : base(connection)
        {

        }
    }
}