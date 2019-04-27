
  using System;
  class hhhh
  
  {
    static void main()
      {
   
      Random random = new Random();
     int a=0;
     int b=1000;
      int steps=0;
     
      int secretNumber= random.Next(a,b);
      
      bool notFound=true;
      
      int letItBe;
      while(notFound)
      
      { 
          
     
          
          letItBe=(a+b)/2;
          if(secretNumber>letItBe)
          {
             a=letItBe ;
          }
          
          else
          {
             b=letItBe ;
          }
          steps++;
          }//while
         
      Console.WriteLine("you found the secret number {} in {} steps",secretNumber,steps);
      Console.WriteLine(secretNumber);
      notFound=false;
      
      }
  
  
}

