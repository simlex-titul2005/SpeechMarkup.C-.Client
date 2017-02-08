using Newtonsoft.Json;
using SpeechMarkup.Models.Abstract;

namespace SpeechMarkup.Models
{
    public sealed class Person : SpeechMarkupModel
    {
        [JsonProperty("value")]
        public Values.PersonValue Value { get; set; }
    }
}
