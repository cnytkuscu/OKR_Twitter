using System.ComponentModel.DataAnnotations;

namespace OKR_Twitter.Models.DatabaseTableModels
{
    public class UserDTM
    {
        [Key]
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public DateTime UserRegistrationDate { get; set; }
        public bool UserGender { get; set; }
        public bool UserDeleted { get; set; }
        public DateTime UserLastLoginDate { get; set; }
        public DateTime UserLastUpdateDate { get; set; }
    }
}
