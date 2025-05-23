using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principles
{
    internal class Lion: Animal
    {
        public Lion(string name) : base(name){
            

        }

        public override void Eat()
        {
            Console.WriteLine("I like zebra");
        }
    }
}
