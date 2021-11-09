/**
 * File Name: LifeForm.cs
 * Author: Kenneth Lapid David
 *
 * This file contains the LifeForm class which defines a LifeForm object by it's
 * first name and it's last name
 *
 */

 using System;
 using System.Collections.Generic;

 namespace BuildYourOwnUniverse
 {
     public class LifeForm
     {
         private String FirstName; // The First name of this life form
         private String LastName; // The Last name of this life form

         /**
          * This constructor will set the name of this life form
          *
          * @param first: the first name
          * @param last: the last name
          */
         public LifeForm(String first, String last) {
             this.FirstName = first;
             this.LastName = last;
         }

         /**
          * This method will get the first name of this life form
          *
          * @return the life form's first name
          */
         public String GetFirstName() {
             return this.FirstName;
         }

         /**
          * This method will get the last name of this life form
          *
          * @return the life form's last name
          */
         public String GetLastName() {
             return this.LastName;
         }


     }
 }