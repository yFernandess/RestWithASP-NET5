using RestWithASPNET.Hypermedia;
using RestWithASPNET.Hypermedia.Abstract;
using System.Collections.Generic;

namespace RestWithASPNET.Data.VO
{
    public class PersonVO : ISupportsHyperMedia
    {
        //Custom Serialization
        //[JsonPropertyName("identifier")]
        public long Id { get; set; }

        //Custom Serialization
        //[JsonPropertyName("name")]
        public string FirstName { get; set; }

        //Custom Serialization
        //[JsonPropertyName("last_name")]
        public string LastName { get; set; }

        //Custom Serialization
        //[JsonIgnore]
        public string Address { get; set; }

        //Custom Serialization
        //[JsonPropertyName("sex")]
        public string Gender { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
