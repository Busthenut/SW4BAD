using Microsoft.AspNetCore.Mvc;
using WebAPI.Model;
using System.Collections.Generic;

namespace WebAPI.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class ExperienceController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Experience> Get()
        {
            var experiences = new List<Experience>
            {
                new Experience("Luqman Nur", "C-tier worker", 10),
                new Experience("Ali Al-issa", "A-tier worker", 30),
                new Experience("Nikolai Nguyen", "SS-tier worker", 100)
            };

            return experiences;
        }
    }
}