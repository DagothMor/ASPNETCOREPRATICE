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
	[ApiExplorerSettings(GroupName = SwaggerDocParts.Notebooks)]
	public class NotebookController : ControllerBase
	{
		private readonly ILogger<NotebookController> _logger;
		private readonly INotebookService _notebookService;

		/// <summary>
		/// Initialize an instant <see cref="NotebookController"/>
		/// </summary>
		/// <param name="notebookService">Service notebook</param>
		/// <param name="logger">Logger</param>
		public NotebookController(INotebookService notebookService, ILogger<NotebookController> logger)
		{
			_logger = logger;
			_notebookService = notebookService;
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
			var response = _notebookService.Get();
			return Ok(response);
		}
	}
}
