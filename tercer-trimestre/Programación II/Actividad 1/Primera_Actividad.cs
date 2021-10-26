using System;

namespace Primera_Actividad___Programación_II
{
    class Program
    {
        static void Main(string[] args)
        {
            string empleado = "";
            string dato = "";
            int option = 0;
            string ficha_empleado = "";
            int hora = 0;
            int horas_trabajadas = 0;
            int valor_hora = 1000;
            int pago = 0;

            Console.Clear();

            do
                {
                Console.Clear();
                Console.WriteLine("¡Bienvenido al Astra Sinergy!");
                Console.WriteLine("Introduzca Nombre y apellido");
                empleado = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Perfecto {0}", empleado);
                Console.WriteLine("Introduzca su Ficha de Ingreso");
                ficha_empleado = Console.ReadLine();

                Console.Clear();

                Console.WriteLine("Confirmamos que su ficha de ingreso es {0}", ficha_empleado);
                Console.WriteLine("Ingrese hora de Acceso - Formato 24 horas (No agregar minutos)");
                    dato = Console.ReadLine();
                    hora = Convert.ToInt32(dato);
                Console.Clear();

                if (hora >= 8)
                {
                    Console.WriteLine("Ingreso con retardo - Acceso Denegado");
                }
                else
                {

                Console.WriteLine("Ingrese sus horas trabajadas la semana anterior");
                    dato = Console.ReadLine();
                    horas_trabajadas = Convert.ToInt32(dato);
                    pago = horas_trabajadas * valor_hora;

                    if (horas_trabajadas >= 60)
                    {
                        Console.WriteLine("Dato Incorrecto. Horas máximas sobrepasadas");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Su pago es de Bs.S {0}", pago);

                        Console.WriteLine("Desea ver la información General?");
                        Console.WriteLine("Si = 1 | No = 2");
                        dato = Console.ReadLine();
                        option = Convert.ToInt32(dato);


                        // Información General

                        Console.Clear();
                        Console.WriteLine("Información:");
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("Empleado:{0}", empleado);
                        Console.WriteLine("Ficha: {0}", ficha_empleado);
                        Console.WriteLine("Hora de entrada {0}", hora);
                        Console.WriteLine("Pago de la semana anterior: {0}", pago);
                    }
                }

                Console.WriteLine("---------------------------");
                Console.WriteLine("Si desea continuar escriba 1 De lo contrario escriba 0");
                dato = Console.ReadLine();
                option = Convert.ToInt32(dato);


            } while (option != 0);



        }
    }
}
