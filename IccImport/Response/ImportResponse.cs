using Newtonsoft.Json;

namespace SchulIT.IccImport.Response
{
    public class ImportResponse : SuccessReponse
    {
        [JsonProperty("added_count")]
        public int AddedCount { get; set; }

        [JsonProperty("updated_count")]
        public int UpdatedCount { get; set; }

        [JsonProperty("removed_count")]
        public int RemovedCount { get; set; }
    }
}
