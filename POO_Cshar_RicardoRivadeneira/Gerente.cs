using System;

public class Gerente : Empleado, IMostrarInformacion
{
    public string Departamento { get; set; }

    public Gerente(string nombre, double salario, string departamento) : base(nombre, salario)
    {
        Departamento = departamento;
    }

    public new void MostrarInformacion()
    {
        Console.WriteLine("\n>Gerente");
        Console.WriteLine($"Nombre: {Nombre}, Salario: ${Salario}, Departamento: {Departamento}, Salario Anual: ${CalcularSalarioAnual()}");
    }
}
