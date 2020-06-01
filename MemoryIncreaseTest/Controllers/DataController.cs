using MemoryIncreaseTest.Code;
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
		private readonly DbProxy _dbProxy;

		public DataController(DbProxy dbProxy)
		{
			_dbProxy = dbProxy;
		}
        
        public async Task<IActionResult> Post()
		{
            using var ms = new MemoryStream();
            await Request.Body.CopyToAsync(ms);
            //await _dbProxy.Insert(ms.ToArray());
            await Task.Delay(500);
            return NoContent();
		}

    }
}
