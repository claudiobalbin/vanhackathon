using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sensei_api.Models;
using sensei_api.Ado;
using Newtonsoft.Json;

namespace sensei_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        // public ActionResult<IEnumerable<string>> Get()
        [HttpGet]
        public ActionResult<string> Get()
        {
            // return new string[] { "value1", "value2" };
            DB_Util db = new DB_Util();
            return JsonConvert.SerializeObject(db.getLicenses());

            // return "teste";
        }

        // // GET api/values/5
        // [HttpGet("{id}")]
        // public ActionResult<string> Get(int id)
        // {
        //     DB_Util db = new DB_Util();
        //     return JsonConvert.SerializeObject(db.getLicenses());

        //     // return "value";
        // }

        // // POST api/values
        // [HttpPost]
        // public void Post([FromBody] string value)
        // {
        // }

        // // PUT api/values/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody] string value)
        // {
        // }

        // // DELETE api/values/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }
    }
}
