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
        [JsonProperty(PropertyName = "rooms")]
        public IList<string> Rooms { get; set; } = new List<string>();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "replacement_rooms")]
        public IList<string> ReplacementRooms { get; set; } = new List<string>();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "grades")]
        public IList<string> Grades { get; set; } = new List<string>();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "replacement_grades")]
        public IList<string> ReplacementGrades { get; set; } = new List<string>();
    }
}
