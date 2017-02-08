using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace SpeechMarkup
{
    public sealed class Client
    {
        public async Task<Response> Request(string text, string lang = null)
        {
            var json = string.Empty;
            using (var httpClient = new HttpClient())
            {
                var url = $"http://markup.dusi.mobi/api/text?text={text}";
                if (!string.IsNullOrEmpty(lang))
                    url += "&lang=" + lang;

                json = await httpClient.GetStringAsync(url);
            }
            var data = JsonConvert.DeserializeObject<dynamic>(json);
            var response = new Response();
            response.String = data.@string;

            foreach (var token in data.tokens)
            {
                var type = (string)token["type"];
                switch(type)
                {
                    case "Text":
                        var txt = JsonConvert.DeserializeObject<Models.Text>(token.ToString());
                        response.Tokens.Add(txt);
                        break;
                    case "Date":
                        var date = JsonConvert.DeserializeObject<Models.Date>(token.ToString());
                        response.Tokens.Add(date);
                        break;
                    case "Time":
                        var time = JsonConvert.DeserializeObject<Models.Time>(token.ToString());
                        response.Tokens.Add(time);
                        break;
                    case "Number":
                        var number = JsonConvert.DeserializeObject<Models.Number>(token.ToString());
                        response.Tokens.Add(number);
                        break;
                    case "City":
                        var city = JsonConvert.DeserializeObject<Models.City>(token.ToString());
                        response.Tokens.Add(city);
                        break;
                    case "Person":
                        var person = JsonConvert.DeserializeObject<Models.Person>(token.ToString());
                        response.Tokens.Add(person);
                        break;
                }
            }

            return response;
        }
    }
}
