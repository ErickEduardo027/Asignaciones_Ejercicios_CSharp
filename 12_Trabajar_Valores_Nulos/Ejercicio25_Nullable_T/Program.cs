// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio #25\n");
//Implementa un programa que permita introducir la edad de una persona usando int?. 
//Verifica si la edad es nula antes de proceder a mostrarla en la consola.

int? edad = null;
Console.WriteLine("Por favor, introduce tu edad (deja en blanco si no quieres proporcionar la edad):");
string entrada = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(entrada))
{
    if (int.TryParse(entrada, out int edadIngresada))
    {
        edad = edadIngresada;
    }
    else
    {
        Console.WriteLine("Valor inválido. La edad no es un número válido.");
        return;
    }
}

if (edad.HasValue)
{
    Console.WriteLine($"La edad ingresada es: {edad.Value} años.");
}
else
{
    Console.WriteLine("No se ha proporcionado la edad.");
}