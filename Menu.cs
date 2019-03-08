using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Menu
    {
        public Menu() {
            Console.WriteLine("Ingresa la operación deseada");
            Console.WriteLine("1) Suma");
            Console.WriteLine("2) Resta");
            Console.WriteLine("3) Multiplicación");
            Console.WriteLine("4) División");

            int opcion = 0;
            bool succes = int.TryParse(Console.ReadLine(), out opcion);
            if (succes) {
                int ent1 = 0, ent2 = 0;
                Console.Write("Ingresa la primera entrada");
                int.TryParse(Console.ReadLine(), out ent1);
                Console.Write("Ingresa la primera entrada");
                int.TryParse(Console.ReadLine(), out ent2);
                switch (opcion) {
                    case 1:
                        Console.WriteLine("Resultado = " + new Suma(ent1, ent2)); break;
                    case 2:
                        Console.WriteLine("Resultado = " + new Resta(ent1, ent2)); break;
                    case 3:
                        Console.WriteLine("Resultado = " + new Multiplicacion(ent1, ent2)); break;
                    case 4:
                        Console.WriteLine("Resultado = " + new Division(ent1, ent1)); break;
                    default: Console.WriteLine("Sin opciones"); break;
                }
            }
            Console.WriteLine();
        }
    }
}
