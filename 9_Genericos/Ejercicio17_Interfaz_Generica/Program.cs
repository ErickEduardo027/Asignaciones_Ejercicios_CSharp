// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio #17");
//Crea una interfaz genérica IContenedor<T> que defina métodos para agregar y obtener elementos. 
//Implementa esta interfaz en la clase Caja<T>.

IContenedor<int> cajaDeEnteros = new Caja<int>();
cajaDeEnteros.Agregar(23984);
cajaDeEnteros.Agregar(43257);
Console.WriteLine($"La caja contiene {cajaDeEnteros.ContarElementos()} objetos.");
Console.WriteLine($"Se ha obtenido el objeto: {cajaDeEnteros.Obtener()}");
Console.WriteLine($"La caja ahora contiene {cajaDeEnteros.ContarElementos()} objetos.");

IContenedor<string> cajaDeCadenas = new Caja<string>();
cajaDeCadenas.Agregar("Erick Eduardo");
cajaDeCadenas.Agregar("Santana Segura");
Console.WriteLine($"La caja contiene {cajaDeCadenas.ContarElementos()} objetos.");
Console.WriteLine($"Se ha obtenido el objeto: {cajaDeCadenas.Obtener()}");
Console.WriteLine($"La caja ahora contiene {cajaDeCadenas.ContarElementos()} objetos.");

public interface IContenedor<T>
{
    void Agregar(T item);     
    T Obtener();              
    int ContarElementos();     
}

public class Caja<T> : IContenedor<T>
{
    private List<T> objetos;  

    public Caja()
    {
        objetos = new List<T>();
    }
    public void Agregar(T objeto)
    {
        objetos.Add(objeto);
        Console.WriteLine($"{objeto} ha sido añadido a la caja.");
    }
    public T Obtener()
    {
        if (objetos.Count > 0)
        {
            T ultimoObjeto = objetos[objetos.Count - 1];
            objetos.RemoveAt(objetos.Count - 1);  
            return ultimoObjeto;
        }
        else
        {
            throw new InvalidOperationException("La caja está vacía.");
        }
    }
    public int ContarElementos()
    {
        return objetos.Count;
    }
}
