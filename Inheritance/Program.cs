using System;
using System.IO.Compression;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird Toucan = new Bird();
            Toucan.FeatherColor = "Black";
            Toucan.BeakColor = "Orange";
            Toucan.CanFly = true;
            Toucan.BirdOfPrey = false;

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *
             * Creatively display the class member values
             */
            Reptile Terrapin = new Reptile();
            Terrapin.ScaleColor = "Brown";
            Terrapin.HasShell = true;
            Terrapin.ForkedTongue = false;
            Terrapin.LiveInWater = true;
            
            Console.WriteLine($"The Toucan is a bird often found with {Toucan.FeatherColor} feathers and an {Toucan.BeakColor} beak. Can it fly? {Toucan.CanFly}. Is it a bird of prey? {Toucan.BirdOfPrey}. Does it have a tail? {Toucan.Tail}. It has {Toucan.Legs} legs, lives in the {Toucan.Habitat}, and is {Toucan.Age} years old.");
            Console.WriteLine($"The Terrapin is a reptile often found with {Terrapin.ScaleColor} scales. Does it have a shell? {Terrapin.HasShell}. Does it have a forked tongue? {Terrapin.ForkedTongue}. Does live in the water? {Terrapin.LiveInWater}. It has {Terrapin.Legs} legs, lives in the {Terrapin.Habitat}, and is {Terrapin.Age} years old.");
        }
    }
}
