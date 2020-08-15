using Newtonsoft.Json;
using System;

namespace SchulIT.IccImport.Models
{
    public class FreeLessonTimespanData
    {

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }
    }
}
