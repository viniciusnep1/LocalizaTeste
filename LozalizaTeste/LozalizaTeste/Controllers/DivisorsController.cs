using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LozalizaTeste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DivisorsController : ControllerBase
    {
        private readonly DivisorsServices services;

        public DivisorsController(DivisorsServices services)
        {
            this.services = services;
        }

        [HttpPost]
        public async Task<IActionResult>     Post([FromBody] int Number)
        {
            var result = await services.CalcDivisors(Number);
            if (result.IsOk)
                return Ok(result);
            else
                return BadRequest(result);
        }
    }
}
