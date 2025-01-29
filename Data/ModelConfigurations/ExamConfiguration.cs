using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using models.Model;

namespace data.ModelConfigurations;

public class ExamConfiguration : IEntityTypeConfiguration<Exam>
{
    public void Configure(EntityTypeBuilder<Exam> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Title).IsRequired().HasMaxLength(50);
        builder.Property(e => e.Date).IsRequired();

        builder.HasIndex(e => e.Id).IsUnique();

        builder.HasOne(e => e.Course).
            WithOne(c => c.Exam).
            HasForeignKey<Exam>(e => e.CourseId);
    }
}
