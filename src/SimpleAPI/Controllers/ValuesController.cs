﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
       
       //GET api/values
       [HttpGet]
       public ActionResult<IEnumerable<String>> Get()
       {
           return new string[] {"jakas", "zmiana"};
       }

        // GET api/values/5
       [HttpGet("{id}")]
       public ActionResult<string> Get(int id)
       {
           return "Kuba C";
       }
 
    }
}
