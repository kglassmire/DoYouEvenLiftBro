using DoYouEvenLiftBro.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoYouEvenLiftBro.Responses
{
    public class ExercisesResponse : BaseApiResponse
    {
        public IList<Exercise> Data { get; set; }
    }
}
