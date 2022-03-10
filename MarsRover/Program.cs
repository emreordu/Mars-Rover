using System;

//Mars Rovers should move on the plateau.
//Size of the Plateau is 5 5.
//Rover position is (coordinateX coordinateY direction) ==> Direction can be N(North) E(East) W(West) S(South)
//Example: (1 2 N) ==> coordinateX=1 coordinateY=2 direction=North
//Commands = String message (xxxxxx) L is Turn Left, R is Turn Right, M is Move Forward.
//0 0 is bottom left corner and 5 5 is upper right corner.
//First line of input is size of the plateau.
//Other input lines rover position and commands for rover
//Output should show new rover position

//EXPECTED BEHAVIORS
//Rover should turn left
//Rover should turn right
//Rover should move forward

namespace MarsRover
{
    public class Program
    {
        static void Main(string[] args)
        {
            string roverPosition, roverCommand, plateauSize;

            Console.WriteLine("Please enter Plateau size:");
            plateauSize = Console.ReadLine();
            Console.WriteLine("Please enter position of the rover:");
            roverPosition = Console.ReadLine();

            Rover rover = new Rover(roverPosition, plateauSize);
            Console.WriteLine("Pleae enter commands for the rover:");
            roverCommand = Console.ReadLine();
            rover.GoToLocation(roverCommand);

            Console.WriteLine("New position of the rover:  " + rover.x + " " + rover.y + " " + rover.direction);
            Console.ReadLine();
        }
    }
}