using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoYouEvenLiftBro.Responses;
using DoYouEvenLiftBro.DAL;
using DoYouEvenLiftBro.DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoYouEvenLiftBro.Controllers
{
    [Route("api/[controller]")]
    public class ExercisesController : Controller
    {
        private DoYouEvenLiftBroContext _dbContext;
        public ExercisesController(DoYouEvenLiftBroContext context)
        {
            _dbContext = context;
        }
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            ExercisesResponse response = new ExercisesResponse();
            response.Data = _dbContext.Exercises.ToList();
            response.Status = "success";
            response.Message = $"{response.Data.Count} exercises found";
            return Ok(response);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            ExercisesResponse response = new ExercisesResponse();
            var exercise = _dbContext.Exercises.Find(id);
            if (exercise != null)
            {
                var listReturn = new List<Exercise>();
                listReturn.Add(exercise);
                response.Data = listReturn;
                response.Status = "success";
                response.Message = "Found exercise";
                return Ok(response);
            }

            response.Status = "failure";
            response.Message = "No exercise found";
            return BadRequest(response);                       
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
