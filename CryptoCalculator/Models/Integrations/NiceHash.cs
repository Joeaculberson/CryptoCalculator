using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntityFrameworkCryptoCalculator;

namespace CryptoCalculator.Models.Integrations
{
    public class NiceHash : ApiIntegration
    {
        public NiceHash(UserApiConnection connection) : base(connection)
        {
            
        }
    }
}