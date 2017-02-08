using Newtonsoft.Json;
using System;

namespace SpeechMarkup.Models.Values
{
    public sealed class DateValue
    {
        private byte _day;
        [JsonProperty("day")]
        public byte Day
        {
            get
            {
                return _day;
            }
            set
            {
                if (value < 1 || value > 31) throw new ArgumentOutOfRangeException();
                _day = value;
            }
        }

        private byte _month;
        [JsonProperty("month")]
        public byte Month
        {
            get
            {
                return _month;
            }
            set
            {
                if (value < 0 || value > 11) throw new ArgumentOutOfRangeException();
                _month = value;
            }
        }

        [JsonProperty("year")]
        public int Year { get; set; }
    }
}
