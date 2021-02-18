using FormulaOneDLL;

using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FormulaOneWebServices.Controllers
{
    [Route("api/drivername")]
    [ApiController]
    public class DriverNameController : ControllerBase
    {
        // GET: api/<DriverNameController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DriverNameController>/5
        [HttpGet("{name}")]
        public Driver Get(string name)
        {
            DBUtils db = new DBUtils();
            return db.GetDriverByName(name);
        }

        // POST api/<DriverNameController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DriverNameController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DriverNameController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
