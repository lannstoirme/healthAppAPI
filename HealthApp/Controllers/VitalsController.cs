using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HealthApp.Services;
using HealthApp.Models;

namespace HealthApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VitalsController : ControllerBase
    {
        private readonly VitalService _vitalService;

        public VitalsController(VitalService vitalService)
        {
            _vitalService = vitalService;
        }

        [HttpGet]
        public ActionResult<List<Vitals>> Get() =>
            _vitalService.Get();


        [HttpGet("{Id}", Name = "GetVitals")]
        public ActionResult<Vitals> Get(string id)
        {
            var vitals = _vitalService.Get(id);

            if (vitals == null)
            {
                return NotFound();
            }

            return vitals;
        }

        [HttpPost]
        public ActionResult<Vitals> Create(Vitals vitals)
        {
            _vitalService.Create(vitals);

            return CreatedAtRoute("GetVitals", new { id = vitals.Id.ToString() }, vitals);
        }

        [HttpPut("{Id}")]
        public IActionResult Update(string id, Vitals vitalsIn)
        {
            var vitals = _vitalService.Get(id);

            if (vitals == null)
            {
                return NotFound();
            }

            _vitalService.Update(id, vitalsIn);

            return NoContent();
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(string id)
        {
            var vitals = _vitalService.Get(id);

            if (vitals == null)
            {
                return NotFound();
            }

            _vitalService.Remove(vitals.Id);

            return NoContent();
        }

    }
}
