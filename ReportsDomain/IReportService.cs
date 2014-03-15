using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace ReportsDomain
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IReportService" in both code and config file together.
    [ServiceContract]
    public interface IReportService
    {

        [OperationContract]
        Guid PostReportToQueue(long id, List<ReportParameter> parameters);

        [OperationContract]
        bool CheckReportIsReady(Guid reportId);

    }


    
}
