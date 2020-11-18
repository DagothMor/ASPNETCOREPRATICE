using ASPNETHomework.Services.Interfaces;
using ASPNETHomework.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ASPNETHomework.Services.Bootstrap
{
	public static class ServicesConfiguration
	{
		public static void ConfigureServices(this IServiceCollection services)
		{
			services.AddTransient<INotebookService, NotebookService>();
		}
	}
}
