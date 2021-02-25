using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormulaOneDLL;
using FormulaOneDLL.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FormulaOneWebServices.Controllers
{
    [Route("api/teamDetails")]
    [ApiController]
    public class dtoTeamController : ControllerBase
    {
        // GET: api/<dtoTeamController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<dtoTeamController>/5
        [HttpGet("{name}")]
        public dtoTeam Get(string name)
        {
            DBUtils db = new DBUtils();
            return db.GetTeamDetails(name);
        }

        // POST api/<dtoTeamController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<dtoTeamController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<dtoTeamController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
