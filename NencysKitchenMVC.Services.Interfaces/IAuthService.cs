using NencysKitchenMVC.DataModel.Recipes;
using NencysKitchenMVC.DataModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NencysKitchenMVC.Services.Interfaces
{
    public interface IAuthService
    {
        Task<User> RegisterUser(User user);
    }
}
