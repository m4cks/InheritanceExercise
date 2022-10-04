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
            //=========================DONE=================================

            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class
            //=========================DONE=================================

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class
            //=========================DONE=================================

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird birdie = new Bird();

            birdie.hasWings = true;
            birdie.numberOfWings = 2;
            birdie.canFly = true;
            birdie.colorful = false;
            birdie.pottyTrainable = false;
            birdie.species = "Pidgeon";

            Console.WriteLine($"This Bird has wings? {birdie.hasWings} \nHow many? {birdie.numberOfWings} \nIt's colorful? {birdie.colorful} \nThat's right, you guessed it!, it's a {birdie.species}");
            Console.WriteLine("=================================");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptile repty = new Reptile();
            repty.length = 10;
            repty.isScary = true;
            repty.eatsBabies = true;
            repty.hasLegs = false;
            repty.numberOfEyes = 2;
            repty.pottyTrainable = true;

            Console.WriteLine($"This Reptile is {repty.length} meters long! \nIt's scary? {repty.isScary}. \nEats babies? {repty.eatsBabies} \nBut is it potty-trainable? {repty.pottyTrainable}");
        }
    }
}
