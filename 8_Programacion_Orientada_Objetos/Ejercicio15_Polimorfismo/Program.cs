// See https://aka.ms/new-console-template for more information
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Ejercicio #15");
//Usa polimorfismo para permitir que tanto Perro como Gato sean tratados como Animal en una lista y que cada uno pueda "hablar" correctamente al recorrer la lista.

List<Animal> animales = new List<Animal>()
        {
            new Perro { Nombre = "Firulais" },
            new Gato { Nombre = "Michi" },
            new Perro { Nombre = "Negro" },
            new Gato { Nombre = "Pelusa" }
        };

foreach (var animal in animales)
{
    Console.Write($"{animal.Nombre}: ");
    animal.Hablar();
}

class Animal
{
    public string Nombre { get; set; }

    public virtual void Hablar()
    {
        Console.WriteLine("El animal hace un sonido.");
    }
}

class Perro : Animal
{
    public override void Hablar()
    {
        Console.WriteLine("El perro dice: ¡Guau, guau!");
    }
}

class Gato : Animal
{
    public override void Hablar()
    {
        Console.WriteLine("El gato dice: ¡Miau, miau!");
    }
}

