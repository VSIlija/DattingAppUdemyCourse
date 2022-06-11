using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Gender
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public ICollection<AppUser> AppUsers { get; set; }
    }
}
