using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Questions;

namespace UICMA.Service.ClaimServices
{
 public interface IQuestionsService
    {

        Question AddandUpdateQuestion(Question question);
        IEnumerable<Question> GetQuestionAll();
        Question GetQuestionbyID(int Id);

    }
}
