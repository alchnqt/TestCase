using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCase.Contracts
{
    public interface IRobot
    {
        void MoveNorth();
        void MoveSouth();
        void MoveEast();
        void MoveWest();

    }
}
