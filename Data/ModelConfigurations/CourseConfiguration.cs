using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using models.Model;

namespace data.ModelConfigurations.CourseConfiguration.cs;

public class CourseConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Title).IsRequired().HasMaxLength(50);
        builder.Property(c => c.Description).IsRequired();
        builder.Property(c => c.StartDate).IsRequired();
        builder.Property(c => c.EndDate).IsRequired();
        builder.Property(c => c.ImageUrl).IsRequired();
        builder.Property(c => c.Price).IsRequired().HasColumnType("decimal(18, 2)");
        builder.HasIndex(c => c.Id).IsUnique();
    }
}
