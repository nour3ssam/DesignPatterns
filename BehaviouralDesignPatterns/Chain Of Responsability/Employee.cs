using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsability
{
    public class Employee
    {
        public int  id { get; set; }
        public string Name { get; set; }
        public JobTitle JobTitle { get; set; }
    }
   public enum JobTitle
    {
        Developer,
        teamLeader,
        TechnicalManger,
        CTO,
        CEO
    }
}
