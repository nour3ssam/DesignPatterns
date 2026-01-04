using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pub_Sub
{
    internal class Eventargs : EventArgs
    {
        public int Temperature { get; set; }
        public Eventargs(int Temperature)
        {
            this.Temperature = Temperature;
        }
    }
}
