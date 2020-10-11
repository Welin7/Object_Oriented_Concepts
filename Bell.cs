using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Concepts
{
    public abstract class Bell
    {
        public abstract void Music();

        public void Sound()
        {
            Music();
        }
    }
}
