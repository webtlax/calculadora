using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Resta
    {
        int restar = 0;

        public Resta(int r1, int r2)
        {
            this.restar = r1 + r2;
        }

        public string ToString()
        {
            return "El resultado es " + restar;
        }
    }
}