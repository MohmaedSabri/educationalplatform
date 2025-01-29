using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using models.Model;

namespace data.ModelConfigurations;

public class QuestionConfiguration : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.HasKey(q => q.Id);
        builder.Property(q => q.QuestionDescription).IsRequired();
        builder.Property(q => q.Answer).IsRequired();

        builder.HasOne(e => e.Exam).
            WithMany(e => e.Questions).
            HasForeignKey(q => q.ExamId);


    }
}
