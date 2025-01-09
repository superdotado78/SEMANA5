using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lista de asignaturas
        List<string> asignaturas = new List<string>
        {
            "Matemáticas", "Física", "Química", "Historia", "Lengua"
        };

        // Mostrar mensaje para cada asignatura
        foreach (var asignatura in asignaturas)
        {
            Console.WriteLine($"Yo estudio {asignatura}");
        }
    }
}
