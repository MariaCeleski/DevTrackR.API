using DevTrackR.API.Entities;
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
             var packages = new List<package>
             {
                 new Package("Pacote 1", 1.3M),
                 new Package("Pacote 2", 0.2M)
             };
 
           return Ok(packages);
        }

        // GET api/packages/1234-5678-1234-3212
       [HttpGet("{code}")]
       public IActionResult GetByCode(string code){
           var package = new Package("Pacote 2", 0.2M);
           return Ok(package);
       }
        //POST api/packages
       [HttpPost]
       public IActionResult Post(){ 
           return Ok();     
       }
        //PUT api/packages/1234-5678-1234-3212
       [HttpPut("{code}")]
       public IActionResult Put (){ 
           return Ok();     
       }
    }
}