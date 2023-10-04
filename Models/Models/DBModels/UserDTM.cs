using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.DBModels
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
