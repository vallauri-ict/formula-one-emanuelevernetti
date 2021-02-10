using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormulaOneDLL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FormulaOneWebServices
{
    [Route("api/driver")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        // GET: api/<DriverController>
        [HttpGet]
        public IEnumerable<Driver> Get()
        {
            DBUtils db = new DBUtils();
            var wrapper = db.GetListDriver();
            return wrapper;
        }

        // GET api/<DriverController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DriverController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DriverController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DriverController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
