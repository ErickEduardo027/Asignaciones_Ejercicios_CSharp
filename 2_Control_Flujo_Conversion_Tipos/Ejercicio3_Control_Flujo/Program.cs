// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio #3\n");
//Crea un programa que lea un número del usuario e imprima si es par o impar.
//Utiliza una estructura if-else para decidir qué mensaje mostrar.
Console.WriteLine("Ingresa un numero: ");
int numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("El numero es par");
}
else Console.WriteLine("El numero es impar");