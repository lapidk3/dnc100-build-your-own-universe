/**
 * File name: Galaxy.cs
 * Author: Kenneth Lapid David
 *
 * This file contains the Galaxy class, which will define Galaxy objects
 * through a list of their solar systems
 *
 */

 using System;
 using System.Collections.Generic;

 namespace BuildYourOwnUniverse
 {
     public class Galaxy
     {
         private String Name; // This field will represent the name of the galaxy
         private List<SolarSystem> SolarSystems; // This field will hold all solar systems in the galaxy

        /**
         * This constructor will initialize a Galaxy object with the specified name and an empty list of solar systems
         *
         * @param name: the name that will be given to this galaxy
         */
         public Galaxy(String name) {
             this.Name = name;
             this.SolarSystems = new List<SolarSystem>();
         }

         /**
          * This method will add a solar system to this galaxy
          *
          * @param solarSystem: The solar system to add
          */
          public void AddSolarSystem(SolarSystem solarSystem) {
              this.SolarSystems.Add(solarSystem);
          }

          /**
           * This method will return the number of solar systems in this galaxy
           *
           * @return the number of solar systems thus galaxy has
           */
           public int Size() {
               return this.SolarSystems.Count;
           }

           /**
            * This method will get the name of this galaxy
            *
            * @return the name of the galaxy
            */
            public String GetName() {
                return this.Name;
            }

     }
 }