using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_4
{
    class Animal
    {
        // fields
        private string name;
        protected int id;

        // constructors
        public Animal(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public string Name { get => name; set => name = value; }


        // methods
        
        public virtual void Speak()

        {
            Console.WriteLine("{0} speaks", this.name);
        }

        public void Eat()
        {
            Console.WriteLine("{0} is eating", this.name);
        }

        public void Play()
        {
            Console.WriteLine("{0} is Playing", this.name);
        }

    }
}
