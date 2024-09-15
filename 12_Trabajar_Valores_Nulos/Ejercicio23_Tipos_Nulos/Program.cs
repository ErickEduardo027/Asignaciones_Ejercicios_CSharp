// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio #23\n");
//Declara una variable de tipo int? y asígnale un valor nulo. Usa el operador de fusión nula (??) para asignar un valor por defecto en caso de que la variable sea null.
int? numero = null;
int valorPorDefecto = numero ?? 100; 

Console.WriteLine($"El valor de la variable es: {valorPorDefecto}");