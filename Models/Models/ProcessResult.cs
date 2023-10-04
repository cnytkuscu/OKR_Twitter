using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ProcessResult<T>
    {
        public T Result { get; set; }
        public string ErrorDescription { get; set; }
        public bool HasError { get; set; }
    }
}
