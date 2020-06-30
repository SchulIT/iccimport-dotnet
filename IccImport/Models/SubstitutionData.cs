namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class SubstitutionData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public System.DateTime? Date { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lesson_start")]
        public int? LessonStart { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lesson_end")]
        public int? LessonEnd { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "starts_before")]
        public bool? StartsBefore { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "replacement_subject")]
        public string ReplacementSubject { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teachers")]
        public IList<string> Teachers { get; set; } = new List<string>();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "replacement_teachers")]
        public IList<string> ReplacementTeachers { get; set; } = new List<string>();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "room")]
        public string Room { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "replacement_room")]
        public string ReplacementRoom { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "remark")]
        public string Remark { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "study_groups")]
        public IList<string> StudyGroups { get; set; } = new List<string>();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "replacement_study_groups")]
        public IList<string> ReplacementStudyGroups { get; set; } = new List<string>();
    }
}
