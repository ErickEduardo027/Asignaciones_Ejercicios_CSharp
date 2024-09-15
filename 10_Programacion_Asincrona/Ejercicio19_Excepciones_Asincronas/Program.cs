// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio #19\n");
//Modifica el ejercicio anterior para incluir un bloque try-catch que capture cualquier excepción y la imprima en la consola.
try
{
    Console.WriteLine("Llamando a operaciones largas de forma concurrente...\n");

    Task<int> tarea1 = OperacionLargaAsync();
    Task<int> tarea2 = OperacionLargaAsync();

    int resultado1 = await tarea1;
    int resultado2 = await tarea2;

    Console.WriteLine($"\nResultado de la primera operación: {resultado1}");
    Console.WriteLine($"Resultado de la segunda operación: {resultado2}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocurrió un error: {ex.Message}");
}

static async Task<int> OperacionLargaAsync()
{
    Random random = new Random();
    Console.WriteLine("Iniciando operación larga...");
    await Task.Delay(2000); 
    int resultado = random.Next(1, 101); 
    Console.WriteLine("Operación larga finalizada.");
    return resultado;
}