using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{


    // Create a class Reptile
    // give this class 4 members that are specific to Reptile
    // Set this class to inherit from your Animal Class
    public class Reptile : Animal
    { 
        public bool Tail { get; set; }
        public int Legs { get; set; }

        public bool LaysEggs { get; set; }

        public bool IsWarmblooded { get; set; }

        public Reptile()
        {

        }

        public Reptile(bool hasBackbone, string name, int age, string diet, bool tail, int legs, bool laysEggs, bool isWarmblooded)
        {
            HasBackbone = hasBackbone;
            Name = name;
            Age = age;
            Diet = diet;
            Tail = tail;
            Legs = legs;
            LaysEggs = laysEggs;
            IsWarmblooded = isWarmblooded;
        }
    }
}

