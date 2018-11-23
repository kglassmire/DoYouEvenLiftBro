using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoYouEvenLiftBro.Responses
{
    public abstract class BaseApiResponse
    {
        public String Status { get; set; }
        public String Message { get; set; }
    }
}
