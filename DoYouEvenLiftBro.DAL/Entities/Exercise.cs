using System;
using System.Collections.Generic;
using System.Text;

namespace DoYouEvenLiftBro.DAL.Entities
{
    public class Exercise : BaseEntity
    {
        public string Name { get; set; }        

        public User User { get; set; }
        public List<MuscleGroup> MuscleGroups { get; set; }
    }
}
