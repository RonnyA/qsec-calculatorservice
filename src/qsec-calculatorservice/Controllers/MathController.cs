using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using qsec_calculatorservice.Models;
using Newtonsoft.Json;

namespace qsec_calculatorservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Add([FromBody] CalcItem postModel)
        {
            if (postModel != null)
                return Ok(postModel.x + postModel.y);
            else
                return StatusCode(500);
        }

        [HttpPost]
        [Route("Substract")]
        public async Task<IActionResult> Substract([FromBody] CalcItem postModel)
        {
            if (postModel != null)
                return Ok(postModel.x - postModel.y);
            else
                return StatusCode(500);
        }
    }


}
