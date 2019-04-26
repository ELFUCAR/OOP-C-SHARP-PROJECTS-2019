
using System;

namespace OOP_in_Csharp

{

 public class Information

 {

      public string location;

      public string name; 

      public int age;
      
      public string birthday;
      
      public string birthplace;
      
      public string university;
      
      public string department;
 } 

    
 class Person

 {

  public static void Main (string[] args)

  {

   Information myInfor = new Information ();

   myInfor.location = "information";

   myInfor.name = "Elif UÇAR";
   myInfor.age=21;
   myInfor.birthday = "30 June 1997";
   myInfor.birthplace="Istanbul";
   myInfor.university="Toros University";
   myInfor.department="Computer and Software Engineering";
  
   



     Console.WriteLine("I give {0} about me.My name is {1}.I am {2} years old.",myInfor.location, myInfor.name, myInfor.age );
 
    Console.WriteLine("I was born on {0} in {1}." ,myInfor.birthday, myInfor.birthplace);
    
    Console.WriteLine("I study {0} at {1} ." ,myInfor.department, myInfor.university);
  }

 }

}




