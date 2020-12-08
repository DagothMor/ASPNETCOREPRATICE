using ASPNETHomework.Models.DTO;
using ASPNETHomework.Models.Requests.CustomerFolder;
using ASPNETHomework.Models.Response.CustomerFolder;
using AutoMapper;

namespace ASPNETHomework.Controllers.Mappings
{
	/// <summary>
	/// Mapping for requests and responds Customer entity controller.
	/// </summary>
	public class CustomerProfile : Profile
	{
		/// <summary>
		/// initialize an instance <inheritdoc cref="CustomerProfile"/>
		/// </summary>
		public CustomerProfile()
		{
			CreateMap<CreateCustomerRequest, CustomerDto>();
			CreateMap<UpdateCustomerRequest, CustomerDto>();
			CreateMap<CustomerDto, CustomerResponse>();
		}
	}
}
