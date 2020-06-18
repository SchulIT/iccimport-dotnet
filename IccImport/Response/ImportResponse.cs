using Newtonsoft.Json;
using System.Collections.Generic;

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

        [JsonProperty("ignored")]
        public List<object> IgnoredEntities { get; set; }

        public ImportResponse(int responseCode, string responseBody)
            : base(responseCode, responseBody)
        {

        }
    }
}
