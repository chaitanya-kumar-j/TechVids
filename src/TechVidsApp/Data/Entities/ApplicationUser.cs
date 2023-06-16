using Microsoft.AspNetCore.Identity;

namespace TechVidsApp.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public string AddressLine1 { get; set; }
        
        public string AddressLine2 { get; set;}

        public string PostCode { get; set;}
    }
}
