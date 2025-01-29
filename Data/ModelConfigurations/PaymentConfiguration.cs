using System;
using Microsoft.EntityFrameworkCore;
using models.Model;

namespace data.ModelConfigurations;

public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Payment> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Amount).IsRequired();
        builder.Property(p => p.Date).IsRequired();
        builder.Property(p => p.Status).IsRequired();

        builder.HasIndex(p => p.Id).IsUnique();

        builder.HasOne(p => p.Course).
            WithMany(c => c.Payments).
            HasForeignKey(p => p.CourseId);

        builder.HasOne(p => p.Student).
            WithMany(s => s.Payments).
            HasForeignKey(p => p.StudentId);

    }
}
