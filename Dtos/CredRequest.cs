using System.Text.Json.Serialization;

namespace WebApiForRequests.Dtos
{
    public class CredRequest
    {
        [JsonPropertyName("Summa")]
        public long Summa { get; set; }

        [JsonPropertyName("Period")]
        public int Period { get; set; }
    }
}
