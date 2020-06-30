namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class ExamData
    {
        /// <summary>
        /// Gets or sets your ID which is used to update existing exams.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

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

        /// <summary>
        /// Gets or sets optional description of the exam
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets list of external tuition IDs which are related to this
        /// exam.
        /// </summary>
        [JsonProperty(PropertyName = "tuitions")]
        public IList<string> Tuitions { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets list of external student IDs which attend this exam.
        /// </summary>
        [JsonProperty(PropertyName = "students")]
        public IList<string> Students { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets acronyms of the teachers (their acronyms) which
        /// supervise the exam.
        /// </summary>
        [JsonProperty(PropertyName = "supervisions")]
        public IList<string> Supervisions { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets list of rooms, in which the exam takes place.
        /// </summary>
        [JsonProperty(PropertyName = "rooms")]
        public IList<string> Rooms { get; set; } = new List<string>();
    }
}
