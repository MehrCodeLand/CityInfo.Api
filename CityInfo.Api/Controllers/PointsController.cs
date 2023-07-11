using CityInfo.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Api.Controllers
{
    [Route("api/cities/{cityId}/points")]
    public class PointsController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetPointsOfCity(int cityId)
        {
            var city = CitiesDTO.MyCities.Cities.FirstOrDefault(m => m.Id == cityId);

            if (city == null)
                return NotFound();

            return Ok(city.points);
        }


        [HttpGet]
        public ActionResult GetPoint()
        {
            return Ok();
        }


        private City FindCity(int cityId)
        {
            return CitiesDTO.MyCities.Cities.First(m => m.Id == cityId);
        }
    }
}
