using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class MemberDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PhotoUrl { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; } 
        public DateTime LastActive { get; set; } 
        public string Gender { get; set; }
        public string LookingFor { get; set; }
        public string Introduction { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Job { get; set; }
        public string Company { get; set; }
        public string Education { get; set; }
        public int Height { get; set; }
        public string Children { get; set; }
        public string Drinking { get; set; }
        public string Relationship { get; set; }
        public string Sexuality { get; set; }
        public string Smoking { get; set; }
        public string StarSign { get; set; }
        public string Religion { get; set; }
        public string Personality { get; set; }
        public string WhyYouAreHere { get; set; }
        public string School { get; set; }
        public ICollection<PhotoDto> Photos { get; set; }
        public ICollection<Gender> InterestedInGenders { get; set; }
    }
}
