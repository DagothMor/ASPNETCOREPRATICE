using System;
using System.Reflection;
using ASPNETHomework.Common;
using ASPNETHomework.Controllers;
using ASPNETHomework.DAL.Bootstrap;
using ASPNETHomework.Repositories;
using ASPNETHomework.Repositories.Bootstrap;
using ASPNETHomework.Repositories.Repositories;
using ASPNETHomework.Services.Bootstrap;
using ASPNETHomework.Services.Services;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ASPNETHomework
{
	public class Startup
	{
		private string _moviesApiKey = null;
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			_moviesApiKey = Configuration["Movies:ServiceApiKey"];

			services.ConfigureDb(Configuration);
			services.ConfigureRepositories();
			services.AddControllers();
			services.ConfigureServices();
			services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
			services.ConfigureSwagger();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});

			app.UseCors();
			app.UseOpenApi();
			app.UseSwaggerUi3();
		}
	}
}
