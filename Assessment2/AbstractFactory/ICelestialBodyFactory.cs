using Assessment2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment2.AbstractFactory
{
    public interface ICelestialBodyFactory
    {
        IStar CreateStar();
        IPlanet CreatePlanet();
    }
}
