// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio #14");
//Crea una clase base Animal y dos clases derivadas Perro y Gato. 
//Implementa un método Hablar en cada clase que imprima un sonido diferente para cada animal.

Perro miPerro = new Perro();
Console.WriteLine("El perro hace:");
miPerro.Hablar();
 
Gato miGato = new Gato();
Console.WriteLine("El gato hace: ");
miGato.Hablar();

class Animal
{
    public virtual void Hablar()
    {
        Console.WriteLine("El animal hace un sonido.");
    }
}

class Perro : Animal
{
    public override void Hablar()
    {
        Console.WriteLine("¡Guau, guau!");
    }
}
class Gato : Animal
{
    public override void Hablar()
    {
        Console.WriteLine("¡Miau, miau!");
    }
}