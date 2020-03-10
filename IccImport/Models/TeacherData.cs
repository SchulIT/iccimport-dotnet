namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class TeacherData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "acronym")]
        public string Acronym { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "firstname")]
        public string Firstname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastname")]
        public string Lastname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'male', 'female', 'x'
        /// </summary>
        [JsonProperty(PropertyName = "gender")]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the list of external IDs of subjects which the
        /// teacher teaches.
        /// </summary>
        [JsonProperty("subjects")]
        public IList<string> Subjects { get; set; }

        /// <summary>
        /// Gets or sets list of external IDs of tags which are added to the
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<string> Tags { get; set; }
    }
}
