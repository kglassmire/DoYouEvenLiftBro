using System;
using System.Collections.Generic;
using System.Text;

namespace DoYouEvenLiftBro.DAL.Entities
{
    public class Set : BaseEntity
    {        
        public WorkoutExercise WorkoutExercise { get; set; }
        public int Reps { get; set; }
        public int SequenceNum { get; set; }

        public decimal Weight { get; set; }
        public string Notes { get; set; }
    }
}
