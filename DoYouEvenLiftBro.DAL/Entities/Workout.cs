using System;
using System.Collections.Generic;
using System.Text;

namespace DoYouEvenLiftBro.DAL.Entities
{
    public class Workout : BaseEntity
    {
        public string Name { get; set; }
        public DateTimeOffset Date { get; set; }
        public List<WorkoutExercise> WorkoutExercises { get; set; }
        public User User { get; set; }
    }
}
