﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GUI.Controllers
{
    public class SchduleController : ApiController
    {
        // GET: api/Schdule
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Schdule/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Schdule
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Schdule/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Schdule/5
        public void Delete(int id)
        {
        }
    }
}