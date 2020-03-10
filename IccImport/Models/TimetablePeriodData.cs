namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;

    public class TimetablePeriodData
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
        [JsonProperty(PropertyName = "start")]
        public System.DateTime Start { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "end")]
        public System.DateTime End { get; set; }
    }
}
