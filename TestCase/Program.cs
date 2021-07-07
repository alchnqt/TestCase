using System;
using System.Text.RegularExpressions;
using TestCase.Basics;
using TestCase.Contracts;
using TestCase.Factory.Abstract;
using TestCase.Factory.Concrete;
using TestCase.Workspaces;

namespace TestCase
{
    class Program
    {
        //5x5 (0, 0) (1, 3) (4, 4) (4, 2) (4, 2) (0, 1) (3, 2) (2, 3) (4, 1)
        static void Main(string[] args)
        {
            try
            {
                WorkspaceFactory pizzaWorkspaceFactory = new PizzaWorkspaceFactory();
                IRouteProccesor pizzaWorkspace = pizzaWorkspaceFactory.CreateWorkspace(string.Join(" ", args));
                pizzaWorkspace.ProccesRoute();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
