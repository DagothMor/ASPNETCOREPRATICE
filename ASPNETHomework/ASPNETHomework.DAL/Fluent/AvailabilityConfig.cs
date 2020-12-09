using System;
using System.Collections.Generic;
using System.Text;
using ASPNETHomework.DAL.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASPNETHomework.DAL.Fluent
{
	/// <summary>
	/// Migration Configuration for <see cref="Availability"/>.
	/// </summary>
	public class AvailabilityConfig : IEntityTypeConfiguration<Availability>
	{
		/// <summary>
		/// Entity configuration <see cref="Availability"/>.
		/// </summary>
		/// <param name="builder"></param>
		public void Configure(EntityTypeBuilder<Availability> builder)
		{
			builder.BaseEntityWithLinksConfig<Availability, Product, Shop>(
				e => e.Availabilities);

			builder.Property(x => x.Count)
				.IsRequired();

			builder.ToTable("Availabilities");
		}
	}
}
