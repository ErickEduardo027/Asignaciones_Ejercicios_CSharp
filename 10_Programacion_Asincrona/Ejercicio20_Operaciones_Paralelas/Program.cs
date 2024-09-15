// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Ejercicio #20\n");
//Escribe un programa que use Task.WhenAll para ejecutar tres tareas asíncronas que simulan la descarga de archivos (puedes usar Task.Delay para la simulación). 
//Muestra en la consola el tiempo total que tomó la descarga de todos los archivos.

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

Task tarea1 = DescargarArchivoAsync("Archivo1", 3000); 
Task tarea2 = DescargarArchivoAsync("Archivo2", 2000); 
Task tarea3 = DescargarArchivoAsync("Archivo3", 1000); 

await Task.WhenAll(tarea1, tarea2, tarea3);

stopwatch.Stop();
Console.WriteLine($"\nTiempo total de descarga: {stopwatch.ElapsedMilliseconds} ms");

static async Task DescargarArchivoAsync(string nombreArchivo, int tiempoDescarga)
{
    Console.WriteLine($"Iniciando descarga de {nombreArchivo}...");
    await Task.Delay(tiempoDescarga); 
    Console.WriteLine($"Descarga de {nombreArchivo} completada.");
}