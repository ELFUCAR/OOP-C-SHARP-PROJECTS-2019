/******************************************************************************
guess the number
*******************************************************************************/
using System;

class guessTheNumber

{
  static void Main() 
  
  {

      
      Random random = new Random();
      int secretNumber= random.Next(0,1000);
      
      bool notFound=true;
      
      while(notFound)
      
      {
      Console.WriteLine(secretNumber);
      Console.WriteLine(secretNumber);
      notFound=false;
      
      }
  
  
}}
