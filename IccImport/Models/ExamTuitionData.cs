using Newtonsoft.Json;
using System.Collections.Generic;

namespace SchulIT.IccImport.Models
{
    public class ExamTuitionData
    {
        [JsonProperty("grades")]
        public IList<string> Grades { get; set; } = new List<string>();

        [JsonProperty("teachers")]
        public IList<string> Teachers { get; set; } = new List<string>();

        [JsonProperty("subject_or_course")]
        public string SubjectOrCourse { get; set; }
    }
}
