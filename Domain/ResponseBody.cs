namespace Domain
{
    public class ResponseBody<T>
    {
        public string? message;
        public int? status;
        public T? data;
    }
}
