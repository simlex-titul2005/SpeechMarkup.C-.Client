using Newtonsoft.Json;
using System;

namespace SpeechMarkup.Models.Values
{
    public sealed class TimeValue
    {
        private byte _hour;
        [JsonProperty("hour")]
        public byte Hour
        {
            get
            {
                return _hour;
            }
            set
            {
                if (value < 0 || value > 23) throw new ArgumentOutOfRangeException();
                _hour = value;
            }
        }

        private byte _minute;
        [JsonProperty("minute")]
        public byte Minute
        {
            get
            {
                return _minute;
            }
            set
            {
                if (value < 0 || value > 59) throw new ArgumentOutOfRangeException();
                _minute = value;
            }
        }

        private byte _second;
        [JsonProperty("second ")]
        public byte Second
        {
            get
            {
                return _second;
            }
            set
            {
                if (value < 0 || value > 59) throw new ArgumentOutOfRangeException();
                _second = value;
            }
        }

        [JsonProperty("part")]
        public string Part { get; set; }
    }
}
