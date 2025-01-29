using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using models.Model;

namespace data.ModelConfigurations;

public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
{
    public void Configure(EntityTypeBuilder<Answer> builder)
    {
        builder.HasKey(a => a.Id);
        builder.Property(a => a.AnswerValue).IsRequired();

        builder.HasIndex(a => a.Id).IsUnique();

        builder.HasOne(a => a.Question)
            .WithMany(q => q.Answers).
            HasForeignKey(a => a.QuestionId);

        builder.HasOne(a => a.Student).
            WithMany(s => s.Answers).
            HasForeignKey(a => a.StudentId);



    }
}
