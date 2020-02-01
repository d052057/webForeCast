using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAngular.Models;

namespace WebAngular.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class WeatherForecastsController : ControllerBase
    {
        private readonly WebAngularDBContext _context;

        public WeatherForecastsController(WebAngularDBContext context)
        {
            _context = context;
        }

        // GET: api/WeatherForecasts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WeatherForecast>>> GetWeatherForecast()
        {
            return await _context.WeatherForecast
                .Include(p => p.ForeCastSummaryRecord)
                .ToListAsync();
        }

   
    }
}
