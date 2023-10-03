namespace OKR_Twitter.Models
{
    public class ProcessResult<T>
    {
        public T Result { get; set; }
        public string ErrorDescription { get; set; }
        public bool HasError { get; set; }
    }
}
