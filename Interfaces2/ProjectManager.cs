using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces2
{
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
