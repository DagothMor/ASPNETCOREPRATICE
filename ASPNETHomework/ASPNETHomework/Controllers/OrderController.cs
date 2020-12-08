using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ASPNETHomework.Common;
using ASPNETHomework.Models.DTO;
using ASPNETHomework.Models.Requests.Order;
using ASPNETHomework.Models.Response.Order;
using ASPNETHomework.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ASPNETHomework.Controllers
{
	/// <summary>
	/// Controller for work with data of order.
	/// </summary>
	[ApiController]
	[Route("[controller]")]
	[ApiExplorerSettings(GroupName = SwaggerDocParts.Order)]
	public class OrderController : ControllerBase
	{
		private readonly ILogger<OrderController> _logger;
		private readonly IOrderService _testService;
		private readonly IMapper _mapper;

		/// <summary>
		/// Initialize an instance <see cref="OrderController"/>
		/// </summary>
		/// <param name="testService">Order Service.</param>
		/// <param name="logger">Logger.</param>
		/// <param name="mapper">Mapper.</param>
		public OrderController(IOrderService testService, ILogger<OrderController> logger, IMapper mapper)
		{
			_testService = testService;
			_logger = logger;
			_mapper = mapper;
		}

		/// <summary>
		/// Get orders.
		/// </summary>
		/// <returns>Entity collection of Orders.</returns>
		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<OrderResponse>))]
		public async Task<IActionResult> GetAsync(CancellationToken cancellationToken)
		{
			_logger.LogInformation("Order/Get was requested.");
			var response = await _testService.GetAsync(cancellationToken);
			return Ok(_mapper.Map<IEnumerable<OrderResponse>>(response));
		}

		/// <summary>
		/// Get order by id.
		/// </summary>
		/// <returns>Entity order.</returns>
		[HttpGet("{id}")]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(OrderResponse))]
		public async Task<IActionResult> GetByIdAsync(int id, CancellationToken cancellationToken)
		{
			_logger.LogInformation("Order/GetById was requested.");
			var response = await _testService.GetAsync(id, cancellationToken);
			return Ok(_mapper.Map<OrderResponse>(response));
		}

		/// <summary>
		/// Add entity order.
		/// </summary>
		/// <returns>Entity order.</returns>
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(OrderResponse))]
		public async Task<IActionResult> PostAsync(CreateOrderRequest request, CancellationToken cancellationToken)
		{
			_logger.LogInformation("Order/Post was requested.");
			var response = await _testService.CreateAsync(_mapper.Map<OrderDto>(request));
			return Ok(_mapper.Map<OrderResponse>(response));
		}

		/// <summary>
		/// Change entity order.
		/// </summary>
		/// <returns>Entity order.</returns>
		[HttpPut]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(OrderResponse))]
		public async Task<IActionResult> PutAsync(UpdateOrderRequest request, CancellationToken cancellationToken)
		{
			_logger.LogInformation("Order/Put was requested.");
			var response = await _testService.UpdateAsync(_mapper.Map<OrderDto>(request));
			return Ok(_mapper.Map<OrderResponse>(response));
		}

		/// <summary>
		/// Delete order entities.
		/// </summary>
		[HttpDelete]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		public async Task<IActionResult> DeleteAsync(CancellationToken cancellationToken, params int[] ids)
		{
			_logger.LogInformation("Order/Delete was requested.");
			await _testService.DeleteAsync(ids);
			return NoContent();
		}
	}
}