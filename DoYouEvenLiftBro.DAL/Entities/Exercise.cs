using System;
using System.Collections.Generic;
using System.Text;

namespace DoYouEvenLiftBro.DAL.Entities
{
    public class Exercise : BaseEntity
    {
        public String Name { get; set; }
        
        public User User { get; set; }
        public MuscleGroup PrimaryMuscleGroup { get; set; }
    }
}
