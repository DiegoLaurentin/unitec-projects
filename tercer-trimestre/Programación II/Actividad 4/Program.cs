using System;

namespace KFC_APP
{
    class Program
    {
        static void Main(string[] args)
        {
            int dato;
            int codigo;

                Console.Clear();

                Console.WriteLine("Bienvenido al sistema de KFC");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Seleccione la actividad que desea hacer:");
                Console.WriteLine("1 | Ingresar un nuevo empleado.");
                Console.WriteLine("2 | Realizar Factura");
                Console.WriteLine("0 | Salir");
                Console.Write("Actividad: ");
                dato = Int32.Parse(Console.ReadLine());

            switch (dato)
            {
                case 1:

                    Empleado NewEmpleado = new Empleado();

                    do
                    {

                        Console.Write("Código de acceso: ");
                        codigo = Int32.Parse(Console.ReadLine());

                        if (codigo == 75748)
                        {
                            Console.Clear();
                            Console.WriteLine("Código verificado");
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("Ingrese los datos del empleado");
                            Console.Write("Nombre y Apellido: ");
                            NewEmpleado.Nombre = Console.ReadLine();
                            Console.Clear();
                            Console.Write("Cédula: ");
                            NewEmpleado.Cedula = Int32.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.Write("Edad: ");
                            NewEmpleado.Edad = Int32.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.Write("Fecha de Nacimiento: ");
                            NewEmpleado.FechaNacimiento = Console.ReadLine();
                            Console.Clear();
                            Console.Write("Sueldo: Bs.S. ");
                            NewEmpleado.Sueldo = Int32.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.Write("Puesto Laboral: ");
                            NewEmpleado.Puesto = Console.ReadLine();
                            Console.Clear();
                            Console.Write("Ficha del Empleado: ");
                            NewEmpleado.FichaEmpleado = Int32.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("Datos del nuevo empleado: " + NewEmpleado.nuevoEmpleado());
                        }

                    } while (codigo != 75748);

                    break;

                case 2:
                    Persona Persona = new Persona();
                    Clase_Producto producto = new Clase_Producto();
                    Factura factura = new Factura();

                    Console.Clear();
                    Console.WriteLine("Por favor ingrese la clave de acceso");
                    do
                    {
                        factura.Clave = Int32.Parse(Console.ReadLine());

                        if (factura.Clave == 1234)
                        {
                            Console.Clear();
                            Console.WriteLine("La clave es correcta");
                            Console.WriteLine("--------------------------------------------");

                            Console.Clear();
                            Console.WriteLine("Ingrese su nombre:");
                            Persona.Nombre = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Ingrese su edad:");
                            Persona.Edad = Int32.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("Ingrese su Cédula (sin puntos):");
                            Console.Write("C.I. ");
                            Persona.Cedula = Int32.Parse(Console.ReadLine());
                            Console.Clear();

                            do
                            {
                                Console.WriteLine("Ingrese el monto de los productos");
                                Console.Write("Bs.S: ");
                                producto.Alimento = Int32.Parse(Console.ReadLine());

                                if (producto.Alimento <= 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Vuelva a ingresa el producto");
                                }
                                else

                                    Console.Clear();
                                producto.Monto = producto.Monto + producto.Alimento;

                            } while (producto.Alimento != 0);

                            factura.Iva = producto.Monto * 0.20;
                            factura.Total = producto.Monto + factura.Iva;

                            do
                            {
                                Console.Clear();
                                Console.WriteLine("KFC | Factura");
                                Console.WriteLine("Nombre: {0}", Persona.Nombre);
                                Console.WriteLine("Cédula: {0}", Persona.Cedula);
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Monto Bs.S = {0}", producto.Monto);
                                Console.WriteLine("IVA Bs.S = {0}", factura.Iva);
                                Console.WriteLine("TOTAL Bs.S = {0}", factura.Total);
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Precione 0 para salir");
                                dato = Int32.Parse(Console.ReadLine());

                            } while (dato != 0);
                            Console.Clear();
                            Console.WriteLine("Puede cerrar la consola.");

                        }
                        else
                        {

                            Console.Clear();
                            Console.WriteLine("La clave es incorrecta");
                            Console.WriteLine("Ingrésela nuevamente:");

                        }
                    } while (factura.Clave != 1234);

             break;

            } 
        }
    }
}
