// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio #8\n");
//Implementa una función que reciba una lista de estudiantes (nombre y edad) y utilice una expresión lambda para filtrar aquellos mayores de 18 años.

List<Estudiante> Estudiantes = new List<Estudiante>
{
        new Estudiante { Nombre = "Juan", Edad = 17 },
        new Estudiante { Nombre = "Ana", Edad = 19 },
        new Estudiante { Nombre = "Carlos", Edad = 22 },
        new Estudiante { Nombre = "Laura", Edad = 16 },
        new Estudiante { Nombre = "Pedro", Edad = 21 }
};

List<Estudiante> mayoresDeEdad = Estudiantes.FindAll(e => e.Edad > 18).ToList();

Console.WriteLine("Estudiantes mayores de 18 años: ");
foreach (var item in mayoresDeEdad)
{
    Console.WriteLine($"{item.Nombre}, {item.Edad} años");
}

class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
}