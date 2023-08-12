using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincple.ISP
{
    internal class TeamLeader : Person, IWorkOnTask, IAssignTask
    {
        public void AssignTask()
        {
            Console.WriteLine("Team Leader assign task");
        }

        public void WorkOnTask()
        {
            Console.WriteLine("Team Leader work on task");
        }
    }
}
