using Microsoft.AspNetCore.Identity;

namespace economus_cpp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
