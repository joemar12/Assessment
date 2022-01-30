using System;

namespace MarsRoverTechChallenge.Services
{
    public class MarsPlateau
    {
        private MarsRover _rover;
        public MarsPlateau(int xLimit, int yLimit)
        {
            XLimit = xLimit;
            YLimit = yLimit;
        }
        public MarsPlateau(string plateauBounds)
        {
            var bounds = plateauBounds.Split(' ');
            if (bounds.Length != 2)
            {
                throw new ArgumentException("invalid plateau bounds");
            }
            if (int.TryParse(bounds[0], out int x))
            {
                XLimit = x;
            }
            if (int.TryParse(bounds[1], out int y))
            {
                YLimit = y;
            }
        }
        public int XLimit { get; }
        public int YLimit { get; }

        public void SendRover(MarsRover rover)
        {
            if (rover.Location.X > XLimit || rover.Location.Y > YLimit)
            {
                throw new InvalidOperationException("rover is out of mars plateau bounds.");
            }
            rover.MaxLocation = new RoverLocation(XLimit, YLimit);
            _rover = rover;
        }
        public string SendRoverInstructions(string instructions)
        {
            _rover.AcceptTraversalInstructions(instructions);
            return $"{_rover.Location.X} {_rover.Location.Y} {_rover.Heading}";
        }
    }
}
