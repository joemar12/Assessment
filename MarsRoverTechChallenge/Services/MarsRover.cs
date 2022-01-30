using System;
using System.Linq;

namespace MarsRoverTechChallenge.Services
{

    public class MarsRover
    {
        private char[] validInstructions = new char[] { 'L', 'R', 'M' };
        private int _angleRelativeToNorth;
        public MarsRover(int initialX, int initialY, char initialHeading)
        {
            Location = new RoverLocation(initialX, initialY);
            Heading = initialHeading;
        }
        public MarsRover(string initialLocationAndHeading)
        {
            Location = new RoverLocation();
            var input = initialLocationAndHeading.Split(' ');
            if (input.Length != 3)
            {
                throw new ArgumentException("invalid plateau bounds");
            }
            if (int.TryParse(input[0], out int x))
            {
                Location.X = x;
            }
            if (int.TryParse(input[1], out int y))
            {
                Location.Y = y;
            }
            Heading = char.Parse(input[2]);
        }
        public RoverLocation Location { get; set; }
        public RoverLocation MaxLocation { get; set; }
        public char Heading
        {
            get
            {
                var angle = _angleRelativeToNorth % 360;
                switch (angle)
                {
                    case 0: return 'N';
                    case 90: return 'E';
                    case 180: return 'S';
                    case 270: return 'W';
                    default: return 'N';
                }
            }
            set
            {
                switch (value)
                {
                    case 'N':
                        _angleRelativeToNorth = 0;
                        break;
                    case 'E':
                        _angleRelativeToNorth = 90;
                        break;
                    case 'S':
                        _angleRelativeToNorth = 180;
                        break;
                    case 'W':
                        _angleRelativeToNorth = 270;
                        break;
                }
            }
        }
        public void AcceptTraversalInstructions(string traversalInstructions)
        {
            var instructions = traversalInstructions.ToCharArray();
            foreach (var instruction in instructions)
            {
                AcceptInstruction(instruction);
            }
        }
        public void AcceptInstruction(char instruction)
        {
            if (!validInstructions.Contains(instruction))
            {
                throw new ArgumentException("Invalid instruction");
            }
            switch (instruction)
            {
                case 'M':
                    switch (Heading)
                    {
                        case 'N':
                            Location.Y += 1;
                            break;
                        case 'S':
                            Location.Y -= 1;
                            break;
                        case 'E':
                            Location.X += 1;
                            break;
                        case 'W':
                            Location.X -= 1;
                            break;
                    }
                    break;
                case 'L':
                    _angleRelativeToNorth += 270;
                    break;
                case 'R':
                    _angleRelativeToNorth += 90;
                    break;
                default:
                    break;
            }
            if (Location.X > MaxLocation.X || Location.Y > MaxLocation.Y)
            {
                throw new InvalidOperationException("Rover out of bounds");
            }
        }
    }
}
