namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    internal class TimetableLessonsData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lessons")]
        public IList<TimetableLessonData> Lessons { get; set; }

    }
}
