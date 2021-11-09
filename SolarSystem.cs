/**
 * File Name: SolarSystem.cs
 * Author: Kenneth Lapid David
 *
 * This file contains the Solar System class, which defines Solar System objects
 * by their name, their stars and their plantes.
 *
 */

 using System;
 using System.Collections.Generic;

 namespace BuildYourOwnUniverse
 {
     public class SolarSystem
     {
         private String Name; // The name of the solar system
         private List<Star> Star; // The stars in this solar system
         private List<Planet> Planets; // List of planets in this solar system

        /**
         * This constructor will create a Solar System object with the specified name and 
         * initialize the list of stars and list of planets with an empty list
         *
         * @param name: the name of this solar system
         */
         public SolarSystem(String name) {
             this.Name = name;
             this.Star = new List<Star>();
             this.Planets = new List<Planet>();
         }

        /**
         * This method will add a star to this solar system
         *
         * @param theStar: The star to add
         */
         public void AddStar(Star theStar) {
             this.Star.Add(theStar);
         }

         /**
          * This method will add a planet to the solar system
          *
          * @param thePlanet: The planet to add on
          */
          public void AddPlanet(Planet thePlanet) {
              this.Planets.Add(thePlanet);
          }

          /**
           * This method will return the number of stars in this solar system
           * 
           * @return the number of stars in this solar system
           */
           public int NumStars() {
               return this.Star.Count;
           }

           /**
           * This method will return the number of planets in this solar system
           * 
           * @return the number of planets in this solar system
           */
           public int NumPlanets() {
               return this.Planets.Count;
           }

           /**
            * This method will get the name of this solar system
            *
            * @return the name of the solar system
            */
            public String GetName(){
                return this.Name;
            }
     }
 }