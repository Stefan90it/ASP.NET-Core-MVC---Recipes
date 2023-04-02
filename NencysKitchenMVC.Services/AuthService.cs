using Microsoft.Extensions.Configuration;
using NencysKitchenMVC.DataModel.Recipes;
using NencysKitchenMVC.DataModel.User;
using NencysKitchenMVC.Services.Interfaces;
using Newtonsoft.Json;
using System.Text;

namespace NencysKitchenMVC.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _userRestServise;
        private readonly IConfiguration _configuration;

        public AuthService(IConfiguration configuration)
        {
            _configuration = configuration;
            _userRestServise = new HttpClient();
            _userRestServise.BaseAddress = new Uri(_configuration.GetSection("ExternalServices").GetSection("NencysKitchenAPI").Value);
        }
        public async Task<User> RegisterUser(User user)
        {
            try
            {
                var json = JsonConvert.SerializeObject(user);
                var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
                var response = await _userRestServise.PostAsync($"auth/register", stringContent);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    user = JsonConvert.DeserializeObject<User>(content);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return user;
        }
    }
}
