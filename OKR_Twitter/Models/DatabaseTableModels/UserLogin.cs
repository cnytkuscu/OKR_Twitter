using System.ComponentModel.DataAnnotations;

namespace OKR_Twitter.Models.DatabaseTableModels
{
    public class UserLogin
    {
        [Key]
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string UserMail { get; set; }
        public string UserPassword { get; set; }
        public string UserSecretCode { get; set; }


    }
}
