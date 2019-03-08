using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Multiplicacion
    {
        int multiplicar = 0;

        public Multiplicacion (int n1, int n2)
        {
            this.multiplicar = n1 * n2;
        }

        public string ToString()
        {
            return "El resultado de tu suma es " + multiplicar;
        }
    }
}
