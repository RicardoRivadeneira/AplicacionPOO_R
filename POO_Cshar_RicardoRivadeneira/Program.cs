using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Cshar_RicardoRivadeneira
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t *POO en C#*");
            Console.Write(">Ingrese el nombre del empleado: ");
            string nombreEmpleado = Console.ReadLine();

            Console.Write(">Ingrese el salario del empleado: ");
            double salarioEmpleado;
            while (!double.TryParse(Console.ReadLine(), out salarioEmpleado))
            {
                Console.Write(">Por favor, ingrese un valor numérico para el salario: ");
            }

            Empleado empleado = new Empleado(nombreEmpleado, salarioEmpleado);

            Console.Write(">Ingrese el nombre del gerente: ");
            string nombreGerente = Console.ReadLine();

            Console.Write(">Ingrese el salario del gerente: ");
            double salarioGerente;
            while (!double.TryParse(Console.ReadLine(), out salarioGerente))
            {
                Console.Write(">Por favor, ingrese un valor numérico para el salario: ");
            }

            Console.Write(">Ingrese el departamento que supervisa el gerente: ");
            string departamentoGerente = Console.ReadLine();

            Console.WriteLine("\n\t\t*Resultados*");
            Gerente gerente = new Gerente(nombreGerente, salarioGerente, departamentoGerente);

            MostrarInformacion(empleado);
            MostrarInformacion(gerente);
        }

        static void MostrarInformacion(IMostrarInformacion info)
        {
            info.MostrarInformacion();
        }
    }
}

