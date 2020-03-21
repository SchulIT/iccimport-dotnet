using Newtonsoft.Json;

namespace SchulIT.IccImport.Models
{
    public class RoomData
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("long_name")]
        public string LongName { get; set; }

        [JsonProperty("capacity")]
        public int Capacity { get; set; }
    }
}
