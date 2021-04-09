namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class TimetableLessonData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "week")]
        public string Week { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "day")]
        public int Day { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lesson")]
        public int Lesson { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_double_lesson")]
        public bool IsDoubleLesson { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "room")]
        public string Room { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("teachers")]
        public IList<string> Teachers { get; set; } = new List<string>();

        /// <summary>
        /// </summary>
        [JsonProperty("grades")]
        public IList<string> Grades { get; set; } = new List<string>();

        /// <summary>
        /// </summary>
        [JsonProperty("subject")]
        public string Subject { get; set; }
    }
}
