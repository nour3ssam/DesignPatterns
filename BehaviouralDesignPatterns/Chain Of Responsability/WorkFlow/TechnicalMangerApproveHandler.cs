using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsability.WorkFlow
{
    public class TechnicalMangerApproveHandler : ApproveHandler
    {
        public override void process(VacationRequest Request)
        {
            if (Request.Employee.JobTitle == JobTitle.teamLeader || 
                Request.Employee.JobTitle == JobTitle.Developer && Request.TotalDays > 3)
            {
                Console.WriteLine("This Request has been Created From TechnicalManger");
            }
            else
            {
                CallNext(Request);
            }
                     
        }
    }
}
