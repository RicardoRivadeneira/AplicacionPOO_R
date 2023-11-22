using System;

public class Empleado : IMostrarInformacion
{
    public string Nombre { get; set; }
    public double Salario { get; set; }

    public Empleado(string nombre, double salario)
    {
        Nombre = nombre;
        Salario = salario;
    }

    public double CalcularSalarioAnual()
    {
        return Salario * 12;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine(">Empleado");
        Console.WriteLine($"Nombre: {Nombre}, Salario: ${Salario}, Salario Anual: ${CalcularSalarioAnual()}");
    }
}
