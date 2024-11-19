using System.Text.Json.Serialization;

namespace WebApiForRequests.Dtos
{
    public class RequestDto
    {
        [JsonPropertyName("Person")]
        public Person Person { get; set; }

        [JsonPropertyName("Passport")]
        public Passport Passport { get; set; }

        [JsonPropertyName("Request")]
        public CredRequest CredRequest { get; set; } 
    }
}
