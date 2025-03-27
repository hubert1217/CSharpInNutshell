using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Classes
{
    public class BaseClass
    {

        public int a { get; }

        public int b { get; }

        public int c { get; }

        public int suma => a + b;

        public BaseClass(int valA, int valB)
        {
            a = valA;
            b = valB;
        }

        public BaseClass(int valA, int valB, int valC): this(valA, valB)
        {
            c = valC;
        }

        public virtual int Suma() 
        {
            return a + b + c;
        }

    }
}
