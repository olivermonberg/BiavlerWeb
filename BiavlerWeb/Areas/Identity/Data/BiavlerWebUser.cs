using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BiavlerWeb.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the BiavlerWebUser class
    public class BiavlerWebUser : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }

        [PersonalData]
        public string LastName { get; set; }

        [PersonalData]
        public string DBFNumber { get; set; }

        [PersonalData]
        public string Address { get; set; }

        [PersonalData]
        public string PostalCode { get; set; }

        [PersonalData]
        public string City { get; set; }
    }
}
