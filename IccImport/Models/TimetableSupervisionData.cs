namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class TimetableSupervisionData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "weeks")]
        public IList<int> Weeks { get; set; } = new List<int>();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "day")]
        public int Day { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_before")]
        public bool? IsBefore { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teacher")]
        public string Teacher { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lesson")]
        public int? Lesson { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }
    }
}
