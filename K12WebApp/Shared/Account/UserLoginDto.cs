using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace K12WebApp.Shared
{
    public class UserLoginDto
    {
        [Required]
        public string Username { get; set; } = string.Empty;
        
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
