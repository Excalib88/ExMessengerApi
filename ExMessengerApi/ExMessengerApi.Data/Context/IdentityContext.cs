using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ExMessengerApi.Data.Context
{
    // ApplicationUser cannot pass as generic parameter here
    public class IdentityContext : IdentityDbContext<IdentityUser>
    {
    }
}