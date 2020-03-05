using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Claim_Interview;
using UICMA.Domain.Entities.Questions;

namespace UICMA.Domain.Entities.QuestionsMap
{
    public class QuestionsMap
    {
        public QuestionsMap(EntityTypeBuilder<Question> builder)
        {
            builder.ToTable("QUESTIONS_TBL");
            builder.HasKey(s => s.Id).HasName("QUESTIONS_ID");
            builder.Property(s => s.CreatedOn).HasColumnName("CREATED_ON");
            builder.Property(s => s.ModifiedOn).HasDefaultValue(DateTime.Now).HasColumnName("MODIFIED_ON");
            builder.Property(s => s.ClaimId).HasColumnName("CLAIM_ID");
            builder.Property(s => s.FormId).HasColumnName("FORM_ID");
            builder.Property(s => s.CreatedBy).HasColumnName("CREATED_BY");
            builder.Property(s => s.ModifiedBy).HasColumnName("MODIFIED_BY");
            builder.Property(s => s.LAUSDQuestions).HasColumnName("LAUSD_QUESTIONS");
            builder.Property(s => s.LAUSDResponses).HasColumnName("LAUSD_RESPONSES");

            builder.HasOne<ClaimInterview>(s => s.claimInterview).WithMany(x => x.questions).HasForeignKey(s => s.FormId);

        }
    }
}
