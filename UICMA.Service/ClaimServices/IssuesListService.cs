using System;
using System.Collections.Generic;
using System.Text;
using UICMA.Domain.Entities.Issues_List;
using UICMA.Repository.ClaimRepository;

namespace UICMA.Service.ClaimServices
{
  public  class IssuesListService: IIssuesListService
    {
        private IIssuesListRepository _issuesList;

        public IssuesListService(IIssuesListRepository _issuesList)
        {
            this._issuesList = _issuesList;

        }


        //Add and Update IssuesList

        public IssuesList AddandUpdateIssuesList(IssuesList issuesList)
        {
            IssuesList issuesLists = new IssuesList();


            if (issuesList.Id == 0)
            {
                issuesLists = _issuesList.AddData(issuesList);
            }
            else
            {
                issuesLists = _issuesList.UpdateData(issuesList);
            }




            return issuesLists;

        }

        //Get IssuesList All


        public IEnumerable<IssuesList> GetIssuesListAll()
        {

            return _issuesList.GetAll();

        }
        //Get IssuesList By IssuesList_Id

        public IssuesList GetIssuesListbyID(int Id)
        {

            return _issuesList.GetSingle(Id);

        }
    }
}
