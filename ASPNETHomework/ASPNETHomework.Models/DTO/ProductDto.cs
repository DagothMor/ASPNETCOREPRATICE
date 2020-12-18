using ASPNETHomework.DAL.Domain;

namespace ASPNETHomework.Models.DTO
{
	/// <summary>
	/// Product Dto.
	/// </summary>
	public class ProductDto : BaseDto
	{
		/// <summary>
		/// Name of product.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Description.
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// Price.
		/// </summary>
		public double Price { get; set; }
		/// <summary>
		/// Provider.
		/// </summary>
		public ProviderDto Provider { get; set; }
		/// <summary>
		/// Provider id.
		/// </summary>
		public int ProviderId { get; set; }
	}
}
