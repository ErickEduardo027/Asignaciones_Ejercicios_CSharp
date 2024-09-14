// See https://aka.ms/new-console-template for more information
using Ejercicio6_Delegados;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Ejercicio #6\n");
//Crea un delegado que represente una operación aritmética y úsalo para realizar una suma y una multiplicación.
Console.WriteLine("Ingresa el numero 1: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresa el numero 2: ");
int y = int.Parse(Console.ReadLine());

operacionesAritmeticas operacionesAritmeticas = new operacionesAritmeticas();

delegado operaciones = new delegado(operacionesAritmeticas.suma);

int resultadoSuma = operaciones(x, y);
Console.WriteLine($"El resultado de la suma es: {resultadoSuma}");

operaciones = new delegado(operacionesAritmeticas.multiplicacion);

int resultadoMultiplicacion = operaciones(x, y);
Console.WriteLine($"El resultado de la multiplicacion es: {resultadoMultiplicacion}");