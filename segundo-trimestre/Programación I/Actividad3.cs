using System;

namespace Actividad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato = "";
            string nombre = "";
            string nombre2 = "";
            int Edad = 0;
            int Actividad = 0;
            int Tamaño = 0;
            double peso = 0.0;
            int opcion = 0;

            do
            {

                Console.WriteLine("¡Bienvenido al Centro de Atención para Mascotas!");
                Console.WriteLine("Indicanos tu nombre:");
                nombre = Console.ReadLine();

                Console.WriteLine("¡Perfecto {0}", nombre, "!");
                Console.WriteLine("Ahora necesitamos saber el nombre de tu mascota");
                nombre2 = Console.ReadLine();

                do
                {

                    Console.WriteLine("¿Su mascota es adult@ o cachorr@?");
                    Console.WriteLine("1 - Adulto");
                    Console.WriteLine("2 - Cachorro");
                    dato = Console.ReadLine();
                    Edad = Convert.ToInt32(dato);

                    switch (Edad)
                    {

                        case 1:

                            Console.WriteLine("Cómo considera la actividad de {0}", nombre2, "?");
                            Console.WriteLine("1 - Actividad Alta");
                            Console.WriteLine("2 - Actividad Normal");
                            Console.WriteLine("3 - Actividad Baja");
                            dato = Console.ReadLine();
                            Actividad = Convert.ToInt32(dato);


                            Console.WriteLine("¿Podrías incidarnos el peso de {0}", nombre2, "?");
                            dato = Console.ReadLine();
                            peso = Convert.ToDouble(dato);

                            //Tamaño Miniatura
                            if (peso <= 4 && peso >= 1)
                            {

                                switch (Actividad)
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer entre 60 - 115 gramos de alimento.");
                                        break;
                                    case 2:
                                        Console.WriteLine("Su perro debe comer entre 55 y 100 gramos.");
                                        break;
                                    case 3:
                                        Console.WriteLine("Su perro debe comer entre 45 - 85 gramos.");
                                        break;
                                }

                            }

                            //Tamaño Pequeño
                            if (peso <= 9 && peso >= 5)
                            {

                                switch (Actividad)
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer entre 115 - 190 gramos.");
                                        break;
                                    case 2:
                                        Console.WriteLine("Su perro debe comer entre 100 - 170 gramos.");
                                        break;
                                    case 3:
                                        Console.WriteLine("Su perro debe comer entre 85 - 145 gramos.");
                                        break;
                                }

                            }

                            //Tamaño Mediano
                            if (peso <= 15 && peso >= 10)
                            {

                                switch (Actividad)
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer entre 190 - 255 gramos.");
                                        break;
                                    case 2:
                                        Console.WriteLine("Su perro debe comer entre 170 - 255 gramos.");
                                        break;
                                    case 3:
                                        Console.WriteLine("Su perro debe comer entre 145 - 195 gramos.");
                                        break;
                                }

                            }

                            //Tamaño Grande 1
                            if (peso <= 25 && peso >= 16)
                            {

                                switch (Actividad)
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer entre 255 - 380 gramos.");
                                        break;
                                    case 2:
                                        Console.WriteLine("Su perro debe comer entre 255 - 330 gramos.");
                                        break;
                                    case 3:
                                        Console.WriteLine("Su perro debe comer entre 195 - 195 gramos.");
                                        break;
                                }

                            }

                            //Tamaño Grande 2
                            if (peso <= 40 && peso >= 26)
                            {

                                switch (Actividad)
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer entre 380 - 535  gramos.");
                                        break;
                                    case 2:
                                        Console.WriteLine("Su perro debe comer entre 330 - 475 gramos.");
                                        break;
                                    case 3:
                                        Console.WriteLine("Su perro debe comer entre 285 - 410 gramos.");
                                        break;
                                }

                            }

                            //Tamaño Grande 3
                            if (peso <= 55 && peso >= 41)
                            {

                                switch (Actividad)
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer entre 535 - 680 gramos.");
                                        break;
                                    case 2:
                                        Console.WriteLine("Su perro debe comer entre 475 - 600 gramos.");
                                        break;
                                    case 3:
                                        Console.WriteLine("Su perro debe comer entre 410 - 520 gramos.");
                                        break;
                                }

                            }

                            //Tamaño Grande 4
                            if (peso <= 70 && peso >= 56)
                            {

                                switch (Actividad)
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer entre 680 - 820 gramos.");
                                        break;
                                    case 2:
                                        Console.WriteLine("Su perro debe comer entre 600 - 720 gramos.");
                                        break;
                                    case 3:
                                        Console.WriteLine("Su perro debe comer entre 520 - 620 gramos.");
                                        break;
                                }

                            }

                            //Tamaño Grande 5
                            if (peso <= 90 && peso >= 71)
                            {

                                switch (Actividad)
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer entre 820 - 985 gramos.");
                                        break;
                                    case 2:
                                        Console.WriteLine("Su perro debe comer entre 720 - 870 gramos.");
                                        break;
                                    case 3:
                                        Console.WriteLine("Su perro debe comer entre 620 - 750 gramos.");
                                        break;
                                }

                            }

                            //Tamaño Grande 6
                            if (peso >= 91)
                            {

                                switch (Actividad)
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer mas de 985 gramos.");
                                        break;
                                    case 2:
                                        Console.WriteLine("Su perro debe comer mas de 870 gramos.");
                                        break;
                                    case 3:
                                        Console.WriteLine("Su perro debe comer mas de 750 gramos.");
                                        break;
                                }

                            }

                            break;

                        case 2:

                            Console.WriteLine("¿Podrías incidarnos el peso de {0}", nombre2, "?");
                            dato = Console.ReadLine();
                            peso = Convert.ToDouble(dato);

                            //Tamaño Miniatura
                            if (peso <= 2)
                            {

                                Console.WriteLine("Su mascota debe comer entre 50 - 60 gramos");

                            }

                            //Tamaño Pequeño
                            if (peso <= 5 && peso >= 2)
                            {

                                Console.WriteLine("Su mascota debe comer entre 95 - 155 gramos.");

                            }

                            //Tamaño Pequeño 2
                            if (peso <= 9 && peso >= 5)
                            {

                                Console.WriteLine("Su mascota debe comer entre 155 - 195 gramos.");

                            }

                            //Tamaño Mediano 
                            if (peso <= 24 && peso >= 10)
                            {

                                Console.WriteLine("Su mascota debe comer entre 215 - 285 gramos.");

                            }

                            //Tamaño Grande 1
                            if (peso <= 25)
                            {

                                Console.WriteLine("Su mascota debe comer entre 270 - 375 gramos.");

                            }

                            //Tamaño Grande 2
                            if (peso <= 32 && peso >= 26)
                            {

                                Console.WriteLine("Su mascota debe comer entre 350 - 450 gramos.");

                            }

                            //Tamaño Grande 3
                            if (peso <= 40 && peso >= 33)
                            {

                                Console.WriteLine("Su mascota debe comer entre 355 - 530 gramos.");

                            }

                            //Tamaño Grande 4
                            if (peso <= 50 && peso >= 41)
                            {

                                Console.WriteLine("Su mascota debe comer entre 405 - 625 gramos.");

                            }

                            //Tamaño Grande 5
                            if (peso <= 60 && peso >= 51)
                            {

                                Console.WriteLine("Su mascota debe comer entre 450 - 685 gramos.");

                            }

                            //Tamaño Grande 6
                            if (peso <= 70 && peso >= 61)
                            {

                                Console.WriteLine("Su mascota debe comer entre 485 - 670 gramos.");

                            }

                            //Tamaño Grande 7
                            if (peso <= 90 && peso >= 71)
                            {

                                Console.WriteLine("Su mascota debe comer entre 580 gramos.");

                            }

                            //Tamaño Grande 8
                            if (peso >= 91)
                            {

                                Console.WriteLine("Su mascota debe comer más de 580 gramos.");

                            }

                            break;


                        default:

                            Console.WriteLine("El dato que introdujo es incorrecto");

                            break;

                    }


                    Console.WriteLine("Si desea continuar escriba 1 De lo contrario escriba 3");
                    dato = Console.ReadLine();
                    opcion = Convert.ToInt32(dato);



                } while (Edad !=3);

                    Console.WriteLine("¿Está seguro?");
                    Console.WriteLine("Si desea continuar escriba 1, sino escriba 4");
                    dato = Console.ReadLine();
                    opcion = Convert.ToInt32(dato);

                    Console.Clear();

            } while (opcion != 4);
        }
    }
}

