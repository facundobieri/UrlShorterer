using System.ComponentModel.DataAnnotations;
using UrlShorterer.Models.DTOs;

namespace UrlShorterer.Models
{
    public class UrlForCreationDto
    {
        [Required] 
        public string Id {  get; set; }
        [Required]
        public string? Urls { get; set; }
        [Required]
        public string? ShortUrls { get; set; }
        public int ViewsCounter { get; set; }
        public CategoryEnum Categories { get; set; }
    }
}
