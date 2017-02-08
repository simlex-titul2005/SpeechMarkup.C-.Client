using Newtonsoft.Json;
using SpeechMarkup.Models.Abstract;

namespace SpeechMarkup.Models
{
    public sealed class Number : SpeechMarkupModel
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
