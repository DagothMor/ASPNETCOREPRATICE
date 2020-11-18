using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETHomework.Models.DTO;
using ASPNETHomework.Services.Interfaces;
using AspNetLection.Common.Swagger;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ASPNETHomework.Controllers
{
	[ApiController]
	[Route("[controller]")]
	[ApiExplorerSettings(GroupName = SwaggerDocParts.Notebooks)]
	public class NotebookController : ControllerBase
	{
		private readonly ILogger<NotebookController> _logger;
		private readonly INotebookService _notebookService;


		public NotebookController(INotebookService notebookService, ILogger<NotebookController> logger)
		{
			_logger = logger;
			_notebookService = notebookService;
		}

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
