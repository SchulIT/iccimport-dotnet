using Newtonsoft.Json;
using System.Collections.Generic;

namespace SchulIT.IccImport.Models
{
    internal class FreeLessonTimespansData
    {
        [JsonProperty("free_lessons")]
        public IList<FreeLessonTimespanData> FreeLessons { get; set; }
    }
}
