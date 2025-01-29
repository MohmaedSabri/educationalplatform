using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using models.Model;

namespace data.ModelConfigurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.Property(s => s.FName).IsRequired().HasMaxLength(50);
        builder.Property(s => s.SName).IsRequired().HasMaxLength(50);
        builder.Property(s => s.TName).IsRequired().HasMaxLength(50);
        builder.Property(s => s.year).IsRequired().HasMaxLength(50);
        builder.Property(s => s.ParentPhone).IsRequired().HasMaxLength(50);

        builder.HasIndex(s => s.Id).IsUnique();
        
      
    }
}
