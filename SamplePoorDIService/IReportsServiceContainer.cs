namespace SamplePoorDIService
{
    public  interface IReportsServiceContainer {
        IReportService ResolveReportService();
        void Release(IReportService reportService);
    }

    class ReportsServiceContainer : IReportsServiceContainer
    {
        public IReportService ResolveReportService()
        {
            return new ReportService(
                new ReportRepository(), 
                new ReportPreparationQueue()
                );
        }

        public void Release(IReportService reportService)
        {
        }
    }
}