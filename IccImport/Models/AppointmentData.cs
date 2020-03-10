namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class AppointmentData
    {
        /// <summary>
        /// Gets or sets your ID which is used to update existing appointments.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the key of the category which the appointment belongs
        /// to.
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public System.DateTime Start { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "end")]
        public System.DateTime End { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_all_day")]
        public bool? IsAllDay { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "visibilities")]
        public IList<string> Visibilities { get; set; }

        /// <summary>
        /// Gets or sets list of external study group IDs, which this
        /// appointment belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "study_groups")]
        public IList<string> StudyGroups { get; set; }

        /// <summary>
        /// Gets or sets list of teachers (their acronyms) which attend this
        /// appointment.
        /// </summary>
        [JsonProperty(PropertyName = "organizers")]
        public IList<string> Organizers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "external_organizers")]
        public string ExternalOrganizers { get; set; }
    }
}
