using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_4
{
    class Dog : Animal
    {
        public Dog(string name, int id) : base(name, id) {}

        // overriding base class method Speak()
        public override void Speak()
        {
            Console.WriteLine("Woof");
        }

        // demonstrating class specific method
        public void Fetch()
        {
            Console.WriteLine("{0} is fetching", this.Name);
        }
    }
}
