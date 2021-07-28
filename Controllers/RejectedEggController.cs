using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Eggcellent.Models;

namespace Eggcellent.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RejectedEggController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<RejectedEgg> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new RejectedEgg
            {
                Date = DateTime.Now.AddDays(index),
                RejectionReason = Models.Enums.RejectionReason.Cracked,
                Quantity = 22,
                Id = new Guid(),
            })
            .ToArray();
        }
    }
}
