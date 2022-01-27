using Assessment2.Models;

namespace Assessment2.AbstractFactory
{
    public class MilkywayCelestialBodyFactory : ICelestialBodyFactory
    {
        public IStar CreateStar()
        {
            return new RedDwarf();
        }
        public IPlanet CreatePlanet()
        {
            return new GasGiant();
        }
    }
}
