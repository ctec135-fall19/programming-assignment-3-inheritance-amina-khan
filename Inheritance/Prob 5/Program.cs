/*
Author: Amina Khan
Date: 10/17/2019
CTEC 135: Microsoft Software Development with C#
Module 4, Programming Assignment 3, Prob 5

- Create class 
- implement IComparable 
- create objects and demo 
Create a class with two fields, one a string and the other an int.
The class implements the IComparable interface.

Create appropriate methods for the class

Objects in the class should be ordered in the following manner:
-primary sort order is alphabetical according to the text field
-secondary sort order is largest first according to the int field

Demonstrate the the objects can be sorted according to requirement

*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating new objects for testing
            Person p1 = new Person(26, "Max");
            Person p2 = new Person(25, "Max");
            Person p3 = new Person(35, "Ace");
            Person p4 = new Person(45, "Bil");
            Person p5 = new Person(55, "Cin");
            Person p6 = new Person(27, "Max");

            // adding objects to the array
            Person[] personsArray = {p1,p2,p3,p4,p5,p6};

            // printing the array before sorting
            Console.WriteLine("\n Array of persons BEFORE sorting...");
            foreach (Person person in personsArray)
            {
                Console.WriteLine("{0}, {1}", person.Name, person.Age);
            }
            Console.WriteLine();

            // sorting array
            Array.Sort(personsArray);

            // printing the array
            Console.WriteLine("\n Array of persons AFTER sorting...");
            foreach (Person person in personsArray)
            {
                Console.WriteLine("{0}, {1}", person.Name, person.Age );
            }
            Console.WriteLine();
        }
    }
}
