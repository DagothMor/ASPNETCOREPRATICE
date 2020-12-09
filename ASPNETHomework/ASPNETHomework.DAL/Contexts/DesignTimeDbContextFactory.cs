using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ASPNETHomework.DAL.Contexts
{
	/// <summary>
	/// Фабрика для создания нового контекста в процессе миграций.
	/// </summary>
	internal sealed class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AspNetHomeworkContext>
	{
		/// <summary>
		/// Создание контекста для миграций.
		/// </summary>
		/// <param name="args">Строковые аршументы миграций.</param>
		/// <returns>Контекст.</returns>
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
