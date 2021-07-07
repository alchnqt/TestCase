using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCase.Basics;
using Xunit;

namespace TestCaseTests
{
    public class BasicsTest
    {
        [Fact]
        public void MapX_Set_WithNegativeNumber_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => { new Map(-3, 4); });
        }

        [Fact]
        public void MapY_Set_WithNegativeNumber_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => { new Point(3, -4); });
        }

        [Fact]
        public void PointY_Set_WithNegativeNumber_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => { new Point(-3, 4); });
        }

        [Fact]
        public void PointX_Set_WithNegativeNumber_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => { new Point(3, -4); });
        }
    }
}
