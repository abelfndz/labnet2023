using Lab.Net.EF.MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Lab.Net.EF.MVC.Controllers
{
    public class RickAndMortyController : Controller
    {
        private readonly HttpClient _httpClient;
        
        public RickAndMortyController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://rickandmortyapi.com/api/character");
        }
        public async Task<ActionResult> Index()
        {
            HttpResponseMessage response = await _httpClient.GetAsync(_httpClient.BaseAddress);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<ResponseRickAndMorty>(json);
                return View(data.results);
            }
            else
            {
                return View("Error");
            }
        }
    }
}