using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCase.Basics
{
    public class Map
    {
        int height;
        int widht;

        public Map(int height, int widht)
        {
            Height = height;
            Widht = widht;
        }

        public int Height 
        {
            get => height;

            set => height = value >= 0 ? value : throw new ArgumentOutOfRangeException("Height must be > 0");
        }
        public int Widht 
        { 
            get => widht; 

            set => widht = value >= 0 ? value : throw new ArgumentOutOfRangeException("Width must be > 0");
        }
    }
}
