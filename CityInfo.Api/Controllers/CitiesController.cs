using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Api.Controllers
{
    [ApiController]
    public class CitiesController : ControllerBase
    {
        [HttpGet("Api/cities")]
        public JsonResult GetCities()
        {
            return new JsonResult(
                new List<object>
                {
                     new { Id=1 , Name="mehrshad" },
                     new { Id=2 , Name="aria" }
                });
        }
    }
}
