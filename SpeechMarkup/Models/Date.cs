using Newtonsoft.Json;
using SpeechMarkup.Models.Abstract;
using SpeechMarkup.Models.Values;

namespace SpeechMarkup.Models
{
    public sealed class Date : SpeechMarkupModel
    {
        [JsonProperty("value")]
        public DateValue Value { get; set; }
    }
}
