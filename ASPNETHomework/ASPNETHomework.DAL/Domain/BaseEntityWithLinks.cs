using System;
using System.Collections.Generic;
using System.Text;

namespace ASPNETHomework.DAL.Domain
{
	/// <summary>
	/// Base class for weak entities.
	/// </summary>
	/// <typeparam name="TEntity1">Related entity - 1.</typeparam>
	/// <typeparam name="TEntity2">Related entity - 2.</typeparam>
	public abstract class BaseEntityWithLinks<TEntity1, TEntity2>
		where TEntity1 : BaseEntity
		where TEntity2 : BaseEntity
	{
		/// <summary>
		/// Identification first related entity.
		/// </summary>
		public int Entity1Id { get; set; }

		/// <summary>
		/// Related entity - 1.
		/// </summary>
		public TEntity1 Entity1 { get; set; }

		/// <summary>
		/// Identification second related entity.
		/// </summary>
		public int Entity2Id { get; set; }

		/// <summary>
		/// Related entity - 2.
		/// </summary>
		public TEntity2 Entity2 { get; set; }
	}
}
