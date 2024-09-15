// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio #24\n");
//Crea una clase Persona con una propiedad opcional Apellido. Escribe un programa que acceda a la propiedad Apellido usando el operador condicional nulo (?.) para evitar una excepción si el valor es null.

Persona persona1 = new Persona("Carlos");
Persona persona2 = new Persona("Ana", "Perez");

Console.WriteLine($"Persona 1: {persona1.Nombre} {persona1.Apellido?.ToUpper() ?? "(Sin apellido)"}");
Console.WriteLine($"Persona 2: {persona2.Nombre} {persona2.Apellido?.ToUpper() ?? "(Sin apellido)"}");

class Persona
{
    public string Nombre { get; set; }
    public string? Apellido { get; set; }  

    public Persona(string nombre, string? apellido = null)
    {
        Nombre = nombre;
        Apellido = apellido;
    }
}