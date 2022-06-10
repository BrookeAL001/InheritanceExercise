using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common
            //DONE

            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class
            //Done

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class
            //Done




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird yellow = new Bird()
            {
                Age = 6,
                Diet = "Birdseed Milkshakes",
                Flies = false,
                Name = "Big Bird",
                HasBackbone = true,
                HasFeathers = true,
                Nesting = true,
                Wings = 2,

            };

            Console.WriteLine($"{yellow.Name} is a {yellow.Age} year old bird that maily eats {yellow.Diet}.  He has {yellow.Wings} wings.");
            Console.WriteLine($"Does {yellow.Name} have a backbone and feathers, and does he nest?");
            Console.WriteLine($"{yellow.HasBackbone} {yellow.HasFeathers} {yellow.Nesting}");
            Console.WriteLine($"Does {yellow.Name} fly? {yellow.Flies}");
            Console.WriteLine($"{yellow.Name} knows exactly how to get to Sesame Street");


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptile dinosaur = new Reptile()
            {
                Age = 200000000,
                Name = "Barney",
                HasBackbone = true,
                Diet = "Peanut Butter and Jelly",
                Tail = true,
                LaysEggs = false,
                IsWarmblooded = false,
                Legs = 2,


            };

            Console.WriteLine($"{dinosaur.Name} is a {dinosaur.Age} year old dinosaur that eats {dinosaur.Diet}. {dinosaur.Name} has {dinosaur.Legs} legs");
            Console.WriteLine($"Does {dinosaur.Name} have a backbone? {dinosaur.HasBackbone}. Does he have a tail? {dinosaur.Tail}");
            Console.WriteLine($"Does {dinosaur.Name} lay eggs? {dinosaur.LaysEggs} Is he warmblooded? {dinosaur.IsWarmblooded}.");
            Console.WriteLine($"With a great big hug and a kiss from him to you, let's just say {dinosaur.Name} loves you too.");

        }
    }
}
