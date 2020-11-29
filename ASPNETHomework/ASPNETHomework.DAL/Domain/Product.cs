﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ASPNETHomework.DAL.Domain
{
	/// <summary>
	/// Product in the store.
	/// </summary>
	public class Product : BaseEntity
	{
		/// <summary>
		/// Category of product.
		/// </summary>
		public Category Category { get; set; }
		/// <summary>
		/// Name of product.
		/// </summary>
		[StringLength(25)]
		public string Name { get; set; }
		/// <summary>
		/// Description.
		/// </summary>
		[StringLength(3000)]
		public string Description { get; set; }
		/// <summary>
		/// Price.
		/// </summary>
		[Required]
		public double Price { get; set; }
	}
}
