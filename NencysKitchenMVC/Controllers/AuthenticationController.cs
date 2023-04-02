using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NencysKitchenMVC.DataModel.User;
using NencysKitchenMVC.Services.Interfaces;
using NencysKitchenMVC.ViewModels;

namespace NencysKitchenMVC.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly IAuthService _authService;
        private readonly IMapper _mapper;

        public AuthenticationController(IAuthService authService, IMapper mapper)
        {
            _authService = authService;
            _mapper = mapper;
        }
        public async Task<IActionResult> RegisterUser(User user)
        {
            var registeredUser = _authService.RegisterUser(user);
            return View(registeredUser);
        }
    }
}
