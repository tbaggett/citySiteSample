using CitySite.Routing;
using Microsoft.AspNetCore.Mvc;

namespace CitySite.Controllers
{
    public class NewsController : Controller
    {
        public ActionResult Index(ICityInfo cityInfo) => View(cityInfo.CityNewsViewModel);
    }
}