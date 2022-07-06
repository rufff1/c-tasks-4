using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Dog
    {
        public string name;
        public string color;
        public byte age;

        public Dog()
        {

        }
        public Dog(string name, string color, byte age)
        {
            this.name = name;
            this.color = color;
            this.age = age;
        }
    }
}
