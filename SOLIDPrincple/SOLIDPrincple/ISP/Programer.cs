using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincple.ISP
{
    internal class Programer : Person , IWorkOnTask
    {
        public void WorkOnTask()
        {
            Console.WriteLine("Programmer work on task");
        }
    }
}
