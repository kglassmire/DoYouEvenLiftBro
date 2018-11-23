using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoYouEvenLiftBro.DAL.Entities
{
    public class Role : IdentityRole<long>
    {
        public Role()
        { }

        public Role(string roleName)
        {
            Name = roleName;
        }
    }
}
