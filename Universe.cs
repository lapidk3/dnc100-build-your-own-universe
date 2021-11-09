/**
 * File name: Universe.cs
 * Author: Kenneth Lapid David
 *
 * This file contains the Universe class, which will serve as a "container
 * object that holds one or more Galaxies in our world
 *
 */

 using System;
 using System.Collections.Generic;
 
 namespace BuildYourOwnUniverse
 {
     public class Universe
     { 
        private List<Galaxy> galaxies; // We use a list to hold all the galaxies in our universe

        /**
         * This is the no argument constructor, which just initializes 
         * an empty list of galaxies
         */
        public Universe() {
            galaxies = new List<Galaxy>(); 
        }

        /**
         * This is a method that will add a galaxy to the list of Galaxies in our universe
         *
         * @param theGalaxy: The galaxy to add in our Universe
         */
        public void Add(Galaxy theGalaxy) {
            this.galaxies.Add(theGalaxy);
        }

        /**
         * This is a method that will remove a galaxy from our universe
         *
         * @param theGalaxy: The Galaxy to remove
         * @return true if specified galaxy was successfully removed, false if galaxy was not found and thus not removed
         */
        public Boolean Remove(Galaxy theGalaxy) {
            return this.galaxies.Remove(theGalaxy);
        }

        /**
         * This is a method that counts the number of galaxies in this universe
         *
         * @return the number of galaxies in this universe
         */
        public int Size() {
            return this.galaxies.Count;
        }


     }
 }