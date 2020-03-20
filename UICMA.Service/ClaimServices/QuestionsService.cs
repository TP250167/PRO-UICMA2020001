using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Questions;
using UICMA.Repository.ClaimRepository;

namespace UICMA.Service.ClaimServices
{
   public class QuestionsService: IQuestionsService
    {
        private IQuestionsRepository _Question;

        public QuestionsService(IQuestionsRepository _Question)
        {
            this._Question = _Question;

        }


        //Add and Update Question

        public Question AddandUpdateQuestion(Question question)
        {
            Question questionAppeal = new Question();


            if (question.Id == 0)
            {
                questionAppeal = _Question.AddData(question);
            }
            else
            {
                questionAppeal = _Question.UpdateData(question);
            }
                                 
            return questionAppeal;

        }

        //Get Question All


        public IEnumerable<Question> GetQuestionAll()
        {

            return _Question.GetAll();

        }
        //Get Question By Question_Id

        public Question GetQuestionbyID(int Id)
        {

            return _Question.GetSingle(Id);

        }





    }
}
