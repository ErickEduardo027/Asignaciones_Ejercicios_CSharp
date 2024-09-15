// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio #11\n");
//Dada una lista de enteros, usa LINQ para seleccionar solo los números impares y ordenarlos en orden descendente.
List<int> numeros = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
List<int> numerosImpares = numeros.Where(n => n % 2 != 0).ToList();
List<int> numerosImparesDescendentes = numerosImpares.OrderByDescending(n => n).ToList();

foreach (var item in numerosImparesDescendentes)
{
    Console.WriteLine($"Los numeros impares de esta lista son: {item}");
}