using Newtonsoft.Json;

namespace SpeechMarkup.Models.Abstract
{
    public abstract class SpeechMarkupModel
    {
        public enum SpeechMarkupModelTypeEnum : byte
        {
            Number=0,
            Date=1,
            Time=2,
            City=3,
            Text=4
        }
        [JsonProperty("type")]
        public SpeechMarkupModelTypeEnum Type { get; set; }

        [JsonProperty("substring")]
        public string Substring { get; set; }

        [JsonProperty("formatted")]
        public string Formatted { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
