using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC_APP
{
    public class Persona
    {
        private string nombre;
        private int cedula;
        private int edad;
        private string fechaNacimiento;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Cedula { get => cedula; set => cedula = value; }

        public Persona ()
        {
            Console.Clear();
        }
    }
}
