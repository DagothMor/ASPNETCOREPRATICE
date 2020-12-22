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
		public static void ConfigureDb(
			this IServiceCollection services,
					IConfiguration configuration)
		{
			var connectionString = configuration["Movies:ConnectionString"];
			services.AddDbContext<AspNetHomeworkContext>(
				options => options.UseNpgsql(
				connectionString,
				builder => builder.MigrationsAssembly(typeof(AspNetHomeworkContext).Assembly.FullName)
				));
		}
	}
}
