using System.Collections.Generic;
using ASPNETHomework.Common;
using ASPNETHomework.Models.DTO;
using ASPNETHomework.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ASPNETHomework.Controllers
{
	/// <summary>
	/// Controller to working with "Notebook" data.
	/// </summary>
	[ApiController]
	[Route("[controller]")]
	[ApiExplorerSettings(GroupName = SwaggerDocParts.Test)]
	public class TestController : ControllerBase
	{
		private readonly ILogger<NotebookController> _logger;
		private readonly ITestService _testService;

		/// <summary>
		/// Initialize an instant <see cref="NotebookController"/>
		/// </summary>
		/// <param name="notebookService">Service notebook</param>
		/// <param name="logger">Logger</param>
		public TestController(ITestService testService, ILogger<NotebookController> logger)
		{
			_logger = logger;
			_testService = testService;
		}

		/// <summary>
		/// Getting a list of notebooks in mock format.
		/// </summary>
		/// <returns>Entity collection of Notebook</returns>
		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<NotebookDto>))]
		public IActionResult Get()
		{
			_logger.LogInformation(("Notebooks/Get was requested"));
			var response = _testService.Get();
			return Ok(response);
		}
	}
}