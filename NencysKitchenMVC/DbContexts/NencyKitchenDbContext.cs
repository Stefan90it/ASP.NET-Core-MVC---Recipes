using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NencysKitchenMVC.DbContexts
{
    public class NencyKitchenDbContext : IdentityDbContext<IdentityUser>
    {
        public NencyKitchenDbContext(DbContextOptions<NencyKitchenDbContext> options) : base(options)
        {

        }
    }
}
