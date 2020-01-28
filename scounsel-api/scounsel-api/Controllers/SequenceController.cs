using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace scounsel_api
{
    [Route("api/[controller]")]
    public class sequenceController : Controller
    {
        
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "ben was here" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
         
        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            value = "id";
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
    var strJSON = String.Empty;

context.Request.InputStream.Position = 0;
using (var inputStream = new StreamReader(context.Request.InputStream))
{
  strJSON = inputStream.ReadToEnd();
}

JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
object serJsonDetails = javaScriptSerializer.Deserialize(strJSON, typeof(object));
}
