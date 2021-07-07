using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCase.Contracts;
using TestCase.Factory.Abstract;
using TestCase.Robots;

namespace TestCase.Factory.Concrete
{
    public class PizzaRobotFactory : RobotFactory
    {
        public override IRobot CreateRobot() => new PizzaRobot();
    }
}
