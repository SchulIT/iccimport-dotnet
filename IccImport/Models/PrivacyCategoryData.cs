using Newtonsoft.Json;

namespace SchulIT.IccImport.Models
{
    public class PrivacyCategoryData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
