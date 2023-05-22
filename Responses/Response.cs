namespace DotnetCoreMssql.Responses
{
    public class Response
    {
        public bool Success { get; set; }
        public Object Data { get; set; }
        public string Message { get; set; }
        // Add more properties as needed

        public Response()
        {

        }

        public Response(Object data)
        {
            Success = true;
            Data = data;
            Message = "";
        }
    }
}
