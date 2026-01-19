using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsability.WorkFlow
{
    public class CEOApproveHandler: ApproveHandler
    {
        public override void process(VacationRequest Request)
        {
            if (Request.Employee.JobTitle == JobTitle.CTO)
            {
                Console.WriteLine("This Request has been Created From CEO");
            }
            else
            {
                CallNext(Request);
            }

        }
    }
}
