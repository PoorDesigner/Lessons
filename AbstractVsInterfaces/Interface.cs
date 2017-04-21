using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVsInterfaces
{
    
    interface Animal
    {
        void Bark();
        void Slepp();


    }
    class Fish : Animal
    {
        public void Bark()
        {
            throw new NotImplementedException();
        }

        public void Slepp()
        {
            throw new NotImplementedException();
        }
    }

}
