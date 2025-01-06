using Microsoft.AspNetCore.Mvc;
using NZWalks.UI.Models;
using NZWalks.UI.Models.DTO;

namespace NZWalks.UI.Controllers
{
    public class RegionsController : Controller
    {
        private readonly IHttpClientFactory httpClientFactory;

        public RegionsController(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<RegionDto> response = new List<RegionDto>();
            try
            {
                //Get All Regions from Web API
                var client = httpClientFactory.CreateClient();
                var httpResponseMessage = await client.GetAsync("https://localhost:7277/api/regions");
                httpResponseMessage.EnsureSuccessStatusCode();

                response.AddRange(await httpResponseMessage.Content.ReadFromJsonAsync<IEnumerable<RegionDto>>());
            }
            catch (Exception ex)
            {
                //log the exception
                throw;
            }

            return View(response);
        }

        //returns page to add a new region
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddRegionViewModel model)
        {
            try
            {
                //Add Region to Web API
                var client = httpClientFactory.CreateClient();
                var httpResponseMessage = await client.PostAsJsonAsync("https://localhost:7277/api/regions", model);
                httpResponseMessage.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                //log the exception
                throw;
            }
            return RedirectToAction("Index", "Regions");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var client = httpClientFactory.CreateClient();
            var response = await client.GetFromJsonAsync<RegionDto>($"https://localhost:7277/api/regions/{id.ToString()}");

            if (response is not null)
            {
                return View(response);
            }

            return View(null);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(RegionDto request)
        {
            try
            {
                //Edit Region in Web API
                var client = httpClientFactory.CreateClient();
                var httpResponseMessage = await client.PutAsJsonAsync($"https://localhost:7277/api/regions/{request.Id}", request);
                httpResponseMessage.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                //log the exception
                throw;
            }
            return RedirectToAction("Index", "Regions");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                //Delete Region in Web API
                var client = httpClientFactory.CreateClient();
                var httpResponseMessage = await client.DeleteAsync($"https://localhost:7277/api/regions/{id}");
                httpResponseMessage.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                //log the exception
                throw;
            }
            return RedirectToAction("Index", "Regions");
        }
    }
}
