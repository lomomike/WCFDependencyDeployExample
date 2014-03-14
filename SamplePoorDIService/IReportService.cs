using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SamplePoorDIService
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
