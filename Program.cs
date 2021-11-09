/**
 * Filename: Program.cs
 * Author: Kenneth Lapid David
 *
 * This File contains the Program class which creates a program that 
 * builds a universe for you and outputs it to the console
 */

using System;
using System.Collections.Generic;

namespace BuildYourOwnUniverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random1 = new Random();
            int numGalaxies = random1.Next(2,100);

            Random random2 = new Random();
            int numSolarSystems = random2.Next(2,200);

            Random random3 = new Random();
            int numPlanets = random3.Next(2,100);

            Random random4 = new Random();
            int numLifeForms = random4.Next(1,100);

            Universe universe = new Universe();

            for(int i = 0; i < numGalaxies; i++) {
                Galaxy galaxy = new Galaxy(i.ToString()); // Create glaxies
                for(int j = 0; j < numSolarSystems; j++) {
                    SolarSystem solarSystems = new SolarSystem(j.ToString()); // Create Solar Systems
                    Star star = new Star("sun");
                    solarSystems.AddStar(star);
                    for(int k = 0; k < numPlanets; k++) {
                        Planet planet = new Planet(k.ToString());
                        solarSystems.AddPlanet(planet);
                        galaxy.AddSolarSystem(solarSystems);
                        for(int l = 0; l < numLifeForms; l++) {
                            LifeForm lifeform = new LifeForm(l.ToString(),"LAST");
                            planet.AddLifeForm(lifeform);
                        }
                    }
                }
            }

            Console.WriteLine("1 Universe containing");
            Console.WriteLine("\t" + numGalaxies + " Galaxies, each with");
            Console.WriteLine("\t\t" + numSolarSystems + " Solar Systems, each with");
            Console.WriteLine("\t\t\t1 Star");
            Console.WriteLine("\t\t\t" + numPlanets + " Planets");
            Console.WriteLine("\t\t\t\t" + numLifeForms + " life forms");

        }
    }
}
