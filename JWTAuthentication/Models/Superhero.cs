using System.ComponentModel.DataAnnotations;

namespace TestAPI
{
    public class Superhero
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Place { get; set; } = string.Empty;
    }
}
