using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GUI.Controllers
{
    public class SoftWareController : ApiController
    {
        // GET: api/SoftWare
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SoftWare/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SoftWare
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SoftWare/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SoftWare/5
        public void Delete(int id)
        {
        }
    }
}
