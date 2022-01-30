namespace MarsRoverTechChallenge.Services
{
    public class RoverLocation
    {
        public RoverLocation()
        {

        }
        public RoverLocation(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
