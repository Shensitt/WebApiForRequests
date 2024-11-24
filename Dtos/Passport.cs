using System.Text.Json.Serialization;

namespace WebApiForRequests.Dtos
{
    public class Passport
    {
        [JsonPropertyName("Serie")]
        public string Serie { get; set; } = string.Empty;

        [JsonPropertyName("Number")]
        public string Number { get; set; } =string.Empty;   
    }
}
