using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Submarine : ISpeed
    {

        
        int speed = 0;
        
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

    }
}
