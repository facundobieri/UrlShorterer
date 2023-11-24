using UrlShorterer.Entities;
using UrlShorterer.Models;

namespace UrlShorterer.Services.Interfaces
{
    public interface IUserService
    {
        void Create(UserForCreationDto dto);
        User? ValidateUser(AuthenticationRequestBody authRequestBody);
    }
}