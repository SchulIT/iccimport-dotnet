using Newtonsoft.Json;
using System.Collections.Generic;

namespace SchulIT.IccImport.Models
{
    public class StudentLearningManagementSystemsData
    {
        [JsonProperty(PropertyName = "consents")]
        public List<StudentLearningManagementSystemData> Consents { get; set; }
    }
}
