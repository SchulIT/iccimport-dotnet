using Newtonsoft.Json;

namespace SchulIT.IccImport.Models
{
    public class GradeMembershipData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "grade")]
        public string Grade { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "student")]
        public string Student { get; set; }
    }
}
