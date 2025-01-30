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
                new Experience("Experience 1", "Description 1", 100),
                new Experience("Experience 2", "Description 2", 200),
                new Experience("Experience 3", "Description 3", 300)
            };

            return experiences;
        }
    }
}