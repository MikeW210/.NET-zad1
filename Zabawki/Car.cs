using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Car : IAccelerate
    {
       
        int acc = 0;
        static int id = 1;
        private string nameOf; 

        public Car(string _name)
        {
            nameOf = _name + "#" + id;
            id++;
            
        }

        public Car()
        {
        }

        public override string ToString()
        {
            return nameOf;
        }
        

        public int Przyspiesz()
        {
            return acc++;

        }

        public int Zwolnij()
        {
            acc--;
            if (acc <= 0)
            {
                acc = 0;
            }
            return acc;
        }

    }
}
