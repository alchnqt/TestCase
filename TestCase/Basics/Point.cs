using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCase.Contracts;

namespace TestCase.Basics
{
    public class Point
    {
        private int x;
        private int y;

        public int X 
        { 
            get => x;

            set => x = value >= 0 ? value : throw new ArgumentOutOfRangeException("Invalid x coordinate's value, it must be > 0");
            
        }
        public int Y 
        { 
            get => y; 

            set => y = value >= 0 ? value : throw new ArgumentOutOfRangeException("Invalid y coordinate's value, it must be > 0");
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
