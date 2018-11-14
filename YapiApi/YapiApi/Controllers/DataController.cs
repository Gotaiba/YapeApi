using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using YapiApi.Models;

namespace YapiApi.Controllers
{
    public class DataController : ApiController
    {       
        [HttpGet]
        public IHttpActionResult Check()
        {
            return Ok("Hello There");
        }


    }
}
