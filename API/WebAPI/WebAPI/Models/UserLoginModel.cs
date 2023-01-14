using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class UserLoginModel
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
