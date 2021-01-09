using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TravelAssist.BLL.Contracts;
using TravelAssist.Model.Models;
using TravelAssist.Models.ViewModel;

namespace TravelAssist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TouristPlaceController : ControllerBase
    {
        private readonly ITouristPlaceManager touristPlaceManager;
        private readonly IHostingEnvironment environment;

        // GET: TouristPlaceController
        public TouristPlaceController(ITouristPlaceManager touristPlaceManager, IHostingEnvironment _environment)
        {
            this.touristPlaceManager = touristPlaceManager;
            environment = _environment;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var places = touristPlaceManager.GetAll().OrderByDescending(c=> c.Id);
            return Ok(places);
        }

        // POST api/TouristPlace/Post
        [HttpPost]
        [Route("Post")]
        public async Task<IActionResult> Create(TouristPlace touristPlace)
        {
            try
            {
                touristPlaceManager.Add(touristPlace);
                return Ok(touristPlace);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
