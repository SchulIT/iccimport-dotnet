namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;

    public class AbsenceData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objective")]
        public string Objective { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'study_group', 'teacher'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public System.DateTime Date { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lesson_start")]
        public int? LessonStart { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lesson_end")]
        public int? LessonEnd { get; set; }
    }
}
