using System.Text.Json.Serialization;

namespace RestWithASPNET.Data.VO
{
    public class PersonVO
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
    }
}
