using DataLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Tree;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoFullstackAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainController : ControllerBase
    {
        private DatabaseContext _databaseContext;

        public TrainController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        // GET: api/<TrainController>
        [HttpGet]
        public IEnumerable<Train> Get()
        {
            Train train = new Train();
            train.HomeStation = "Zwolle";
            train.Conductor = "Johan";
            train.Speed = 10;
            _databaseContext.Add(train);
            _databaseContext.SaveChanges();

            return _databaseContext.trains;
        }

        // GET api/<TrainController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TrainController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TrainController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TrainController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
