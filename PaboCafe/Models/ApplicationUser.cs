using Microsoft.AspNetCore.Identity;

namespace PaboCafe.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Firstname { get; set; } = "";
        public string Lastname { get; set; } = "";
        public string Address { get; set; } = "";
        public DateTime CreatedAt { get; set; }
    }
}
