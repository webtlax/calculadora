using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Suma
    {
        int sumar = 0;

        public Suma(int n1, int n2) {
            this.sumar = n1 + n2;
        }

        public string ToString() {
            return "El resultado de tu suma es " + sumar;
        }
    }
}
