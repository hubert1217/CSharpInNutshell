using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Classes
{
    public class MyClass : BaseClass
    {
        public int d { get; } = 0;


        public MyClass(int valA, int valB, int valC) : base(valA, valB, valC)
        {
        }

        public MyClass(int valA, int valB) : base(valA, valB) 
        {
            
        }

        public MyClass(int valA, int valB, int valC, int valD) : base(valA, valB, valC) 
        { 
            d = valD;
        }

        public override int Suma()
        {
            return base.Suma()+d;
        }



    }
}
