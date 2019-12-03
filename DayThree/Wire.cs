using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace DayThree
{
    public class Wire
    {
        public List<Point> CoOrdinates = new List<Point>{ };

        private Point _currentCoOrdinate = new Point(0,0);

        public void MoveUsingString(string directions)
        {
            var directionArray = directions.Split(',');
            foreach (var command in directionArray)
            {
                var direction = command.Substring(0, 1).ToCharArray().Single();
                var distance = int.TryParse(command.Substring(1, (command.Length - 1)), out var distanceInt);
                if (distanceInt != default)
                {
                    Move(direction, distanceInt);
                }
            }
        }

        public void Move(char direction, int distance)
        {
            switch (direction)
            {
                case 'R':
                    MoveXDirection(distance,true);
                    break;
                case 'L':
                    MoveXDirection(distance, false);
                    break;
                case 'U':
                    MoveYDirection(distance, true);
                    break;
                case 'D':
                    MoveYDirection(distance, false);
                    break;
                default:
                    throw new ApplicationException($"Direction not recognised: {direction}");
            }
        }

        private void MoveXDirection(int distance, bool isRight)
        {
            for (int i = 1; i <= distance; i++)
            {
                var newCoOrdinate = new Point(_currentCoOrdinate.X + (isRight ? 1 : -1 ),_currentCoOrdinate.Y);
                CoOrdinates.Add(newCoOrdinate);
                _currentCoOrdinate = newCoOrdinate;
            }
        }

        private void MoveYDirection(int distance, bool isUp)
        {
            for (int i = 1; i <= distance; i++)
            {
                var newCoOrdinate = new Point(_currentCoOrdinate.X, _currentCoOrdinate.Y + (isUp ? 1 : -1));
                CoOrdinates.Add(newCoOrdinate);
                _currentCoOrdinate = newCoOrdinate;
            }
        }
    }
}
