// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio #13\n");
//Crea un programa con un bucle que genere números aleatorios del 1 al 100. 
//Introduce de manera intencional un error lógico y usa las herramientas de depuración de Visual Studio para identificar y corregir el error.
Console.WriteLine("Generador de números aleatorios del 1 al 100");

Random random = new Random();
int contador = 0;

while (contador <= 10) // Error lógico: Este bucle genera 11 números en lugar de 10.
{
    int numeroAleatorio = random.Next(1, 101); 
    Console.WriteLine(numeroAleatorio);
    contador++;
}

Console.WriteLine("Fin del generador de números.");

//para arreglar el error logico solo abria que cambiar el "<=" por "<" y listo.
//muy facil la verdad =).