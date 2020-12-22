using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ASPNETHomework.DAL.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASPNETHomework.DAL.Fluent
{
	/// <summary>
	/// Extension method for FluentApi Configurations.
	/// </summary>
	public static class FluentExtentions
	{
		/// <summary>
		/// Configuration for weak entities.
		/// </summary>
		/// <typeparam name="T">Weak entity.</typeparam>
		/// <typeparam name="T1">entity-link 1.</typeparam>
		/// <typeparam name="T2">entity-link 2.</typeparam>
		/// <param name="builder">entity builder.</param>
		/// <param name="withMany1">Tree for connection 1.</param>
		/// <param name="withMany2">Tree for connection 2.</param>
		public static void BaseEntityWithLinksConfig<T, T1, T2>(this EntityTypeBuilder<T> builder,
			Expression<Func<T1, IEnumerable<T>>> withMany1 = default,
			Expression<Func<T2, IEnumerable<T>>> withMany2 = default)
			where T : BaseEntityWithLinks<T1, T2>
			where T1 : BaseEntity
			where T2 : BaseEntity
		{
			builder.ToTable($"{typeof(T).Name}s");

			builder.HasKey(e => new { e.Entity1Id, e.Entity2Id });

			builder.Property(e => e.Entity1Id)
				.HasColumnName($"{typeof(T1).Name}Id");
			builder.Property(e => e.Entity2Id)
				.HasColumnName($"{typeof(T2).Name}Id");

			builder.HasOne(e => e.Entity1)
				.WithMany(withMany1)
				.HasForeignKey(e => e.Entity1Id);

			builder.HasOne(e => e.Entity2)
				.WithMany(withMany2)
				.HasForeignKey(e => e.Entity2Id);
		}
	}
}
