namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;

    public class TimetableLessonData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tuition")]
        public string Tuition { get; set; }

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
    }
}
