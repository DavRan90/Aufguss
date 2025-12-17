using Aufguss.Models;
using static System.Net.WebRequestMethods;

namespace Aufguss.Services.Interface
{
    public interface IAboutService
    {
        Task<About> GetHTMLAsync();
        Task EditAboutAsync(string editAbout);
    }
}
