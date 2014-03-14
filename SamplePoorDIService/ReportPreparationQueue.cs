using System;
using System.Collections.Generic;

namespace SamplePoorDIService
{
    public interface IReportPreparationQueue
    {
        Guid EnqueuePrepare(IReport report, IList<ReportParameter> parameters);
        bool CheckReady(Guid reportId);
    }

    public class ReportPreparationQueue : IReportPreparationQueue
    {
        public Guid EnqueuePrepare(IReport report, IList<ReportParameter> parameters)
        {
            return Guid.NewGuid();
        }

        public bool CheckReady(Guid reportId)
        {
            return new Random().Next() % 5 == 0;
        }
    }
}