using System.Runtime.Serialization;

namespace KinoAfishaServices.Models
{
    [DataContract]
    public class Session
    {
        [DataMember(Name = "k_id")]
        public string Id { get; set; }

        [DataMember(Name = "k_name")]
        public string Name { get; set; }

        [DataMember(Name = "k_addr")]
        public string Address { get; set; }

        [DataMember(Name = "k_url")]
        public string Url { get; set; }

        [DataMember(Name = "sessions")]
        public string Sessions { get; set; }
    }
}