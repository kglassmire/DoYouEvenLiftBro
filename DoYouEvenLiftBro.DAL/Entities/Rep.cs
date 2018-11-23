using System;
using System.Collections.Generic;
using System.Text;

namespace DoYouEvenLiftBro.DAL.Entities
{
    public class Rep : BaseEntity
    {
        public int EccentricDuration { get; set; }
        public int ConcentricDuration { get; set; }

        public RepType RepType { get; set; }
        public Set Set { get; set; }
    }
}
