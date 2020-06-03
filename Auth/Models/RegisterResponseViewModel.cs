using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auth.Data;

namespace Auth.Models
{
    public class RegisterResponseViewModel
    {
        public string Id { get; set; }
       public string FirstName { get; set; }
         public string LastName { get; set; }
        public string Email { get; set; }

        public RegisterResponseViewModel(ApplicationUser user)
        {
            Id = user.Id;
            FirstName = user.FirstName;
             LastName = user.LastName;
            Email = user.Email;
        }
    }
}
