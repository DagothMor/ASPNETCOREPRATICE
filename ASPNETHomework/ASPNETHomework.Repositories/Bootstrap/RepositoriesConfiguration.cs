
using ASPNETHomework.DAL;
using ASPNETHomework.Repositories.Interfaces;
using ASPNETHomework.Repositories.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ASPNETHomework.Repositories.Bootstrap
{
	/// <summary>
	/// Extension for repositories configuration 
	/// </summary>
	public static class RepositoriesConfiguration
	{
		/// <summary>
		/// Configure repositories
		/// </summary>
		/// <param name="services">service collection from startup</param>
		public static void ConfigureRepositories(this IServiceCollection services)
		{
			services.AddTransient<IOrderRepository, OrderRepository>();
			services.AddTransient<ICustomerRepository,CustomerRepository>();
			services.AddTransient<IProductRepository, ProductRepository>();
			services.AddTransient<UnitOfWork,UnitOfWork>();// я как понимаю нужно его создать и через ioc пробрасывать по контроллерам.
		}
	}
}
