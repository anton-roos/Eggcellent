using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Eggcellent.Models;

namespace Eggcellent.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StagedEggController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<UngradedEgg> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new UngradedEgg
            {
                Date = DateTime.Now.AddDays(index),
                Quantity = 32,
                Id = new Guid(),
            })
            .ToArray();
        }
    }
}
