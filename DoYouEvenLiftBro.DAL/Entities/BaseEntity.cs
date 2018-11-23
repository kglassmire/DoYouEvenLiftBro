using System;
using System.Collections.Generic;
using System.Text;

namespace DoYouEvenLiftBro.DAL.Entities
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTimeOffset Created { get;set; }
    }
}
