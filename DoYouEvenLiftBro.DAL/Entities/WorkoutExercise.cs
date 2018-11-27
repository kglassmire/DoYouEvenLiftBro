using System;
using System.Collections.Generic;
using System.Text;

namespace DoYouEvenLiftBro.DAL.Entities
{
    public class WorkoutExercise : BaseEntity
    {
        public string Name { get; set; }
        public int SequenceNum { get; set; }

        public Exercise Exercise { get; set; }    
        public Workout Workout { get; set; }
        public List<Set> Sets { get; set; }
    }
}
