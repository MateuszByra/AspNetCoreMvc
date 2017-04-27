using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Services;

namespace OdeToFood.Controllers
{

    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;
        public HomeController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        public IActionResult Index()
        {
            var model = _restaurantData.GetAll();//new Restaurant { Id = 1, Name = "The House of Kobe." };

            //return new ObjectResult(model); // object result return serialized model, eg. in json (if app content in header is json. Depends on content header).
            return View(model);
        }
    }
}