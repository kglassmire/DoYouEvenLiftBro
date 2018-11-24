using System;
using System.Collections.Generic;
using System.Text;

namespace DoYouEvenLiftBro.DAL.Entities
{
    public class Set : BaseEntity
    {        
        public WorkoutExercise WorkoutExercise { get; set; }
        public List<Rep> Reps { get; set; }
    }
}
