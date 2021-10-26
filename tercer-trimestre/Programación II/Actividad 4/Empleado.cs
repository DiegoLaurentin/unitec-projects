using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC_APP
{
    class Empleado : Persona
    {
        private double sueldo;
        private string puesto;
        private int fichaEmpleado;

        public double Sueldo { get => sueldo; set => sueldo = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public int FichaEmpleado { get => fichaEmpleado; set => fichaEmpleado = value; }

        public string nuevoEmpleado()
        {
            return ("\nNombre: " + Nombre + "\nEdad: " + Edad + " \nFecha de Nacimiento: " + FechaNacimiento + " \nSueldo: " + sueldo + " \nPuesto Laboral: " + Puesto + "\nFicha Empleado: " + FichaEmpleado);
           
        }
    }
}
