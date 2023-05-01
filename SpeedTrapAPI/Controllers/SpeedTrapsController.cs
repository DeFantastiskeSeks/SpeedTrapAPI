using Microsoft.AspNetCore.Mvc;
using SpeedTrapAPI.Model;
using SpeedTrapAPI.Repos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpeedTrapAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpeedTrapsController : ControllerBase
    {
        // GET: api/<SpeedTrapController>
        public SpeedTrapsRepo _repo;
        public SpeedTrapsController(SpeedTrapsRepo repo) 
        { 
            _repo = repo; 
        }
        [HttpGet]
        public List<SpeedTrap> GetAll()
        {
            return _repo.GetAll();
        }

        // GET api/<SpeedTrapController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SpeedTrapController>
        [HttpPost]
        public void Post([FromBody] SpeedTrap trapperino)
        {
            _repo.Create(trapperino);
        }

        // PUT api/<SpeedTrapController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SpeedTrapController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
