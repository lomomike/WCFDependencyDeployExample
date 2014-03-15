using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestClient.PoorDIServiceReference;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Poor DI Service\n");
            using (var client = new ReportServiceClient())
            {
                Guid id = client.PostReportToQueue(1, new [] {new ReportParameter() });
                Console.WriteLine("Report id {0}", id);

                Console.WriteLine("Is report ready: {0}", client.CheckReportIsReady(id));
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Unity DI Service\n");
            using (var client = new UnityDIServiceReference.ReportServiceClient())
            {
                Guid id = client.PostReportToQueue(1, new[] { new UnityDIServiceReference.ReportParameter() });
                Console.WriteLine("Report id {0}", id);

                Console.WriteLine("Is report ready: {0}", client.CheckReportIsReady(id));
            }

            Console.ReadKey();
        }
    }
}
