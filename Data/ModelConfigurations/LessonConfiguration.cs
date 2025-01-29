using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using models.Model;

namespace data.ModelConfigurations;

public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
{
    public void Configure(EntityTypeBuilder<Lesson> builder)
    {
        builder.HasKey(l => l.Id);
        builder.Property(l => l.Title).IsRequired().HasMaxLength(50);
        builder.Property(l => l.Description).IsRequired();
        builder.Property(l => l.VideoUrl).IsRequired();
        builder.Property(l => l.PdfUrl).IsRequired();
        builder.Property(l => l.IsFree).IsRequired();
        builder.Property(l => l.CreatedAt).HasDefaultValue(DateTime.Now);

        builder.HasIndex(l => l.Id).IsUnique();

        builder.HasOne(l => l.Course).
            WithMany(c => c.Lessons).
            HasForeignKey(l => l.CourseId);
    }
}
