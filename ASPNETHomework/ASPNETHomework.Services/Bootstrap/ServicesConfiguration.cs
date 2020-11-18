using ASPNETHomework.Services.Interfaces;
using ASPNETHomework.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ASPNETHomework.Services.Bootstrap
{
	/// <summary>
	/// Extension methods for configuring services.
	/// </summary>
	public static class ServicesConfiguration
	{
		/// <summary>
		/// Service configuration.
		/// </summary>
		/// <param name="services">A collection of services from Startup.</param>
		public static void ConfigureServices(this IServiceCollection services)
		{
			services.AddTransient<INotebookService, NotebookService>();
		}
	}
}
