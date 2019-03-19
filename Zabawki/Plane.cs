using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Plane :  IHeight
    {

        
      
        int height = 0;
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
           return height++;
        }

        public int Lower()
        {
            height--;
            if (height <= 0)
            {
                height = 0;
            }
            return height;
        }
    
    }
}
