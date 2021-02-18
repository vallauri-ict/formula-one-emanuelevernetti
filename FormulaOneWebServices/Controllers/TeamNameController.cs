using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormulaOneDLL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FormulaOneWebServices
{
    [Route("api/teamname")]
    [ApiController]
    public class TeamNameController : ControllerBase
    {
        // GET: api/<TeamNameController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TeamNameController>/5
        [HttpGet("{name}")]
        public Team Get(string name)
        {
            DBUtils db = new DBUtils();
            return db.GetTeamByName(name);
        }

        // POST api/<TeamNameController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TeamNameController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TeamNameController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
