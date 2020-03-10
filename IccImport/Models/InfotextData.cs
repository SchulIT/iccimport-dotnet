namespace SchulIT.IccImport.Models
{
    using Newtonsoft.Json;

    public class InfotextData
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public System.DateTime Date { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }
    }
}
