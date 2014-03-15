using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ReportsDomain;

namespace UnityDIService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ReportService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ReportService.svc or ReportService.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class ReportService : IReportService 
    {
        private readonly IReportRepository _repository;
        private readonly IReportPreparationQueue _queue;

        public ReportService(IReportRepository repository, IReportPreparationQueue queue)
        {
            _repository = repository;
            _queue = queue;
        }

        public Guid PostReportToQueue(long id, List<ReportParameter> parameters)
        {
            IReport report = _repository.Find(id);

            return _queue.EnqueuePrepare(report, parameters);
        }

        public bool CheckReportIsReady(Guid reportId)
        {
            return _queue.CheckReady(reportId);
        }
    }
}
