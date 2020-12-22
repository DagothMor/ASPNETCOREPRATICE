using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ASPNETHomework.Common;
using ASPNETHomework.Models.DTO;
using ASPNETHomework.Models.Requests.ProductFolder;
using ASPNETHomework.Models.Response.ProductFolder;
using ASPNETHomework.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ASPNETHomework.Controllers
{
	/// <summary>
	/// Controller for work with data of Product.
	/// </summary>
	[ApiController]
	[Route("[controller]")]
	[ApiExplorerSettings(GroupName = SwaggerDocParts.Product)]
	public class ProductController : ControllerBase
	{
		private readonly ILogger<ProductController> _logger;
		private readonly IProductService _productService;
		private readonly IMapper _mapper;

		/// <summary>
		/// Initialize an instance <see cref="ProductController"/>
		/// </summary>
		/// <param name="ProductService">Product Service.</param>
		/// <param name="logger">Logger.</param>
		/// <param name="mapper">Mapper.</param>
		public ProductController(IProductService productService, ILogger<ProductController> logger, IMapper mapper)
		{
			_productService = productService;
			_logger = logger;
			_mapper = mapper;
		}

		/// <summary>
		/// Get Products.
		/// </summary>
		/// <returns>Entity collection of Products.</returns>
		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ProductResponse>))]
		public async Task<IActionResult> GetAsync(CancellationToken cancellationToken)
		{
			_logger.LogInformation("Product/Get was requested.");
			var response = await _productService.GetAsync(cancellationToken);
			return Ok(_mapper.Map<IEnumerable<ProductResponse>>(response));
		}

		/// <summary>
		/// Get Product by id.
		/// </summary>
		/// <returns>Entity Product.</returns>
		[HttpGet("{id}")]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductResponse))]
		public async Task<IActionResult> GetByIdAsync(int id, CancellationToken cancellationToken)
		{
			_logger.LogInformation("Product/GetById was requested.");
			var response = await _productService.GetAsync(id, cancellationToken);
			return Ok(_mapper.Map<ProductResponse>(response));
		}

		/// <summary>
		/// Add entity Product.
		/// </summary>
		/// <returns>Entity Product.</returns>
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductResponse))]
		public async Task<IActionResult> PostAsync(CreateProductRequest request, CancellationToken cancellationToken)
		{
			_logger.LogInformation("Product/Post was requested.");
			var response = await _productService.CreateAsync(_mapper.Map<ProductDto>(request));
			return Ok(_mapper.Map<ProductResponse>(response));
		}

		/// <summary>
		/// Change entity Product.
		/// </summary>
		/// <returns>Entity Product.</returns>
		[HttpPut]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductResponse))]
		public async Task<IActionResult> PutAsync(UpdateProductRequest request, CancellationToken cancellationToken)
		{
			_logger.LogInformation("Product/Put was requested.");
			var response = await _productService.UpdateAsync(_mapper.Map<ProductDto>(request));
			return Ok(_mapper.Map<ProductResponse>(response));
		}

		/// <summary>
		/// Delete Product entities.
		/// </summary>
		[HttpDelete]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		public async Task<IActionResult> DeleteAsync(CancellationToken cancellationToken, params int[] ids)
		{
			_logger.LogInformation("Product/Delete was requested.");
			await _productService.DeleteAsync(ids);
			return NoContent();
		}
	}
}
