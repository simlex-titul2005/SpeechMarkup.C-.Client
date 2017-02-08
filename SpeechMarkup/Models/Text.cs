using Newtonsoft.Json;
using SpeechMarkup.Models.Abstract;

namespace SpeechMarkup.Models
{
    public sealed class Text : SpeechMarkupModel
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
