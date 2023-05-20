namespace ASP.NET_API.Exceptions
{
    public class HttpException : Exception
    {
        public int Code { get; set; }

        public HttpException(string message, int code = 400) : base(message)
        {
            Code = code;
        }
    }
}
