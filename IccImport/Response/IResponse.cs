namespace SchulIT.IccImport.Response
{
    public interface IResponse
    {
        int ResponseCode { get; }

        string ResponseBody { get; }
    }
}
