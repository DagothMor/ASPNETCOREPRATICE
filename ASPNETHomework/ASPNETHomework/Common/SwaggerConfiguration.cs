﻿using Microsoft.Extensions.DependencyInjection;

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
					c.Title = "Test";
					c.DocumentName = SwaggerDocParts.Test;
					c.ApiGroupNames = new[] { SwaggerDocParts.Test };
				})
				.AddSwaggerDocument(c =>
				{
					c.Title = "Version 1";
					c.DocumentName = "v1";
					c.ApiGroupNames = new[] { "v1" };
				});
		}
	}
}