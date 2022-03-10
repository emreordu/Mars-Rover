using System;

namespace MarsRover
{
    public class Rover
    {
        public int x; //Rover's x coordinate
        public int maxX; //Plateau size for X coordinate;
        public int y; //Rover's y coordinate
        public int maxY; //Plateau size for Y coordinate;
        public string direction; //Rover's direction

        public Rover(String roverPosition, string plateauSize)
        {
            Int32.TryParse(roverPosition.Split(" ")[0], out x);
            Int32.TryParse(roverPosition.Split(" ")[1], out y);
            direction = roverPosition.Split(" ")[2];
            Int32.TryParse(plateauSize.Split(" ")[0], out maxX);
            Int32.TryParse(plateauSize.Split(" ")[1], out maxY);
        }

        public void TurnLeft()
        {
            direction = direction switch
            {
                "E" => "N",
                "N" => "W",
                "W" => "S",
                "S" => "E",
                _ => throw new ArgumentException(),
            };
        }

        public void TurnRight()
        {
            direction = direction switch
            {
                "E" => "S",
                "N" => "E",
                "W" => "N",
                "S" => "W",
                _ => throw new ArgumentException(),
            };
        }

        public void MoveForward()
        {
            switch (direction)
            {
                case "E":
                    x += 1;
                    break;
                case "N":
                    y += 1;
                    break;
                case "W":
                    x -= 1;
                    break;
                case "S":
                    y -= 1;
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        public void GoToLocation(string roverCommand)
        {
            char[] instructions = roverCommand.ToCharArray();

            for (int i = 0; i < instructions.Length; i++)
            {
                switch (instructions[i])
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'M':
                        MoveForward();
                        break;
                    default:
                        throw new ArgumentException();
                }
                if (x < 0 || x > maxX || y < 0 || y > maxY)
                {
                    throw new Exception("Position cannot be out of plateau boundaries!");
                }
                continue;
            }
        }
    }
}