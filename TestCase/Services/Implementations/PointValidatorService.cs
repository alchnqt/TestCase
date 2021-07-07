using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCase.Basics;
using TestCase.Services.Contracts;

namespace TestCase.Services.Implementations
{
    public class PointValidatorService : IPointValidatorService
    {
        public bool ValidatePointsInMap(Map map, List<Point> points) => (from point in points where point.X <= map.Widht || point.Y <= map.Height select point).ToList().Count == points.Count;
    }
}
