using System.Runtime.Serialization;

namespace SamplePoorDIService
{
    [DataContract]
    public class ReportParameter
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Value { get; set; }
    }
}