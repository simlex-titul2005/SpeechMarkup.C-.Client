using Newtonsoft.Json;
using SpeechMarkup.Models.Abstract;
using System.Collections.Generic;

namespace SpeechMarkup.Models
{
    public sealed class City : SpeechMarkupModel
    {
        public City()
        {
            Value = new HashSet<Values.CityValue>();
        }

        [JsonProperty("value")]
        public HashSet<Values.CityValue> Value { get; set; }
    }
}
