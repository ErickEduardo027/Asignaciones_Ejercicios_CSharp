// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio #7\n");
/*Usa una expresión lambda para filtrar una lista de números y seleccionar solo los números pares.*/

List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };

List<int> numerosPares = numeros.FindAll(n => n % 2 == 0).ToList();

Console.WriteLine("Números pares en la lista:");
foreach (int num in numerosPares) Console.WriteLine(num);