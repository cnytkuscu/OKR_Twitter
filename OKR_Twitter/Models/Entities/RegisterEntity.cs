namespace OKR_Twitter.Models.Entities
{
    public class RegisterEntity
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string UserMail { get; set; }
        public string UserPassword { get; set; }
        public string UserSecretCode { get; set; }
    }
}
