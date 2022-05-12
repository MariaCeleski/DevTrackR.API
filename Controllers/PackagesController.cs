using DevTrackR.API.Entities;
using DevTrackR.API.Models;
using Microsoft.AspNetCore.Mvc;
using DevTrackR.API.Persistence;


namespace DevTrackR.API.Controllers
{
    [ApiController]
    [Route("api/packages")]
    public class PackagesController : ControllerBase
    {
        private readonly DevTrackRContext _context;

        public PackagesController(DevTrackRContext context) 
        {
            _context = context;
        }

        //Get api/packages
        [HttpGet]
        public IActionResult GetAll() {
             var packages = _context.Packages;
 
           return Ok(packages);
        }

        // GET api/packages/1234-5678-1234-3212
       [HttpGet("{code}")]
       public IActionResult GetByCode(string code){
           var package = _context
                .Packages
                .SingleOrDefaul(p => p.Code == code);

            
           if (package == null) {
               return NotFound();
           }

           return Ok(package);
       }

        //POST api/packages
       [HttpPost]
       public IActionResult Post(AddPackageInputModel model) {
           if (model.Title.Length < 10) {
               return BadRequest("Title length must be at least 10 characters long.");
           }
          
           var package = new Package(model.Title, model.Weight);
 
           _context.Packages.Add(package);
           _context.SaveChanges();
 
           return CreatedAtAction(
               "GetByCode",
               new { code = package.Code },
               package);
       }
 

        //PUT api/packages/1234-5678-1234-3212
    //    [HttpPut("{code}")]
    //    public IActionResult Put(string code){ 
    //        return Ok();     
    //    } Deixar comentada, pois nesse caso não poderá fazer atualização de Título e peso.

        
        //POST api/packages/1234-5678-1234-3212
       [HttpPost("{code}/updates")]
       public IActionResult PostUpdate(string code, AddPackageUpdateInputModel model) {
           var package = _context
               .Packages
               .SingleOrDefault(p => p.Code == code);
 
           if (package == null) {
               return NotFound();
           }
 
           package.AddUpdate(model.Status, model.Delivered);
 
           _context.SaveChanges();
 
           return NoContent();    
       }
    }
}