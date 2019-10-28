/*
Author: Amina Khan
Date: 10/17/2019
CTEC 135: Microsoft Software Development with C#
Module 4
Programming Assignment 3: Prob 4

-hierarchy of classes that demonstrates polymorphic behavior

-An array of the base class type is created and initialized 
 with a member of each class in the hierarchy
-a method belonging to the base class is called from a child instance
-Demo overriding a base class method by a child
-Demo a child method calling the parent's method
-Demo use of "as" keyword
-Demo use of "is" keyword
-Demo calling a method in a for loop iterating over the
 instances in the array
-Demo calling a method in a foreach loop
-Demo switch statement that responds differently depending upon 
 the type of the object
-An object of "object" type, but initialized of the base class 
 type, then cast it to the actual type so you can call a method
-Create an object of the base class type but initialized to a child type 
 that has a specialized method. Call the specialized method by using casting

*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // an array of base class
            Animal[] myPets = new Animal[4];
            myPets[0] = new Animal("Some animal" , 122);
            myPets[1] = new Cat("Mittens" , 123);
            myPets[2] = new Dog("Max", 124);
            myPets[3] = new Puppy("Snow Ball", 125);

            // method belonging to base class is called from child instance
            Console.WriteLine("\n->Child class calling base class method...");
            myPets[1].Eat();
            myPets[2].Eat();


            //overriding method Speak from base class
            Console.WriteLine("\n->Overriding Speak() method from base class...");
            myPets[1].Speak();
            myPets[2].Speak();

            //child method calling parents method
            Console.WriteLine("\n->Child method calling parents method...");
            Cat myKitty = new Cat("Mimi", 126);
            myKitty.CatEatAndPlay();

            Console.WriteLine("\n->Calling method in for loop...");
            //calling method in a forloop
            for (int i = 0; i < myPets.Length; i++)
            {
                // demo use of "is" keyword to check class type
                if (myPets[i] is Puppy)
                {
                    // demo use of "as" keyword or type casting
                    Puppy simba = myPets[i] as Puppy;
                    simba.Whine();
                }
                else if (myPets[i] is Dog)
                {
                    // demo use of "as" keyword or type casting
                    Dog tiger = myPets[i] as Dog;
                    tiger.Fetch();
                }
                else if (myPets[i] is Cat)
                {
                    // demo use of "as" keyword or type casting
                    Cat fluffy = myPets[i] as Cat; 
                    fluffy.CatEatAndPlay();
                }
                else if (myPets[i] is Animal)
                {
                    // demo use of "as" keyword or type casting
                    Animal jack = myPets[i] as Animal;
                    jack.Eat();
                }

            }

            //foreach loop demo
            Console.WriteLine("\n->Foreach loop demo...");
            foreach (Animal myPet in myPets)
            {
                myPet.Eat();
            }

            
            //switch statement
            Console.WriteLine("\n->Switch statement demo...");
            foreach (Animal myPet in myPets)
            {
                switch (myPet)
                {
                    case Cat c:
                        Console.WriteLine("This is Cat: {0}", c.Name);
                        break;
                    case Puppy p:
                        Console.WriteLine("This is Puppy: {0}", p.Name);
                        break;
                    case Dog d:
                        Console.WriteLine("This is Dog: {0}", d.Name);
                        break;
                    case Animal a:
                        Console.WriteLine("This is Animal: {0}", a.Name);
                        break;
                    default:
                        break;
                }
            }


            // create object of object type
            Console.WriteLine("\n->Object of object type + method call...");
            Object myObj = new Animal("Small Animal", 121);
            // cast as actual type
            Animal animal1 = myObj as Animal;
            //calling method
            animal1.Speak();


            // Specialized method demo
            Console.WriteLine("\n->Base object as child type + method call");
            Animal myAnimal = new Cat("stray cat", 127);
            Cat myCat = myAnimal as Cat; // casting
            myCat.CatEatAndPlay(); //specialized method
            
            Console.WriteLine();
        }
    }
}
