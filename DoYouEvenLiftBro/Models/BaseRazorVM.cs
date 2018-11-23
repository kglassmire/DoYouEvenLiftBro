using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoYouEvenLiftBro.Models
{
    public class BaseRazorVM
    {
        public IEnumerable Errors { get; set; }
    }
}
