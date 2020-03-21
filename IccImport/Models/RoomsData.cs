using Newtonsoft.Json;
using System.Collections.Generic;

namespace SchulIT.IccImport.Models
{
    internal class RoomsData
    {
        [JsonProperty("rooms")]
        public IList<RoomData> Rooms { get; set; }
    }
}
