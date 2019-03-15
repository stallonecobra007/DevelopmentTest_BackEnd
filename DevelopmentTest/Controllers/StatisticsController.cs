using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevelopmentTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly ICalculateStatistics _calculateStatistics;

        public StatisticsController(ICalculateStatistics calculateStatistics)
        {
            _calculateStatistics = calculateStatistics;
        }

        [HttpGet("{values}")]
        [Route("Mean")]
        public IActionResult GetMean([FromQuery]string values)
        {
            try
            {
                return Ok(_calculateStatistics.Mean(values));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpGet("{values}")]
        [Route("Median")]
        public IActionResult GetMedian([FromQuery]string values)
        {
            try
            {
                return Ok(_calculateStatistics.Median(values));

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpGet("{values}")]
        [Route("Mode")]
        public IActionResult GetMode([FromQuery]string values)
        {
            try
            {
                return Ok(_calculateStatistics.Mode(values));
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

    }
}