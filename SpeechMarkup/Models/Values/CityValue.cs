using Newtonsoft.Json;

namespace SpeechMarkup.Models.Values
{
    public sealed class CityValue
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lat")]
        public float Latitude { get; set; }

        [JsonProperty("lon")]
        public float Longitude { get; set; }

        [JsonProperty("population")]
        public int Population { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
