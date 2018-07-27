using System;
using System.Collections.Generic;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;

/*
 * Check this namespace
 */

namespace Samples.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SamplesController : ControllerBase
    {
        // GET api/samples
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/samples/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "sample";
        }

        // POST api/samples
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/samples/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/samples/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
