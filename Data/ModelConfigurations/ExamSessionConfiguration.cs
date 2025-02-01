using System;
using Microsoft.EntityFrameworkCore;
using models.Model;

namespace data.ModelConfigurations;

public class ExamSessionConfiguration : IEntityTypeConfiguration<ExamSession>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ExamSession> builder)
    {
        builder.HasKey(es => es.Id);
        builder.Property(es => es.StartDate).IsRequired();
        builder.HasIndex(es => es.Id).IsUnique();
        builder.HasOne(es => es.Exam).WithMany(e => e.ExamSessions).HasForeignKey(es => es.ExamId);
        builder.HasOne(es => es.Student).WithMany(s => s.ExamSessions).HasForeignKey(es => es.StudentId);
    }
}
