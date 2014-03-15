using System.Runtime.Serialization;

namespace ReportsDomain
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