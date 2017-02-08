using Newtonsoft.Json;

namespace SpeechMarkup.Models.Values
{
    public sealed class PersonValue
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("surName")]
        public string SurName { get; set; }

        [JsonProperty("patrName")]
        public string PatrName { get; set; }
    }
}
