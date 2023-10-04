using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Entities
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
