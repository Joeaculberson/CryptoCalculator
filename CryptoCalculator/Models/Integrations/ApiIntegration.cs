using EntityFrameworkCryptoCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCalculator.Models.Integrations
{
    public abstract class ApiIntegration
    {
        protected Integration Integration { get; set; }

        protected ApiIntegration(Integration integration)
        {
            this.Integration = integration;
        }
    }
}
