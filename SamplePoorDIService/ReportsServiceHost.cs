using System;
using System.ServiceModel;

namespace SamplePoorDIService
{
    public class ReportsServiceHost : ServiceHost
    {
        public ReportsServiceHost(IReportsServiceContainer container, Type serviceType, params Uri[] baseAddresses)
            :base(serviceType, baseAddresses)
        {
            var contracts = this.ImplementedContracts.Values;
            foreach (var contract in contracts)
            {
                var provider = new ReportsInstanceProvider(container);
                contract.Behaviors.Add(provider);
            }
        }
    }
}