using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_5
{
    // creating a class with string and int fields
    // class implements Icomparable interface
    class Person : IComparable
    {
        // fields
        private int age;
        private string name;
        
        // constructor
        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        // method for sorting
        public int CompareTo(object obj)
        {
            // casting to person
            Person someone = obj as Person;

            // comparing logic
            if (someone != null)
            {
                // comparing names
                if (string.Compare(this.name, someone.name) < 0) return -1;
                if (string.Compare(this.name, someone.name) > 0) return 1;
                else
                {
                    // comparing age
                    if (this.age < someone.age) return -1;
                    if (this.age > someone.age) return 1;
                    else return 0;
                }
            }
            else
            {
                throw new ArgumentException("Parameter is not a MyClass object ");
            }
        }

        // properties get set
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }
}
