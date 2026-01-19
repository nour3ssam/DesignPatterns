using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsability.WorkFlow
{
    public abstract class ApproveHandler : IApproveHandler
    {
        private IApproveHandler _next;

        public abstract void process(VacationRequest Request);

        public void SetNext(IApproveHandler next)
        {
            _next = next;
        }
        public void CallNext(VacationRequest request) {
            if (_next != null) {
                _next.process(request);
            }
                
            
        }

    }
}
