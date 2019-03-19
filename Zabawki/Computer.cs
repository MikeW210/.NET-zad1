using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Computer
    {
        static int id = 1;     
        private string nameOf;

        public Computer()
        {
        }

        public Computer(string _name)
        {
            nameOf = _name + "#" + id;
            id++;

        }

        public override string ToString()
        {
            return nameOf;
        }

    }
}
