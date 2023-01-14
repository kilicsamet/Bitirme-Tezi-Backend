using Microsoft.AspNetCore.Identity;

namespace WebAPI.Models
{
    public class IdentitySeed
    {
        public static void Seed(UserManager<User> userManager)
        {
            var user = new User()
            {
                UserName = "Onursimsek",
                Email = "helloworld@gmail.com"
            };
            if (userManager.FindByNameAsync("Onursimsek").Result == null)
            {
                var identityResult = userManager.CreateAsync(user, "Abc123456!").Result;
            }
        }
    }
}
