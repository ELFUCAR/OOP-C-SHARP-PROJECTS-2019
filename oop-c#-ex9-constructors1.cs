using System;
using System.Collections.Generic;

class Program
{
    class Person
    {
        private string name;
        private int age;
        private string job;
        private double salary;


        public Person(string n, int a, string j, double s)
        {
            
            this.name = n;
            this.age = a;
            this.job = j;
            this.salary = s;
            
        }
        
        public Person(){
            
        }
        
        
        
        
        
        
        public void setProperties(string n, int a, string j, double s)
        {
            this.name = n;
            this.age = a;
            this.job = j;
            this.salary = s;
        }

        public string getName()
        {
            return name;
        }

        public int getAge()
        {
            return age;
        }
        public string getJob()
        {
            return job;
        }
        public double getSalary()
        {
            return salary;
        }


    }




//--------

static void Main()
{

    Person adem = new Person();
    Person eda = new Person("Eda", 15, "Student", 0);
    Person enes = new Person();
    Person elif = new Person();
    Person semra = new Person();

    Person yagız = new Person();
    Person yigit = new Person();
    Person asya = new Person();
    Person ada = new Person();
    Person maya = new Person();


    adem.setProperties("Adem", 46, "Lawyer", 4000);
    eda.setProperties("Eda", 15, "Student", 80000);
    enes.setProperties("Enes", 15, "Student", 0);
    elif.setProperties("Elif", 21, "Engineer", 3500);
  semra.setProperties("Semra", 41, "Lawyer", 7350);


    yagız.setProperties("Yagız", 30, "Doctor", 7350);
    yigit.setProperties("Yigit", 28, "police", 3750);
   asya.setProperties("Asya", 25, "Nurse", 2800);
    ada.setProperties("Ada", 36, "Teacher", 4200);
   maya.setProperties("Maya", 34, "Teacher", 4100);



    Person[] person = { adem, eda, enes, elif, semra, yagız, yigit, asya, ada, maya };

    List<Person> young1 = new List<Person>();
    List<Person> bestSalary1 = new List<Person>();



    double max = 0;


    max = person[0].getSalary();
    string name = person[0].getName();

    for (int i = 0; i < person.Length; i++)
    {


        if (max < person[i].getSalary())
        {
            max = person[i].getSalary();
            name = person[i].getName();
        }


    }
    Console.WriteLine(name + " is maximum salary");
    Console.WriteLine("maximum = " + max);



    double total = 0;
    for (int i = 0; i < person.Length; i++)
    {
        total = total + person[i].getSalary();


    }

    double average = total / person.Length;

    Console.WriteLine("Average Salary is " + average);






    for (int i = 0; i < person.Length; i++)
    {
        if (average < person[i].getSalary())
        {

            Console.WriteLine(person[i].getName() + " is greater than average salary");
        }
    }




    int young = person[0].getAge();


    for (int i = 0; i < person.Length; i++)
    {


        if (young > person[i].getAge())
        {
            young = person[i].getAge();


        }


    }


    for (int i = 0; i < person.Length; i++)
    {


        if (young == person[i].getAge())
        {
            young1.Add(person[i]);


        }


    }

    for (int i = 0; i < young1.Count; i++)
    {
        Console.WriteLine("the youngest person {0} - {1} years old.", young1[i].getName(), young1[i].getAge());
    }





    double bestSalary = person[0].getSalary();


    for (int i = 0; i < person.Length; i++)
    {


        if (bestSalary < person[i].getSalary())
        {
            bestSalary = person[i].getSalary();


        }


    }


    for (int i = 0; i < person.Length; i++)
    {


        if (bestSalary == person[i].getSalary())
        {
            bestSalary1.Add(person[i]);


        }


    }

    for (int i = 0; i < bestSalary1.Count; i++)
    {
        Console.WriteLine(" {0} has the best salary- {1} salary.", bestSalary1[i].getName(), bestSalary1[i].getSalary());
    }






    // for(int i=0; i<10;i++)
    // {

    //  Console.WriteLine(person[i].name + " is " + person[i].age + " years old." + "Her/His occupation is "+ person[i].job +"Her/His salary is "+person[i].salary);
    //  }
    Console.ReadKey();
}
}
