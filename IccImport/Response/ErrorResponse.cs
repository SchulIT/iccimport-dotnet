using Newtonsoft.Json;

namespace SchulIT.IccImport.Response
{
    public class ErrorResponse : ResponseBase
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public dynamic Data { get; set; }

        public ErrorResponse(int responseCode, string responseBody)
            : base(responseCode, responseBody)
        {

        }
    }
}
