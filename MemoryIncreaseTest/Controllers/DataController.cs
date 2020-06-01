using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryIncreaseTest.Controllers
{
    [Route("api/data")]
    [ApiController]
    public class DataController : ControllerBase
    {
        public async Task<IActionResult> Post()
		{
            using var ms = new MemoryStream();
            await Request.Body.CopyToAsync(ms);
            await Task.Delay(500);
            return NoContent();
		}

    }
}
