// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio #10");
//	Usa el método de extensión creado en el ejercicio anterior para contar las vocales en una oración introducida por el usuario.

Console.WriteLine("Por favor, introduce una oración:");
string oracion = Console.ReadLine();
int cantidadVocales = oracion.ContarVocales();

Console.WriteLine($"La oración introducida tiene {cantidadVocales} vocales.");

public static class Extension
{
    public static int ContarVocales(this string texto)
    {
        int contador = 0;
        char[] vocales = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        foreach (char letra in texto)
        {
            if (Array.Exists(vocales, v => v == letra))
            {
                contador++;
            }
        }
        return contador;
    }
}