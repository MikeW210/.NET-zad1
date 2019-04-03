using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Plane :  IHeight,IAccelerate
    {


        int acc = 500;
        int height = 200;
        static int id = 1;
        private string nameOf;

        public Plane()
        {
        }

        public Plane(string _name)
        {
            nameOf = _name + "#" + id;
            id++;

        }


        public int Higher()
        {
            if (height <= 0)
            {
                height = 0;
            }
            return height--;
            
        }

        public int Lower()
        {
            height++;
           
            return height;
        }
        public override string ToString()
        {
            return nameOf;
           
        }

        public int getRise()
        {
            return this.height;
        }

        public int Przyspiesz()
        {
            return acc++;
        }

        public int Zwolnij()
        {
            return acc--;
        }

        public int getAcc()
        {
            return this.acc;
        }
    }
}
