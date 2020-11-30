using System;
using System.Collections.Generic;
using System.Text;
using ASPNETHomework.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ASPNETHomework.DAL.Bootstrap
{
	/// <summary>
	/// Database configuration.
	/// </summary>
	public static class DbConfigurations
	{
		public static void ConfigureDb(this
			IServiceCollection services,
			IConfiguration configuration)
		{
			services.AddDbContext<AspNetHomeworkContext>(
				options => options.UseNpgsql(
				configuration.GetConnectionString(nameof(AspNetHomeworkContext)),
				builder => builder.MigrationsAssembly(typeof(AspNetHomeworkContext).Assembly.FullName)
				));
		}
	}
}
