using System;
using System.Collections.Generic;
using TestCase.Basics;
using TestCase.Contracts;
using TestCase.Factory.Abstract;
using TestCase.Robots;
using TestCase.Services.Contracts;
using TestCase.Services.Implementations;
using TestCase.Workspaces;

namespace TestCase.Factory.Concrete
{
    public class PizzaWorkspaceFactory : WorkspaceFactory
    {
        
        public override IRouteProccesor CreateWorkspace(string args)
        {
            IStringValidatorService validator = new CommandLineValidatorService();
            if (!validator.ValidateString(args))
                throw new Exception("Invalid format of input string, check documentation to see valid input");

            Map map = new Map(int.Parse(args[0].ToString()), int.Parse(args[2].ToString()));
            List<Point> deliveryPoints = new();
            RobotFactory pizzaRobotFactory = new PizzaRobotFactory();
            PizzaRobot pizzaRobot = (PizzaRobot)pizzaRobotFactory.CreateRobot();

            int iterator = 5;

            while (args[iterator] != '\0')
            {
                int x = int.Parse(args[iterator].ToString());
                int y = int.Parse(args[iterator + 3].ToString());
                deliveryPoints.Add(new Point(x, y));
                iterator += 7;
                if (iterator >= args.Length)
                    break;
            }

            return new PizzaWorkspace(map, deliveryPoints, pizzaRobot);
        }
    }
}
