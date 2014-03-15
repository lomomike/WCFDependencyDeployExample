using Microsoft.Practices.Unity;
using ReportsDomain;
using Unity.Wcf;

namespace UnityDIService
{
	public class WcfServiceFactory : UnityServiceHostFactory
    {
        protected override void ConfigureContainer(IUnityContainer container)
        {
			// register all your components with the container here
            container
                .RegisterType<IReportRepository, ReportRepository>()
                .RegisterType<IReportPreparationQueue, ReportPreparationQueue>()
                .RegisterType<IReportService, ReportService>();
        }
    }    
}