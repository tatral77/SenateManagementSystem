using Microsoft.AspNetCore.Identity;
namespace SenateData.DataModels.Auth
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
