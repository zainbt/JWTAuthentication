using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace JWTAuthentication.Models
{
    public class User
    {
        [Key]
        [NotNull]
        [MaxLength(36)]
        public string Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Email { get; set; } = string.Empty;
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;
        [Required, NotNull]
        public byte[] PasswordHash { get; set; }
        [Required, NotNull]
        public byte[] PasswordSalt { get; set; }
        [Required]
        [MaxLength(50)]
        public string Country { get; set; } = string.Empty;
        [Required]
        [MaxLength(50)]
        public string Organization { get; set; } = string.Empty;
        [Required]
        [MaxLength(50)]
        public string Occupation { get; set; } = string.Empty;
        [Required]
        [MaxLength(50)]
        public DateTime CreatedAt { get; set; }
        [Required]
        [MaxLength(50)]
        public DateTime UpdatedAt { get; set; }
    }
}
