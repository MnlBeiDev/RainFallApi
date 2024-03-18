using EAR.Common.Models;
using EAR.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace RainFall.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RainFallForecastController : ControllerBase
    {
        private readonly ILogger<RainFallForecastController> _logger;
        private readonly IRainFallService _rainFallService;

        public RainFallForecastController(IRainFallService rainFallService , ILogger<RainFallForecastController> logger)
        {
            _rainFallService = rainFallService;
            _logger = logger;
        }

        [HttpGet("GetRainFallReadingByStationId")]
        public async Task<IActionResult> GetRainFallReadingByStationId(string id, string limit)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var rainFallReadings = await _rainFallService.GetRainFallReadingsByStoreId(id, limit);

                if(!rainFallReadings.Any())
                {
                    return StatusCode(404, "No readings found for the specified stationId");
                }

                return Ok(rainFallReadings);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);

                return StatusCode(500, "Internal server error");
            }            
        }
    }
}