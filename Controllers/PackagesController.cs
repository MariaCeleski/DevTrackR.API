using Microsoft.AspNetCore.Mvc;

namespace DevTrackR.API.Controllers
{
    [ApiController]
    [Route("api/packages")]
    public class PackagesController : ControllerBase
    {
        //Get api/packages
        [HttpGet]
        public IActionResult GetAll() {
             var packages = new List<Package>{};
 
           return Ok(packages);
        }

        // GET api/packages/1234-5678-1234-3212
       [HttpGet("{code}")]
       public IActionResult GetByCode(string code){
           return Ok();
       }
    }
}