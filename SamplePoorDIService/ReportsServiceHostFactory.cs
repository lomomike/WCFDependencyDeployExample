using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.ServiceModel.Activation;

namespace SamplePoorDIService
{
    

    public class ReportsServiceHostFactory : ServiceHostFactory
    {
        private readonly ReportsServiceContainer _container;

        public ReportsServiceHostFactory()
        {
            _container = new ReportsServiceContainer();
        }

        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            if (serviceType == typeof (ReportService))
            {
                return new ReportsServiceHost(_container, serviceType, baseAddresses);
            }
            return base.CreateServiceHost(serviceType, baseAddresses);
        }

       
    }
}