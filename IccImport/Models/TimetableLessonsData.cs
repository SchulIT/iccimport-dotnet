namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    internal class TimetableLessonsData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "period")]
        public string Period { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lessons")]
        public IList<TimetableLessonData> Lessons { get; set; }

    }
}
