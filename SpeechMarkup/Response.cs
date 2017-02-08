using Newtonsoft.Json;
using System.Collections.Generic;

namespace SpeechMarkup
{
    public sealed class Response
    {
        public Response()
        {
            Tokens = new HashSet<Models.Abstract.SpeechMarkupModel>();
        }

        [JsonProperty("string")]
        public string @String { get; set; }

        [JsonProperty("tokens")]
        public HashSet<Models.Abstract.SpeechMarkupModel> Tokens { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
