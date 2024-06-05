using CleanArchitecture.Domain.Entitis.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entitis
{
    public class User:BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Family { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

    }
}
