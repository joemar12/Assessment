using Assessment2.Models;

namespace Assessment2.AbstractFactory
{
    public class AndromedaCelestialBodyFactory : ICelestialBodyFactory
    {
        public IStar CreateStar()
        {
            return new NeutronStar();
        }

        public IPlanet CreatePlanet()
        {
            return new SuperEarth();
        }
    }
}
