using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using models.Model;

namespace data.ModelConfigurations;

public class CouponConfiguration : IEntityTypeConfiguration<Coupon>
{
    public void Configure(EntityTypeBuilder<Coupon> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Code).IsRequired().HasMaxLength(50);
        builder.Property(c => c.Discount).IsRequired();

        builder.Property(e=>e.StartDate).IsRequired();
        builder.Property(e=>e.EndDate).IsRequired();

        builder.HasOne(e => e.Course).WithMany(e => e.Coupons)
        .HasForeignKey(e => e.CourseId);

    }
}

