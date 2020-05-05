using Newtonsoft.Json;

namespace SchulIT.IccImport.Models
{
    public class RoomData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("capacity")]
        public int? Capacity { get; set; }
    }
}
