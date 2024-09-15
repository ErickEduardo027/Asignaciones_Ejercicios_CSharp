// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio #26\n");
//Crea una clase Recurso que implemente la interfaz IDisposable. En el método Dispose, libera los recursos y muestra un mensaje indicando que el recurso ha sido liberado.
using (Recurso recurso = new Recurso())
{
    recurso.UsarRecurso();
} 

try
{
    Recurso otroRecurso = new Recurso();
    otroRecurso.Dispose(); 
    otroRecurso.UsarRecurso(); 
}
catch (ObjectDisposedException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
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