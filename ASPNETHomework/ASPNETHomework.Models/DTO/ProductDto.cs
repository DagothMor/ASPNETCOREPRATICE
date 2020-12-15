using ASPNETHomework.DAL.Domain;

namespace ASPNETHomework.Models.DTO
{
	/// <summary>
	/// Product Dto.
	/// </summary>
	public class ProductDto : BaseDto
	{
		/// <summary>
		/// Category of product.
		/// </summary>
		public Category Category { get; set; }
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
	}
}
