namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class TuitionData
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
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teacher")]
        public string Teacher { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "additional_teachers")]
        public IList<string> AdditionalTeachers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "study_group")]
        public string StudyGroup { get; set; }
    }
}
