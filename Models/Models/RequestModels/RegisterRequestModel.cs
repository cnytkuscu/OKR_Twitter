using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.RequestModels
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
