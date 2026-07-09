using Newtonsoft.Json;
using System.Collections.Generic;

namespace SchulIT.IccImport.Models
{
    public class LearningManagementSystemsData
    {
        [JsonProperty(PropertyName = "lms")]
        public List<LearningManagementSystemData> LMS { get; set; }
    }
}
