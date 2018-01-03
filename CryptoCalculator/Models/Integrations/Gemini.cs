using EntityFrameworkCryptoCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CryptoCalculator.Models.Integrations
{
    public class Gemini : ApiIntegration
    {
        public Gemini(UserApiConnection connection) : base(connection)
        {

        }
    }
}