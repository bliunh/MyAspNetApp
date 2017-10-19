using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyAspNetApp.Controllers
{
    public class ValuesController : ApiController
    {
        public static List<string> _values = new List<string>() { "value0", "value1", "value2", "value3", "value4" };

        // GET api/values
        public IEnumerable<string> Get()
        {
            return _values;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return _values[id];
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            _values.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            _values[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            _values.RemoveAt(id);
        }
    }
}
