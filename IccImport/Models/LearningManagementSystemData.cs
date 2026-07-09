using Newtonsoft.Json;

namespace SchulIT.IccImport.Models
{
    public class LearningManagementSystemData
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }


    }
}
