using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_4
{
    class Cat : Animal
    {
        public Cat(string name, int id) : base(name, id) { }

        // overriding base class method 
        public override void Speak()
        {
            Console.WriteLine("Meow");
        }

        // method that calls base class methods
        public void CatEatAndPlay()
        {
            this.Eat();
            this.Play();
        }

    }
}
