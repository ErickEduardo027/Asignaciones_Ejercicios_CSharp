// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio #12");
//Crea una clase Producto con propiedades Nombre, Precio y Categoría.
//Luego, usa LINQ para agrupar los productos por categoría y calcular el precio promedio por grupo.

List<Productos> producto = new List<Productos>()
        {
            new Productos { Nombre = "Laptop", Precio = 850, Categoria = "Electrónica" },
            new Productos { Nombre = "Teléfono", Precio = 500, Categoria = "Electrónica" },
            new Productos { Nombre = "Mesa", Precio = 120, Categoria = "Muebles" },
            new Productos { Nombre = "Silla", Precio = 60, Categoria = "Muebles" },
            new Productos { Nombre = "Cafetera", Precio = 45, Categoria = "Hogar" },
            new Productos { Nombre = "Zapatillas", Precio = 75, Categoria = "Ropa" },
            new Productos { Nombre = "Televisor", Precio = 600, Categoria = "Electrónica" },
            new Productos { Nombre = "Libro", Precio = 20, Categoria = "Libros" },
            new Productos { Nombre = "Auriculares", Precio = 30, Categoria = "Accesorios" },
            new Productos { Nombre = "Camiseta", Precio = 25, Categoria = "Ropa" }
        };

var agrupacionPorCategoria = producto
    .GroupBy(p => p.Categoria)
    .Select(g => new
    {
        Categoria = g.Key,
        PrecioPromedio = g.Average(p => p.Precio)
    })
    .ToList();

Console.WriteLine("Precio promedio por categoría:");
foreach (var grupo in agrupacionPorCategoria)
{
    Console.WriteLine($"Categoría: {grupo.Categoria}, Precio Promedio: {grupo.PrecioPromedio:C} US$");
}
 
class Productos
{
    public string Nombre { get; set; }
    public int Precio { get; set; }
    public string Categoria { get; set; }

}
