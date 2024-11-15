using Microsoft.AspNetCore.Identity;
namespace SenateData.DataModels.Auth
{
    public class APIUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
