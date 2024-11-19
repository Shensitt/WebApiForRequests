using System.Text.Json.Serialization;

namespace WebApiForRequests.Dtos
{
    public class Passport
    {
        [JsonPropertyName("Serie")]
        public string Serie { get; set; }

        [JsonPropertyName("Number")]
        public string Number { get; set; }
    }
}
