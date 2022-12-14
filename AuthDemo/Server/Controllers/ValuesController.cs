using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AuthDemo.Server.Controllers
{
    [Route("api/[controller]")]
    [Authorize(Roles = "Administrator")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            if(User.IsInRole("Administrator"))
            {
                return new string[] { "value1", "value2", "value3", "value4" };
            }
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [AllowAnonymous]
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
