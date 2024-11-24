using System.Text.Json.Serialization;

namespace WebApiForRequests.Dtos
{
    public class RequestDto
    {
        [JsonPropertyName("Person")]
        public Person Person { get; set; } = new Person();

        [JsonPropertyName("Passport")]
        public Passport Passport { get; set; } = new Passport();

        [JsonPropertyName("Request")]
        public CredRequest CredRequest { get; set; } = new CredRequest();
    }
}
