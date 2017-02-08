using Newtonsoft.Json;
using SpeechMarkup.Models.Abstract;
using SpeechMarkup.Models.Values;

namespace SpeechMarkup.Models
{
    public sealed class Time : SpeechMarkupModel
    {
        [JsonProperty("value")]
        public TimeValue Value { get; set; }
    }
}
