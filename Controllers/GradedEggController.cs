using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Eggcellent.Models;

namespace Eggcellent.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GradedEggController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<GradedEgg> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new GradedEgg
            {
                Date = DateTime.Now.AddDays(index),
                EggSize = Models.Enums.EggSize.Jumbo,
                Quantity = 22,
                Id = new Guid(),
            })
            .ToArray();
        }
    }
}
