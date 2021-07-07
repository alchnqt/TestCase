using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCase.Basics;
using TestCase.Contracts;

namespace TestCase.Factory.Abstract
{
    public abstract class WorkspaceFactory
    {
        public abstract IRouteProccesor CreateWorkspace(string args);
    }
}
