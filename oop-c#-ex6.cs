using System;
using System.Collections.Generic;

class Program
{
    //----------

    class Person
    {

        public string name;
        public int age;
        public string job;
        public double salary;


    }


    //--------

    static void Main()

    {

        Person adem = new Person();
        Person eda = new Person();
        Person enes = new Person();
        Person elif = new Person();
        Person semra = new Person();

        Person yagız = new Person();
        Person yigit = new Person();
        Person asya = new Person();
        Person ada = new Person();
        Person maya = new Person();

        adem.name = "Adem";
        adem.age = 46;
        adem.job = "Lawyer";
        adem.salary = 4000;


        eda.name = "Eda";
        eda.age = 15;
        eda.job = "Student";
        eda.salary = 0;


        enes.name = "Enes";
        enes.age = 15;
        enes.job = "Student";
        enes.salary = 0;


        elif.name = "Elif";
        elif.age = 21;
        elif.job = "Engineer";
        elif.salary = 3500;

        semra.name = "Semra";
        semra.age = 41;
        semra.job = "lawyer";
        semra.salary = 7350;

        yagız.name = "Yagız";
        yagız.age = 30;
        yagız.job = "Doctor";
        yagız.salary = 7350;

        yigit.name = "Yigit";
        yigit.age = 28;
        yigit.job = "Police";
        yigit.salary = 3750;

        asya.name = "Asya";
        asya.age = 25;
        asya.job = "Nurse";
        asya.salary = 2800;

        ada.name = "Ada";
        ada.age = 36;
        ada.job = "Teacher";
        ada.salary = 4200;

        maya.name = "Maya";
        maya.age = 34;
        maya.job = "Teacher";
        maya.salary = 4100;


        Person[] person = { adem, eda, enes, elif, semra, yagız, yigit, asya, ada, maya };

        List<Person> young1 = new List<Person>();
        List<Person> bestSalary1 = new List<Person>();



        double max = 0;


        max = person[0].salary;
        string name = person[0].name;

        for (int i = 0; i < person.Length; i++)
        {


            if (max < person[i].salary)
            {
                max = person[i].salary;
                name = person[i].name;
            }


        }
        Console.WriteLine(name + " is maximum salary");
        Console.WriteLine("maximum = " + max);



        double total = 0;
        for (int i = 0; i < person.Length; i++)
        {
            total = total + person[i].salary;


        }

        double average = total / person.Length;

        Console.WriteLine("Average Salary is " + average);



        for (int i = 0; i < person.Length; i++)
        {
            if (average < person[i].salary)
            {

                Console.WriteLine(person[i].name + " is greater than average salary");
            }
        }




        int young = person[0].age;


        for (int i = 0; i < person.Length; i++)
        {


            if (young > person[i].age)
            {
                young = person[i].age;


            }


        }


        for (int i = 0; i < person.Length; i++)
        {


            if (young == person[i].age)
            {
                young1.Add(person[i]);


            }


        }

        for (int i = 0; i < young1.Count; i++)
        {
            Console.WriteLine("the youngest person {0} - {1} years old.", young1[i].name, young1[i].age);
        }





        double bestSalary = person[0].salary;


        for (int i = 0; i < person.Length; i++)
        {


            if (bestSalary < person[i].salary)
            {
                bestSalary = person[i].salary;


            }


        }


        for (int i = 0; i < person.Length; i++)
        {


            if (bestSalary == person[i].salary)
            {
                bestSalary1.Add(person[i]);


            }


        }

        for (int i = 0; i < bestSalary1.Count; i++)
        {
            Console.WriteLine(" {0} has the best salary- {1} salary.", bestSalary1[i].name, bestSalary1[i].salary);
        }






        // for(int i=0; i<10;i++)
        // {

        //  Console.WriteLine(person[i].name + " is " + person[i].age + " years old." + "Her/His occupation is "+ person[i].job +"Her/His salary is "+person[i].salary);
        //  }
        Console.ReadKey();
    }
}

