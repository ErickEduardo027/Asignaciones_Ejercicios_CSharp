// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio #9\n");
//Crea un método de extensión que extienda la clase string para contar cuántas veces aparece una vocal en un texto.

string texto = "Hola me llamo Erick Eduardo y me gusta mucho la yaroa con mucho queso y carne.";
int cantidadVocales = texto.ContarVocales();

Console.WriteLine($"El texto contiene {cantidadVocales} vocales.");

public static class Extension
{
    public static int ContarVocales(this string texto)
    {
        int contador = 0;
        char[] vocales = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };//inclui las vocales mayusculas para contarlas (Si hay)

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
