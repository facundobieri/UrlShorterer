using UrlShorterer.Models.DTOs;

namespace UrlShorterer.Models
{
    public class UserForCreationDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}