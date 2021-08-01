namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public class StudentData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

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
        /// Gets or sets possible values include: 'male', 'female', 'x'
        /// </summary>
        [JsonProperty(PropertyName = "gender")]
        public string Gender { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "birthday")]
        public DateTime Birthday { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("approved_privacy_categories")]
        public IList<string> ApprovedPrivacyCategories { get; set; } = new List<string>();
    }
}
