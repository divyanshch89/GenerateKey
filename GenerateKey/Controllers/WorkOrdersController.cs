using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenerateKey.DAL;
using GenerateKey.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenerateKey.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkOrdersController : ControllerBase
    {
        // GET: api/WorkOrders
        [HttpGet]
        public string Get()
        {
            return "Test";
        }


        // POST: api/WorkOrders
        [HttpPost]
        [Route("GenerateKey")]
        public IActionResult Post([FromBody] string value)
        {
            if (value == null)
                return BadRequest();
            //check if unified key exist
            // 

            return Ok(StatusCodes.Status200OK);
        }

    }

}
