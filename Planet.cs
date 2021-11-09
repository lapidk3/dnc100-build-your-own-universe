/**
 * File Name: Planet.cs
 * Author: Kenneth Lapid David
 *
 * This file contains the Planet class, which defines a planet object by
 * it's name and a list of it's life forms
 *
 */

 using System;
 using System.Collections.Generic;

 namespace BuildYourOwnUniverse
 {
     public class Planet
     {
         private String Name; // The name of this planet
         private List<LifeForm> LifeForms; // A list of life forms inhabiting the planet

         /**
          * This constructor will create a planet object with the specified name and
          * a list containing no life forms
          *
          * @param name: the name of the planet
          */
         public Planet(String name) {
             this.Name = name;
             this.LifeForms = new List<LifeForm>();
         }

         /**
          * This method will add a life form to our planet
          *
          * @param newLife: the lifeform to add
          */
         public void AddLifeForm(LifeForm newLife) {
             this.LifeForms.Add(newLife);
         }

         /**
          * This method will get the size of the list of life forms on this planet
          *
          * @return the number of life forms living in this planet
          */
         public int Size() {
             return this.LifeForms.Count;
         }

         /**
          * This method will get the name of this planet
          *
          * @return the name of the planet
          */
        public String GetName() {
            return this.Name;
        }

     }
 }