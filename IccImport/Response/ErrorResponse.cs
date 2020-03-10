using Newtonsoft.Json;

namespace SchulIT.IccImport.Response
{
    public class ErrorResponse : IResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public dynamic Data { get; set; }
    }
}
