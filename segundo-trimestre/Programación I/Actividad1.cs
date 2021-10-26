using System;
using System.Collections.Generic;
using System.Text;

namespace Programación_I
{
    class Clase_1
    {
        static void Main()
        {
            int a = 52;
            int b = 10;
            int c = 87;

            Console.WriteLine("Los números utilizados para este ejercicio son:");

            Console.WriteLine("A: {0}", a);
            Console.WriteLine("B: {0}", b);
            Console.WriteLine("C: {0}", c);

            Console.WriteLine("A continuación se presentarán 3 combinaciones numéricas");

            Console.WriteLine("-");

            Console.WriteLine("Combinación numérica 'AACB'");

            Console.WriteLine("-");

            Console.Write(a);
            Console.Write(" ");
            Console.Write(a);
            Console.Write(" ");
            Console.Write(c);
            Console.Write(" ");
            Console.WriteLine(b);

            Console.WriteLine("-");

            Console.WriteLine("Combinación numérica 'BCA'");

            Console.WriteLine("-");

            Console.Write(b);
            Console.Write(" ");
            Console.Write(c);
            Console.Write(" ");
            Console.WriteLine(a);

            Console.WriteLine("-");

            Console.WriteLine("Combinación numérica 'BCBC'");

            Console.WriteLine("-");

            Console.Write(b);
            Console.Write(" ");
            Console.Write(c);
            Console.Write(" ");
            Console.Write(b);
            Console.Write(" ");
            Console.WriteLine(c);
        }
    }
}
