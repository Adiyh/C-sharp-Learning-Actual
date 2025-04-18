using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceapp
{
    public interface Interface1
    {
        void Add(int a, int b);
    }
    public interface Interface2
    {
        void Sub(int a, int b);
    }
   
    public class InterfaceClass : Interface1, Interface2
    {
         public void Add(int a, int b) {
            Console.WriteLine(a + b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);

        }
    }
}
