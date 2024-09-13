// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio #4\n");
// Escribe un programa que convierta un número entero a un número decimal y luego lo convierta de nuevo a entero.
// Explica cuándo puede ser útil realizar conversiones explícitas.
Console.WriteLine("Ingresa un número entero: ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine($"El número entero es: {numero}");

double numeroDecimal = numero;
Console.WriteLine("El número decimal es: " + numeroDecimal);

int numeroConvertido = (int)numeroDecimal;
Console.WriteLine("El número convertido de nuevo a entero es: " + numeroConvertido);

