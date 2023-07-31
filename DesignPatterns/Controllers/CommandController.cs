using System;
using Microsoft.AspNetCore.Mvc;
using DesignPatterns.Patterns.Behavioral.Command;

namespace DesignPatterns.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class CommandController : ControllerBase
    {
        private readonly ILogger _logger;
        public CommandController(ILogger<CommandController> logger)
		{
            _logger = logger;
        }

        /// <summary>
        /// Post 2 strings to be executed by command
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        ///
        ///     Post /example
        ///     "payload"
        ///
        /// </remarks>
        /// <response code="201">Returns km flew</response>
        /// <response code="400">Bad Input</response>
        /// <response code="500">unexcepted internal error</response>
        [HttpPost("example")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<int> PostString([FromBody] string payload)
        {
            try
            {
                var invoker = new Invoker();

                // on start let the command deal with how to use the receiver on execute to use the receiver's methods
                invoker.SetOnStart(new ComplexCommand(new Receiver(), payload, payload));
                invoker.SetOnFinish(new SimpleCommand(payload));
                invoker.DoSomething();
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return StatusCode(500);
            }
        }

    }
}

