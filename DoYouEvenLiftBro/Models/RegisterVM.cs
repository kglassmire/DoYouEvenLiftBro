
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoYouEvenLiftBro.Models
{
    public class RegisterVM : BaseRazorVM
    {        
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
