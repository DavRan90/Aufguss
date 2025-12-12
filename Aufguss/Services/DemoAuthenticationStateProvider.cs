using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;
using Aufguss.Services.Interface;
using Microsoft.AspNetCore.Components.Authorization;

namespace Aufguss.Services
{
    public class DemoAuthenticationStateProvider : AuthenticationStateProvider, IAuthService
    {
        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity(new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, "demo-user-id"),
            new Claim(JwtRegisteredClaimNames.Email, "demo@demo.com"),
            new Claim(JwtRegisteredClaimNames.PhoneNumber, "+46701234567"),
            new Claim("fullName", "Demo Changed"),
            new Claim("firstName", "Demo"),
            new Claim("gender", "Male"),
            new Claim("friendId", "demo-friend-id"),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(ClaimTypes.Role, "Admin")
        }, "DemoAuth");

            var user = new ClaimsPrincipal(identity);
            return Task.FromResult(new AuthenticationState(user));
        }
        public static Task<AuthenticationState> GetNormalUser()
        {
            var identity = new ClaimsIdentity(new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, "demo-user-id"),
            new Claim(JwtRegisteredClaimNames.Email, "demo@demo.com"),
            new Claim(JwtRegisteredClaimNames.PhoneNumber, "+46701234567"),
            new Claim("fullName", "Demo User"),
            new Claim("firstName", "Demo"),
            new Claim("gender", "Male"),
            new Claim("friendId", "demo-friend-id"),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(ClaimTypes.Role, "User")
        }, "DemoAuth");

            var user = new ClaimsPrincipal(identity);
            return Task.FromResult(new AuthenticationState(user));
        }
        public static Task<AuthenticationState> GetAdminUser()
        {
            var identity = new ClaimsIdentity(new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, "demo-user-id"),
            new Claim(JwtRegisteredClaimNames.Email, "demo@demo.com"),
            new Claim(JwtRegisteredClaimNames.PhoneNumber, "+46701234567"),
            new Claim("fullName", "Demo Admin"),
            new Claim("firstName", "Demo"),
            new Claim("gender", "Male"),
            new Claim("friendId", "demo-friend-id"),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(ClaimTypes.Role, "Admin")
        }, "DemoAuth");

            var user = new ClaimsPrincipal(identity);
            return Task.FromResult(new AuthenticationState(user));
        }
    }
}
