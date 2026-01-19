using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsability
{
    public class VacationRequest
    {
        public Employee Employee { get; set; }
        public DateTime  StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TotalDays => EndDate.Subtract(StartDate).Days;
    }

}
