using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Car : IAccelerate,ISpeed
    {
       
        int acc = 5;
        int speed = 50;
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
        public int getAcc()
        {
            return this.acc;
        }

        public int Faster()
        {
            return speed++;
        }

        public int Slower()
        {
            return speed--;
        }

        public int getSpeed()
        {
            return this.speed;
        }
    }
}
