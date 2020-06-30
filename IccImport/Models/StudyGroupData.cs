namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class StudyGroupData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "grades")]
        public IList<string> Grades { get; set; } = new List<string>();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "students")]
        public IList<string> Students { get; set; } = new List<string>();
    }
}
