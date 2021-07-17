using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turma3API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Turma3Controller : ControllerBase
    {
        [HttpPost]

        public ActionResult Post()
        {
            return Ok("Hello Post");
        }

        [HttpGet]

        public ActionResult Get()
        {
            return Ok("Hello Get");
        }

        [HttpPut]

        public ActionResult Put()
        {
            return Ok("Hello Put");
        }

        [HttpPatch]

        public ActionResult Patch()
        {
            return Ok("Hello Patch");
        }

        [HttpDelete]

        public ActionResult Delete()
        {
            return Ok("Hello Delete");
        }

        [HttpHead]

        public ActionResult Head()
        {
            return Ok("Hello Head");
        }


    }
}
