using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCase.Basics;

namespace TestCase.Services.Contracts
{
    public interface IPointValidatorService
    {
        public bool ValidatePointsInMap(Map map, List<Point> points);
    }
}
