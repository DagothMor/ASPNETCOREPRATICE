using ASPNETHomework.Models.DTO;
using ASPNETHomework.Models.Requests.ProductFolder;
using ASPNETHomework.Models.Response.ProductFolder;
using AutoMapper;

namespace ASPNETHomework.Controllers.Mappings
{
	/// <summary>
	/// Mapping for requests and responds Product entity controller.
	/// </summary>
	public class ProductProfile : Profile
	{
		/// <summary>
		/// initialize an instance <inheritdoc cref="ProductProfile"/>
		/// </summary>
		public ProductProfile()
		{
			CreateMap<CreateProductRequest, ProductDto>();
			CreateMap<UpdateProductRequest, ProductDto>();
			CreateMap<ProductDto, ProductResponse>().ForMember(x => x.ProviderName, y => y.MapFrom(src => src.Provider.Name))
				.ForMember(x => x.ProviderPhone, y => y.MapFrom(src => src.Provider.Phone));
		}
	}
}
