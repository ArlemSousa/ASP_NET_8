using Microsoft.AspNetCore.Identity;

namespace API_JWT.Models
{
    public class ApplicationUser: IdentityUser
    {

        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }

    }
}
