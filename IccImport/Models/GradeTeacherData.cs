namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;

    public class GradeTeacherData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "grade")]
        public string Grade { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teacher")]
        public string Teacher { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'primary', 'substitute'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }
}
