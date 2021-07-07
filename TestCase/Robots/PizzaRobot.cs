using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCase.Contracts;

namespace TestCase.Robots
{
    public class PizzaRobot : IRobot, IDrop
    {
        public void MoveNorth() => Console.Write("N");

        public void MoveSouth() => Console.Write("S");

        public void MoveEast() => Console.Write("E");

        public void MoveWest() => Console.Write("W");

        public void Drop() => Console.Write("D");
    }
}
