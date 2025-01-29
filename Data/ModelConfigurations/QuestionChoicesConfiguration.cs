using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using models.Model;

namespace data.ModelConfigurations;

public class QuestionChoicesConfiguration : IEntityTypeConfiguration<QuestionChoices>
{
    public void Configure(EntityTypeBuilder<QuestionChoices> builder)
    {   
        builder.HasKey(qc => qc.Id);
        builder.Property(qc => qc.Choice).IsRequired();


        builder.HasIndex(qc => qc.Id).IsUnique();

        builder.HasOne(qc => qc.Question).
            WithMany(q => q.QuestionChoices).
            HasForeignKey(qc => qc.QuestionId);

    }
}
