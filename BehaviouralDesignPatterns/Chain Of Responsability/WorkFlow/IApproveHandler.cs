using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsability.WorkFlow
{
    public interface IApproveHandler
    {
        void SetNext(IApproveHandler next);
        void process(VacationRequest Request);

    }
}
