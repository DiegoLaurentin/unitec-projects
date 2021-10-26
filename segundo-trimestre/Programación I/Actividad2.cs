using System;

namespace Actividad_2
{
    class Program
    {
        public static void Main(string[] args)
        {

            string Valor1 = "";
            int Edad = 0;
            double Estatura = 0.0;



            Console.WriteLine("¡Bienvenido a Wonderland!");
            Console.WriteLine("Para ingresar al parque, es necesario conocer su edad actual.");
            Console.WriteLine("Por favor, ingrese su edad:");
                Valor1 = Console.ReadLine();
                Edad = Convert.ToInt32(Valor1);


            if (Edad >= 18)
            {
                Console.WriteLine("Disculpe, debido a su edad, no puede ingresar al parque.");
            }

            else

            {

                
                Console.WriteLine("¡Perfecto! ¡Tiene la edad óptima para ingresar!");
                Console.WriteLine("Para continuar, es necesario que indique su altura:");
                Console.WriteLine("Es necesario que ésta esté medido en metros.");
                Valor1 = Console.ReadLine();
                Estatura = Convert.ToDouble(Valor1);

                if (Estatura <= 2.0)

                {
                    
                    Console.WriteLine("¡Usted puede ingresar libremente al parque!");
                    Console.WriteLine("WonderLand le desea una maravillosa estancia.");
                }

                else

                {

                    Console.WriteLine("Disculpe, debido a su estatura, no puede puede ingresar a ninguna atracción");

                }
                Console.ReadKey();
            }
        }
    }
}
