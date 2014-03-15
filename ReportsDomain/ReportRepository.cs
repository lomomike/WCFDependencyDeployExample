using System.Collections.Generic;

namespace ReportsDomain
{
    public interface IReportRepository
    {
        IReport Find(long id);
    }

    public class ReportRepository : IReportRepository
    {
        private static readonly List<long> ExistedReport = new List<long> { 1, 3, 4, 5, 6, 7, 12, 14 };

        public IReport Find(long id)
        {
            if (ExistedReport.Contains(id))
                return new Report(id);
            return null;
        }
    }

   
}