using System;
namespace Animal
{
    public class Program
    {

        static void Main()
        {

            

            Cat cat = new Cat("Mestan","Sari",6);
            Dog dog = new Dog("Bobik", "Qara", 5);




            Console.WriteLine($"{cat.name},{cat.color},{cat.age}");
            Console.WriteLine($"{dog.name},{dog.color},{dog.age}");
            

            



        }
    }











}