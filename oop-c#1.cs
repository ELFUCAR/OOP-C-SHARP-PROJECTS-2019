


using System;

namespace OOP_in_Csharp

{

 public class Computer

 {

      public string location;

      public string model; 

      public string make; 

      public int age;
      
      public string operatingSystem;
      
      public int memory;
 } 

    
 class Program

 {

  public static void Main (string[] args)

  {

   Computer myComp = new Computer ();

   myComp.location = "studentComputer";

   myComp.model = "Lenovo";

   myComp.age = 0;
   myComp.operatingSystem="windows";
   myComp.memory=16;
   



   Console.WriteLine("The computer ({0}) is {1} yers old. It is located in {2}.", myComp.make, myComp.age, myComp.location);
 Console.WriteLine("it has ({0}) system and {1} GB memory." ,myComp.operatingSystem, myComp.memory);

  }

 }

}




