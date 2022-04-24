namespace POSModel
{
    public class RequestDTO<T> where T : class
    {
        public T DTO { get; set; }
         
    }
}