namespace PruebasIAS.API.Model
{
    public class ResponseModel
    {
        public int Status { get; set; }
        public string Message { get; set; } = string.Empty;
        public object? Data { get; set; }
    }
}
