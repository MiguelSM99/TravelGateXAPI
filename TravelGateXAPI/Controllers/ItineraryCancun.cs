using Microsoft.AspNetCore.Mvc;
using TravelGateXPrueba.Tests;

namespace TravelGateXAPI.Controllers
{
    [ApiController]
    [Route("/")]
    public class ItineraryCancun : ControllerBase
    {

        [HttpGet("itineraryCancun")]
        public string Get()
        {
            Punto1 punto1 = new Punto1();
            Punto2 punto2 = new Punto2();
            IDictionary<string, string> mealPlanCity = new Dictionary<string, string>();
            mealPlanCity.Add("Malaga", "");
            mealPlanCity.Add("Cancun", "ad");
            double max_price = 700;
            bool cheap = true;
            string cheaper_city = "Malaga";
            return punto2.Test(punto1.Test(), mealPlanCity, max_price, cheap, cheaper_city);
        }

    }
}