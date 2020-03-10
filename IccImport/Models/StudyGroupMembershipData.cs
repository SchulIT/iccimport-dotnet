namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;

    public class StudyGroupMembershipData
    {
        /// <summary>
        /// Gets or sets student ID.
        /// </summary>
        [JsonProperty(PropertyName = "student")]
        public string Student { get; set; }

        /// <summary>
        /// Gets or sets external study group ID which the student belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "study_group")]
        public string StudyGroup { get; set; }

        /// <summary>
        /// Gets or sets type of the membership.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }
}
