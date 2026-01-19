using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsability.WorkFlow
{
    public class ValidationApproveHandler : ApproveHandler
    {
        public override void process(VacationRequest Request)
        {
            if (Request.TotalDays < 1)
            {
                Console.WriteLine("Request has been rejected because is not valid TotalDays");

            }
            else
            {
                CallNext(Request);
            }
        }
    }
}
