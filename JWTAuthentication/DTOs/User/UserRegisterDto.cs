
namespace JWTAuthentication.DTOs.User
{
    public class UserRegisterDto
    {

        public string Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Counntry { get; set; } = string.Empty;
        public string Organization { get; set; } = string.Empty;
        public string Occupation { get; set; } = string.Empty;
    }
}
