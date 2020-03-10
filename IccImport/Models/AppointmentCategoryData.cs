namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;

    public class AppointmentCategoryData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public int Name { get; set; }

        /// <summary>
        /// Gets or sets hex color string without leading hashtag. Note:
        /// abbreviated values (e.g. 000, fff, .
        /// </summary>
        /// <remarks>
        /// ..) are not allowed.
        /// </remarks>
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }
    }
}
