using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using TestCase.Basics;
using TestCase.Contracts;
using TestCase.Robots;
using TestCase.Services;
using TestCase.Services.Contracts;
using TestCase.Services.Implementations;

namespace TestCase.Workspaces
{

    /// <summary>
    /// That class separate main logic of pizza delivery, i called it workspace for some reason
    /// </summary>
    public class PizzaWorkspace : IRouteProccesor
    {
        Map map;
        List<Point> deliveryPoints = new();
        PizzaRobot pizzaRobot;

        public PizzaWorkspace(Map map, List<Point> deliveryPoints, PizzaRobot pizzaRobot)
        {
            this.map = map;

            this.deliveryPoints = ValidatePointInMap(this.map, deliveryPoints) ? deliveryPoints : throw new Exception("Invalid points in map");

            this.pizzaRobot = pizzaRobot;
        }

        private static bool ValidatePointInMap(Map map, List<Point> points)
        {
            IPointValidatorService pointValidator = new PointValidatorService();
            return pointValidator.ValidatePointsInMap(map, points);
        }

        /// <summary>
        /// Main algorithm of moving trough the map
        /// The first is moving along the x-axis, the second is moving along the y-axis
        /// </summary>
        public void ProccesRoute()
        {
            Point currentPosition = new(0, 0);
            for (int i = 0; i < deliveryPoints.Count; i++)
            {
                while (deliveryPoints[i].X != currentPosition.X)
                {
                    if (deliveryPoints[i].X >= currentPosition.X)
                    {
                        pizzaRobot.MoveEast();
                        currentPosition.X++;
                    }
                    else
                    {
                        pizzaRobot.MoveWest();
                        currentPosition.X--;
                    }
                }

                while (deliveryPoints[i].Y != currentPosition.Y)
                {
                    if (deliveryPoints[i].Y >= currentPosition.Y)
                    {
                        pizzaRobot.MoveNorth();
                        currentPosition.Y++;
                    }
                    else
                    {
                        pizzaRobot.MoveSouth();
                        currentPosition.Y--;
                    }
                }
                pizzaRobot.Drop();
            }
        }
    }
}
