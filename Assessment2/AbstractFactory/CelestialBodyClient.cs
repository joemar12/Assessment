namespace Assessment2.AbstractFactory
{
    public class CelestialBodyClient
    {
        private ICelestialBodyFactory _factory;

        public CelestialBodyClient(ICelestialBodyFactory factory)
        {
            _factory = factory;
        }

        public IStar GetStar()
        {
            return _factory.CreateStar();
        }

        public IPlanet GetPlanet()
        {
            return _factory.CreatePlanet();
        }
    }
}
