using Microsoft.AspNetCore.Mvc;
using MyWebSite.Model.DataModel;
using MyWebSite.Model.Interfaces;
using System.Threading.Tasks;

namespace MyWebSite.Controllers
{
    public class CityController: Controller
    {
        ICityProvider cityProvider;
        public CityController(ICityProvider cityProvider)
        {
            this.cityProvider = cityProvider;
        }

        public async Task<IActionResult> ListCities()
        {
            var result = await cityProvider.GetCities();
            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            await cityProvider.DeleteCity(id);
            return Redirect("/City/ListCities");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Edit", new City());
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var result = await cityProvider.GetCity(id);
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(City city)
        {
            await cityProvider.SaveCity(city);
            return Redirect("/City/ListCities");
        }
    }
}
