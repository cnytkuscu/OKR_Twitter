using System.ComponentModel.DataAnnotations;

namespace OKR_Twitter.Models.RequestModels
{
    public class RegisterRequestModel
    { 
        public Guid UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserMail { get; set; }
        [Required]
        public string UserPassword { get; set; }
        [Required]
        public string UserSecretCode { get; set; }
    }
}
