using CityInfo.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Api.Controllers
{
    [Route("api/cities")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        [HttpGet("{cityId}")]
        public ActionResult GetCity(int cityId)
        {
            var city = CitiesDTO.MyCities.Cities.FirstOrDefault( m => m.Id == cityId );
            if (city == null)
                return NotFound();

            return Ok(city);
        }

        [HttpGet]
        public ActionResult GetCity()
        {
            return Ok(CitiesDTO.MyCities.Cities);
        }
    }
}
