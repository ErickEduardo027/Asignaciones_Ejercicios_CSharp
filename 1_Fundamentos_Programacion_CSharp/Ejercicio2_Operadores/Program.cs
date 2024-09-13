// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio #2\n");
//Crea una calculadora simple que realice operaciones básicas (suma, resta, multiplicación, división).
//Asegúrate de manejar excepciones para evitar la división por cero.

Console.WriteLine("Ingresa el numero 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresa el numero 2: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Que oparacion le gustaria realizar?: (+,-,*,/)");
string operacion = Console.ReadLine();
double resultado;

switch (operacion)
{
    case "+":
        resultado = num1 + num2;
        Console.WriteLine($"El resultado de la suma es: {resultado}");
        break;
    case "-":
        resultado = num1 - num2;
        Console.WriteLine($"El resultado de la resta es: {resultado}");
        break;
    case "*":
        resultado = num1 * num2;
        Console.WriteLine($"El resultado de la multiplicacion es: {resultado}");
        break;
    case "/":
        if ( num2 != 0)
        {
            resultado = num1 / num2;
            Console.WriteLine($"El resultado de la division es: {resultado}");
            break;
        }
        else Console.WriteLine("No se puede dividir entre 0");
        break;
}