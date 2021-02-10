﻿using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using FormulaOneDLL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FormulaOneWebServices
{
    [Route("api/country")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        // GET: api/<CountryController>
        [HttpGet]
        public IEnumerable<Country> Get()
        {
            DBUtils db = new DBUtils();
            var wrapper = db.GetListCountry();
            return wrapper;
        }

        // GET api/<CountryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CountryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CountryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CountryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}