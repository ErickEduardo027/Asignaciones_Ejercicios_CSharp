// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio #16\n");
//Crea una clase genérica Caja<T> que pueda almacenar cualquier tipo de objeto. 
//Implementa métodos para añadir y obtener objetos de la caja.

Caja<int> cajaDeEnteros = new Caja<int>();
cajaDeEnteros.Añadir(56);
cajaDeEnteros.Añadir(72);
Console.WriteLine($"La caja contiene {cajaDeEnteros.ContarObjetos()} objetos.");
Console.WriteLine($"Se ha obtenido el objeto: {cajaDeEnteros.Obtener()}");
Console.WriteLine($"La caja ahora contiene {cajaDeEnteros.ContarObjetos()} objetos.");

Caja<string> cajaDeCadenas = new Caja<string>();
cajaDeCadenas.Añadir("Erick");
cajaDeCadenas.Añadir("Eduardo");
Console.WriteLine($"La caja contiene {cajaDeCadenas.ContarObjetos()} objetos.");
Console.WriteLine($"Se ha obtenido el objeto: {cajaDeCadenas.Obtener()}");
Console.WriteLine($"La caja ahora contiene {cajaDeCadenas.ContarObjetos()} objetos.");

class Caja<T>
{
    private List<T> objetos;  

    public Caja()
    {
        objetos = new List<T>();
    }

    public void Añadir(T objeto)
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
    public int ContarObjetos()
    {
        return objetos.Count;
    }
}