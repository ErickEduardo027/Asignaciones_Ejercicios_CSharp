// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio #27\n");
//Usa la clase Recurso creada en el ejercicio anterior en un bloque using para asegurarte de que los recursos se liberen automáticamente al finalizar el bloque.

using (Recurso recurso = new Recurso())
{
    recurso.UsarRecurso();
} 

Console.WriteLine("El recurso ha sido liberado automáticamente al salir del bloque using.");

class Recurso : IDisposable
{
    private bool _disposed = false;

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                Console.WriteLine("Liberando recursos administrados...");
            }

            Console.WriteLine("Liberando recursos no administrados...");

            _disposed = true;
        }
    }

    ~Recurso()
    {
        Dispose(false);
    }

    public void UsarRecurso()
    {
        if (_disposed)
        {
            throw new ObjectDisposedException("Recurso");
        }

        Console.WriteLine("Usando el recurso...");
    }
}