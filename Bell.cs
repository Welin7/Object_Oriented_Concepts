using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Concepts
{
    public abstract class Bell
    {
        //abstract method responsible for the overload of methods
        public abstract void Music();

        public void Sound()
        {
            Music();
        }
    }
}
