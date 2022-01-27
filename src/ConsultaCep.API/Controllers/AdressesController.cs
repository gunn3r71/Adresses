using System.Threading.Tasks;
using ConsultaCep.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace ConsultaCep.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AdressesController : Controller
    {
        private readonly AdressesService _adressesService;

        public AdressesController(AdressesService consultaCepService)
        {
            _adressesService = consultaCepService;
        }

        [HttpGet("zipcode/{zipcode:length(8)}")]
        public async Task<IActionResult> GetAddressByZipCode([FromRoute] string zipcode)
        {
            var result = await _adressesService.GetAddressByZipCode(zipcode);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }
    }
}