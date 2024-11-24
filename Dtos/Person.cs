using System.Text.Json.Serialization;

namespace WebApiForRequests.Dtos
{
    public class Person
    {
        [JsonPropertyName("FirstName")]
        public string FirstName { get; set; } = string.Empty;

        [JsonPropertyName("LastName")]
        public string LastName { get; set; } =string.Empty;

        [JsonPropertyName("BirthDate")]
        public DateOnly BirthDate { get; set; }
    }
}
