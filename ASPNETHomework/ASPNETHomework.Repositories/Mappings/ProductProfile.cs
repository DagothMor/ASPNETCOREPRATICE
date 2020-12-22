using ASPNETHomework.DAL.Domain;
using ASPNETHomework.Models.DTO;
using AutoMapper;

namespace ASPNETHomework.Repositories.Mappings
{
	/// <summary>
	/// Product profile.
	/// </summary>
	public class ProductProfile : Profile	
	{
		/// <summary>
		/// Initialize an instance <see cref="ProductProfile"/>
		/// </summary>
		public ProductProfile()
		{
			CreateMap<Product, ProductDto>().ReverseMap();
		}
	}
}
