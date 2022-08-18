using Microsoft.AspNetCore.Mvc;

namespace SampleWebApiAspNetCore.v2.Controllers
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class FoodsController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("2.0");
            //Added comment
            //Added in code
            //Added code again in VS
            //8/16/2022
            //Tst
        }
    }
}
