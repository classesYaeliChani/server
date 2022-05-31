using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Configuration;

namespace GUI.Controllers
{
    public class UserController : ApiController
    {     
        
        [HttpGet]
        public bool Login(string userName,string password)
        {
            string name, pass;
            name = ConfigurationManager.AppSettings["userName"];
            pass = ConfigurationManager.AppSettings["password"];
            return name.Equals(userName) && pass.Equals(pass);
        }
    }
}
