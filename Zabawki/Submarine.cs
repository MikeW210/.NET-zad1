using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Submarine : ISpeed,IHeight
    {

        
        int speed = 50;
        int depth = 100;
        
        static int id = 1;
        private string nameOf;

        public Submarine()
        {
        }

        public Submarine(string _name)
        {
            nameOf = _name + "#" + id;
            id++;
        }

        public int Faster()
        {
           return speed++;
        }

        public int Slower()
        {
            speed--;
            if (speed <= 0)
            {
                speed = 0;
            }

            return speed;
        }
        public override string ToString()
        {
            return nameOf;
        }

        public int getSpeed()
        {
            return this.speed;
        }

        public int Higher()
        {
            return depth--;
        }

        public int Lower()
        {
            return depth++;
        }

        public int getRise()
        {
            return this.depth;
        }
      }
}
