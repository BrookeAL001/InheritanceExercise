using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    // Create a class Bird
    // give this class 4 members that are specific to Bird
    // Set this class to inherit from your Animal Class
    public class Bird : Animal
    {
        public bool Flies { get; set; }
        public int Wings { get; set; }

        public bool HasFeathers { get; set; }

        public bool Nesting { get; set; }

        public Bird()
        {

        }

        public Bird(bool hasBackbone, string name, int age, string diet, bool flies, int wings, bool hasFeathers, bool nesting)
        {
            HasBackbone = hasBackbone;
            Name = name;
            Age = age;
            Diet = diet;
            Flies = flies;
            Wings = wings;
            HasFeathers = hasFeathers;
            Nesting = nesting;
        }
    }
}
