using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ASPNETHomework.Common;
using ASPNETHomework.Models.DTO;
using ASPNETHomework.Models.Requests.CustomerFolder;
using ASPNETHomework.Models.Response.CustomerFolder;
using ASPNETHomework.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ASPNETHomework.Controllers
{
	/// <summary>
	/// Controller for work with data of Customer.
	/// </summary>
	[ApiController]
	[Route("[controller]")]
	[ApiExplorerSettings(GroupName = SwaggerDocParts.Customer)]
	public class CustomerController : ControllerBase
	{
		private readonly ILogger<CustomerController> _logger;
		private readonly ICustomerService _customerService;
		private readonly IMapper _mapper;

		/// <summary>
		/// Initialize an instance <see cref="CustomerController"/>
		/// </summary>
		/// <param name="customerService">Customer Service.</param>
		/// <param name="logger">Logger.</param>
		/// <param name="mapper">Mapper.</param>
		public CustomerController(ICustomerService customerService, ILogger<CustomerController> logger, IMapper mapper)
		{
			_customerService = customerService;
			_logger = logger;
			_mapper = mapper;
		}

		/// <summary>
		/// Get Customers.
		/// </summary>
		/// <returns>Entity collection of Customers.</returns>
		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CustomerResponse>))]
		public async Task<IActionResult> GetAsync(CancellationToken cancellationToken)
		{
			_logger.LogInformation("Customer/Get was requested.");
			var response = await _customerService.GetAsync(cancellationToken);
			return Ok(_mapper.Map<IEnumerable<CustomerResponse>>(response));
		}

		/// <summary>
		/// Get Customer by id.
		/// </summary>
		/// <returns>Entity Customer.</returns>
		[HttpGet("{id}")]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerResponse))]
		public async Task<IActionResult> GetByIdAsync(int id, CancellationToken cancellationToken)
		{
			_logger.LogInformation("Customer/GetById was requested.");
			var response = await _customerService.GetAsync(id, cancellationToken);
			return Ok(_mapper.Map<CustomerResponse>(response));
		}

		/// <summary>
		/// Add entity Customer.
		/// </summary>
		/// <returns>Entity Customer.</returns>
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerResponse))]
		public async Task<IActionResult> PostAsync(CreateCustomerRequest request, CancellationToken cancellationToken)
		{
			_logger.LogInformation("Customer/Post was requested.");
			var response = await _customerService.CreateAsync(_mapper.Map<CustomerDto>(request));
			return Ok(_mapper.Map<CustomerResponse>(response));
		}

		/// <summary>
		/// Change entity Customer.
		/// </summary>
		/// <returns>Entity Customer.</returns>
		[HttpPut]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CustomerResponse))]
		public async Task<IActionResult> PutAsync(UpdateCustomerRequest request, CancellationToken cancellationToken)
		{
			_logger.LogInformation("Customer/Put was requested.");
			var response = await _customerService.UpdateAsync(_mapper.Map<CustomerDto>(request));
			return Ok(_mapper.Map<CustomerResponse>(response));
		}

		/// <summary>
		/// Delete Customer entities.
		/// </summary>
		[HttpDelete]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		public async Task<IActionResult> DeleteAsync(CancellationToken cancellationToken, params int[] ids)
		{
			_logger.LogInformation("Customer/Delete was requested.");
			await _customerService.DeleteAsync(ids);
			return NoContent();
		}
	}
}
