using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prob_4
{
    class Puppy : Dog
    {
        public Puppy(string name, int id) : base(name, id) { }

        // method
        public void Whine()
        {
            Console.WriteLine("{0} is whining", this.Name);
        }
    }
}
