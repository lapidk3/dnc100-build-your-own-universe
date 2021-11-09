/**
 * File Name: Star.cs
 * Author: Kenneth Lapid David
 * 
 * This file contains the Star class, which defines a star with just it's name
 *
 */

 using System;
 using System.Collections.Generic;

 namespace BuildYourOwnUniverse
 {
     public class Star
     {
        private String Name; // The name of this star
        
        /**
         * This is a constructor that will set the name of this star to the specified name
         *
         */
        public Star(String name) {
            this.Name = name;
        }

        /** 
         * This method will return the name of the star
         *
         * @return the name of the star
         */
         public String GetName() {
             return this.Name;
         }

     }
 }