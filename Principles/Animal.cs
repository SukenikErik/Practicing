using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principles
{
    internal class Animal
    {
        private string _name;

        //public string Name { get { return _name; } set { _name = value; } }

        public string Name { get;}

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void Eat()
        {
            Console.WriteLine("Nyamnyam");
        }
        //public void SetName(string name)
        //{
        //    Name = name;
        //}

        //public string GetName()
        //{
        //    return Name;
        //}
    }
}
