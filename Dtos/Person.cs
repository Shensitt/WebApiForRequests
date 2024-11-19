using System.Text.Json.Serialization;

namespace WebApiForRequests.Dtos
{
    public class Person
    {
        [JsonPropertyName("FirstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("LastName")]
        public string LastName { get; set; }

        [JsonPropertyName("BirthDate")]
        public DateOnly BirthDate { get; set; }
    }
}
