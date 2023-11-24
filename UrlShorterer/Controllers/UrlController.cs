using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UrlShortener.Data;
using UrlShorterer.Entities;
using UrlShorterer.Helpers;
using UrlShorterer.Models.DTOs;

namespace UrlShorterer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UrlController : ControllerBase
    {
        private readonly UrlShortenerContext _UrlContext;
        public UrlController(UrlShortenerContext UrlContext)
        {
            _UrlContext = UrlContext;
        }

        [HttpGet("Get")]

        public IActionResult GetUrl(string ClientUrl)
        {
            var urlEntity = _UrlContext.Urls.FirstOrDefault(x => x.ShortUrls == ClientUrl);

            if (urlEntity == null)
            {
                return NotFound("The URL doesn't exist");
            }
            urlEntity.ViewsCounter += 1;
            _UrlContext.SaveChanges();
            return Ok(urlEntity.Urls);
        }

        [HttpGet("GetByCategories")]

        public IActionResult GetUrlsByCategory(CategoryEnum Category)
        {
            var urlsFounded = _UrlContext.Urls.Where(x => x.Categories == Category).ToList();

            var urlList = urlsFounded.Select(url => url.Urls).ToList();
            return Ok(urlList);
        }

        [HttpPost("Post")]
        public IActionResult CreateNewURL(string newurl, CategoryEnum category)
        {
            var urlHelper = new UrlHelper();
            var urlEntity = new Url()
            {
                Urls = newurl,
                ShortUrls = urlHelper.GetShortURL(),
                Categories = category
            };

            _UrlContext.Urls.Add(urlEntity);
            _UrlContext.SaveChanges();
            return Ok(urlEntity.ShortUrls);
        }


    }
}