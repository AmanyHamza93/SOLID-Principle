using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincple.ISP
{
    internal class ProjectManager : Person, IAssignTask
    {
        public void AssignTask()
        {
            Console.WriteLine("Project Manager assign task");
        }
    }
}
