// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio #21\n");
//Crea un objeto de tipo dynamic y asígnale diferentes tipos de datos (entero, cadena, objeto personalizado). 
//Invoca métodos en estos objetos y observa el comportamiento en tiempo de ejecución.

dynamic variableDinamica = 42;
Console.WriteLine($"El valor de la variable dinámica es: {variableDinamica}");
Console.WriteLine($"El tipo de dato es: {variableDinamica.GetType()}");

variableDinamica = "Hola Mundo";
Console.WriteLine($"\nEl valor de la variable dinámica es: {variableDinamica}");
Console.WriteLine($"El tipo de dato es: {variableDinamica.GetType()}");
Console.WriteLine($"Longitud de la cadena: {variableDinamica.Length}");

variableDinamica = new Persona { Nombre = "Carlos" };
Console.WriteLine($"\nEl valor de la variable dinámica es un objeto de tipo: {variableDinamica.GetType()}");
variableDinamica.Saludar(); 

try
{
    variableDinamica.MetodoInexistente(); 
}
catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
{
    Console.WriteLine($"\nError: {ex.Message}");
}

class Persona
{
    public string Nombre { get; set; }

    public void Saludar()
    {
        Console.WriteLine($"Hola, mi nombre es {Nombre}.");
    }
}