using Microsoft.AspNetCore.Mvc;
using DesignPatterns.Patterns.Creational.Builder;

namespace DesignPatterns.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class BuilderController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        /// <summary>
        /// New instance of controller is created for each api call.
        /// </summary>
        /// <param name="logger"></param>
        public BuilderController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Gets a F16 Fighter jet if the time is right
        /// </summary>
        /// <returns>F16 fighter jet</returns>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /f16
        ///
        /// </remarks>
        /// <response code="200">Returns a F16 fighter jet</response>
        /// <response code="404">No fighter jet found</response>
        /// <response code="500">unexcepted internal error</response>
        [HttpGet("f16")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<F16> GetF16()
        {
            try
            {
                if (DateTime.Now.Second > 40)
                    return NotFound();

                // for testability consider taking the director and builder using a factory dependency injection
                var builder = new F16Builder();
                var director = new AirCraftDirector(builder);
                director.Construct(false);
                return Ok((F16)builder.GetResult());
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return StatusCode(500);
            }
        }

        /// <summary>
        /// Gets a Boeing747
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /boeing747
        ///
        /// </remarks>
        /// <response code="200">Returns a Being747 jet</response>
        /// <response code="500">unexcepted internal error</response>
        [HttpGet("boeing747")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Boeing747> GetBoeing747()
        {
            try
            {
                var builder = new Boeing747Builder();
                var director = new AirCraftDirector(builder);
                director.Construct(false);
                return Ok((Boeing747)builder.GetResult());
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return StatusCode(500);
            }
        }

        /// <summary>
        /// Post a destination to be flew by a Boeing747
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        ///
        ///     Post /boeing747/fly
        ///     "New York"
        ///
        /// </remarks>
        /// <response code="201">Returns km flew</response>
        /// <response code="400">Bad Input</response>
        /// <response code="500">unexcepted internal error</response>
        [HttpPost("boeing747/fly")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<int> PostBoeing747FlyToDestination([FromBody] string destination)
        {
            try
            {
                var builder = new F16Builder();
                var director = new AirCraftDirector(builder);
                director.Construct(false);
                var boeing747 = builder.GetResult();
                return StatusCode(201, boeing747.Fly(destination));
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return StatusCode(500);
            }
        }
    }
}

