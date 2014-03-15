using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ReportsDomain;

namespace SamplePoorDIService
{
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
