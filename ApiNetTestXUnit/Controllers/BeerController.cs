using ApiNetTestXUnit.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiNetTestXUnit.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BeerController : ControllerBase
    {
        private readonly IBeerService _beerService;
        public BeerController(IBeerService service)
        {
            this._beerService = service;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_beerService.Get());
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var beer = _beerService.Get(id);
            if(beer == null)
            {
                return NotFound();
            }
            return Ok(beer);
        }
    }
}
