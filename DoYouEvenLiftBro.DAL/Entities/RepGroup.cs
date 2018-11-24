using System;
using System.Collections.Generic;
using System.Text;

namespace DoYouEvenLiftBro.DAL.Entities
{
    public class RepGroup : BaseEntity
    {
        public int EccentricDuration { get; set; }
        public int ConcentricDuration { get; set; }
        public int Count { get; set; }
        public Set Set { get; set; }
    }
}
