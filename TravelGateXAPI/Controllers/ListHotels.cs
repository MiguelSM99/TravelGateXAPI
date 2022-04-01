using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TravelGateXPrueba.Classes;
using TravelGateXPrueba.Tests;

namespace TravelGateXAPI.Controllers
{
    [ApiController]
    [Route("/")]
    public class ListHotels : ControllerBase
    {
        [HttpGet("hotelList")]
        public string Get()
        {
            Punto1 punto1 = new Punto1();
            ListaHoteles hotelList = punto1.Test();
            string jsonNew = JsonConvert.SerializeObject(hotelList, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
            return jsonNew;
        }
    }
}