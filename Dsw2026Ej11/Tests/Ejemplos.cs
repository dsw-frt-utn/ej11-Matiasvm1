using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    public static void EjemploList()
    {
        Console.WriteLine("══════════════════════════════════");
        Console.WriteLine("         EJEMPLO LIST");
        Console.WriteLine("══════════════════════════════════");

        var casoList = new CasoList();

        // Agregar 3 alumnos
        var a1 = new Alumno(1, "Jose Villafañe", 8.5);
        var a2 = new Alumno(2, "Matias Villafañe", 9.2);
        var a3 = new Alumno(3, "Jimena Gomez", 7.8);

        casoList.Agregar(a1);
        casoList.Agregar(a2);
        casoList.Agregar(a3);

        // Listar alumnos
        Console.WriteLine("\n Lista de alumnos:");
        foreach (var a in casoList.ObtenerLista())
            Console.WriteLine($"  {a}");

        // Buscar alumno que existe
        Console.WriteLine("\n Buscar 'Matias Villafañe':");
        var encontrado = casoList.BuscarPorNombre("Matias Villafañe");
        Console.WriteLine(encontrado != null ? $"  Encontrado: {encontrado}" : "  No existe");

        // Buscar alumno que no existe
        Console.WriteLine("\n Buscar 'Emilio Luna Jandar':");
        var noEncontrado = casoList.BuscarPorNombre("Emilio Luna Jandar");
        Console.WriteLine(noEncontrado != null ? $"  Encontrado: {noEncontrado}" : "  No existe");

        // Eliminar un alumno (por objeto)
        casoList.Eliminar(a2);
        Console.WriteLine("\n Después de eliminar a Matias Villafañe:");
        foreach (var a in casoList.ObtenerLista())
            Console.WriteLine($"  {a}");

        // Eliminar el primer elemento (posición 0)
        casoList.EliminarEnPosicion(0);
        Console.WriteLine("\n  Después de eliminar el primer elemento:");
        foreach (var a in casoList.ObtenerLista())
            Console.WriteLine($"  {a}");
    }

    public static void EjemploDictionary()
    {
        Console.WriteLine("══════════════════════════════════");
        Console.WriteLine("       EJEMPLO DICTIONARY");
        Console.WriteLine("══════════════════════════════════");

        var casoDictionary = new CasoDictionary();

        // Agregar 3 alumnos con su legajo como clave
        casoDictionary.Agregar(1001, new Alumno(1, "Jose Villafañe", 8.5));
        casoDictionary.Agregar(1002, new Alumno(2, "Matias Villafañe", 9.2));
        casoDictionary.Agregar(1003, new Alumno(3, "Jimena Gomez", 7.8));

        // Listar alumnos
        Console.WriteLine("\n Diccionario de alumnos (Legajo - Alumno):");
        foreach (var par in casoDictionary.ObtenerDiccionario())
            Console.WriteLine($"  Legajo {par.Key}: {par.Value}");

        // Buscar alumno que existe
        Console.WriteLine("\nBuscar legajo 1002:");
        var encontrado = casoDictionary.BuscarPorLegajo(1002);
        Console.WriteLine(encontrado != null ? $"  Encontrado: {encontrado}" : "  No existe");

        // Buscar alumno que no existe
        Console.WriteLine("\nBuscar legajo 9999:");
        var noEncontrado = casoDictionary.BuscarPorLegajo(9999);
        Console.WriteLine(noEncontrado != null ? $"  Encontrado: {noEncontrado}" : "  No existe");

        // Eliminar un alumno por clave
        casoDictionary.Eliminar(1001);
        Console.WriteLine("\nDespués de eliminar legajo 1001:");
        foreach (var par in casoDictionary.ObtenerDiccionario())
            Console.WriteLine($"  Legajo {par.Key}: {par.Value}");
    }

    public static void EjemploLinq()
    {
        Console.WriteLine("══════════════════════════════════");
        Console.WriteLine("         EJEMPLO LINQ");
        Console.WriteLine("══════════════════════════════════");

        var casoLinq = new CasoLinq();

        Console.WriteLine($"\n1.Primer libro:  {casoLinq.GetPrimero().Titulo}");
        Console.WriteLine($"2.Último libro:  {casoLinq.GetUltimo().Titulo}");
        Console.WriteLine($"3.Total precios: {casoLinq.GetTotalPrecios():C}");
        Console.WriteLine($"4.Promedio:      {casoLinq.GetPromedioPrecios():C}");

        Console.WriteLine("\n5.Libros con Id > 15:");
        foreach (var l in casoLinq.GetListById())
            Console.WriteLine($"     [{l.Id}] {l.Titulo}");

        Console.WriteLine("\n6.Libros con título y precio:");
        foreach (var s in casoLinq.GetLibros())
            Console.WriteLine($"     {s}");

        Console.WriteLine($"\n7.Mayor precio:  {casoLinq.GetMayorPrecio().Titulo} - {casoLinq.GetMayorPrecio().Precio:C}");
        Console.WriteLine($"8.Menor precio:  {casoLinq.GetMenorPrecio().Titulo} - {casoLinq.GetMenorPrecio().Precio:C}");
        Console.WriteLine("\n9.Libros con precio mayor al promedio:");
        foreach (var l in casoLinq.GetMayorPromedio())
            Console.WriteLine($"     {l.Titulo} - {l.Precio:C}");

        Console.WriteLine("\n10.Libros ordenados por título (descendente):");
        foreach (var l in casoLinq.GetOrdenadosPorTituloDesc())
            Console.WriteLine($"     {l.Titulo}");
    }
}
