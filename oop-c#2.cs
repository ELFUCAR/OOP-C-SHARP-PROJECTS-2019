
using System;

class Program {
    //----------
    
    class Student 
    {
        
     public string name;
     public int age;
     public string field;
     public int grade;
        
    }
  
  
  //--------
  
  static void Main()
  
  {
      
     Program alberto = new Student();
     Program angel=new Student();
     Program alicia=new Student();
     Program elif = new Student();
     Program asli = new Student ();
     
     
     alberto.name="Rodriquez";
     alberto.age=23;
     alberto.field="Informatica";
     alberto.grade=90;
     
     angel.name="Garcia";
     angel.age=22;
     angel.field="Informatica";
     angel.grade=85;
     
     alicia.name="Rodriquez";
     alicia.age=24;
     alicia.field="Informatica";
     alicia.grade="85";
     
     elif.name="Uçar";
     elif.age=21;
     elif.field="Computer Science";
     elif.grade=80;
     
     asli.name="Sulutaş";
     asli.age=22;
     asli.field="Computer Science";
     asli.grade=85;
     
     
     
     Student[] students={alberto,angel,alici};
     
     
     
    
     
     for(int i=0; i<3;i++)
     {
      
       Console.WriteLine(students[i].name + "is" + student[i].age);
    
    
 
     }
}
