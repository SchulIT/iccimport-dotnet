namespace SchulIT.IccImport.Response
{
    public abstract class ResponseBase : IResponse
    {
        public int ResponseCode { get; private set; }

        public string ResponseBody { get; private set; }

        public ResponseBase(int responseCode, string responseBody)
        {
            ResponseCode = responseCode;
            ResponseBody = responseBody;
        }
    }
}
