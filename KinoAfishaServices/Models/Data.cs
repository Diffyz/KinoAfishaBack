using System.Collections.Generic;
using System.Runtime.Serialization;

namespace KinoAfishaServices.Models
{
    [DataContract]
    public class Data
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "url")]
        public string PartUrl { get; set; }

        [DataMember(Name = "image")]
        public string Image { get; set; }

        [DataMember(Name = "vote")]
        public string Vote { get; set; }

        [DataMember(Name = "count_vote")]
        public string CountVote { get; set; }

        [DataMember(Name = "imdb")]
        public string Imdb { get; set; }

        [DataMember(Name = "countries")]
        public string Country { get; set; }

        [DataMember(Name = "actors")]
        public string Actors { get; set; }

        [DataMember(Name = "premier_ua")]
        public string PremierUa { get; set; }

        [DataMember(Name = "sessions")]
        public IEnumerable<Session> Sessions;
    }
}
