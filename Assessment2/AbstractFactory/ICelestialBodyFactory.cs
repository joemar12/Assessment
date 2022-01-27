namespace Assessment2.AbstractFactory
{
    public interface ICelestialBodyFactory
    {
        IStar CreateStar();
        IPlanet CreatePlanet();
    }
}
