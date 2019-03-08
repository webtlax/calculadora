using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculdora
{
    class Divicion
    {
        int x;
        int y;
        int Result;

        public Divicion () {
            Console.WriteLine("Dame tu primer numero:");
                x = int.Parse(Console.ReadLine());
            Console.WriteLine("Dame tu segundo numero:");
            y = int.Parse(Console.ReadLine());
            Result = x / y;
            Console.WriteLine("el resultado de la divicion es {0}", Result);

        }

       
        
       
    }
}
