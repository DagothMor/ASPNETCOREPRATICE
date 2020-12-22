using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ASPNETHomework.DAL.Contexts
{
	/// <summary>
	/// Factory for creating new context in migration process.
	/// </summary>
	internal sealed class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AspNetHomeworkContext> // never called???
	{
		/// <summary>
		/// Creating context for migration.
		/// </summary>
		/// <param name="args">migration string arguments.</param>
		/// <returns>Context.</returns>
		public AspNetHomeworkContext CreateDbContext(string[] args)
		{	
			var configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json", false, true)
				.AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json",
					true, true)
				.AddEnvironmentVariables()
				.Build();

			var connectionString = configuration.GetConnectionString(nameof(AspNetHomeworkContext));

			var builder = new DbContextOptionsBuilder<AspNetHomeworkContext>()
				.UseNpgsql(connectionString, __options =>
				{
					__options.MigrationsAssembly(typeof(AspNetHomeworkContext).Assembly.FullName);
				});

			var context = new AspNetHomeworkContext(builder.Options);

			return context;
		}
	}
}
