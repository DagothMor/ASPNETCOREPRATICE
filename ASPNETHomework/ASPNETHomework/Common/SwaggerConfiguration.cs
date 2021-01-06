using Microsoft.Extensions.DependencyInjection;
using NSwag;
using NSwag.Generation.Processors.Security;

namespace ASPNETHomework.Common
{
	/// <summary>
	/// Extension for Swagger configuration
	/// </summary>
	public static class SwaggerConfiguration
	{
		/// <summary>
		/// Configure Swagger documents.
		/// </summary>
		/// <param name="services">Service collection for Dependency Injection.</param>
		public static void ConfigureSwagger(this IServiceCollection services)
		{
			services.AddSwaggerDocument(c =>
				{
					c.Title = "Customer";
					c.DocumentName = SwaggerDocParts.Customer;
					c.ApiGroupNames = new[] { SwaggerDocParts.Customer };
				})
				.AddSwaggerDocument(c =>
				{
					c.Title = "Order";
					c.DocumentName = SwaggerDocParts.Order;
					c.ApiGroupNames = new[] { SwaggerDocParts.Order };
				}).AddSwaggerDocument(c =>
				{
					c.Title = "Product";
					c.DocumentName = SwaggerDocParts.Product;
					c.ApiGroupNames = new[] { SwaggerDocParts.Product };
				}).AddSwaggerDocument(c =>
				{
					c.Title = "Account";
					c.DocumentName = SwaggerDocParts.Account;
					c.ApiGroupNames = new[] { SwaggerDocParts.Account };
					c.DocumentProcessors.Add(new SecurityDefinitionAppender("JWT Token",
						new OpenApiSecurityScheme
						{
							Type = OpenApiSecuritySchemeType.ApiKey,
							Name = "Authorization",
							Description = "Copy 'Bearer ' + valid JWT token into field",
							In = OpenApiSecurityApiKeyLocation.Header,

						}));

				});
		}
	}
}