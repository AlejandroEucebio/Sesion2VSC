using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("\t SISTEMAS DE NOTAS");
            Console.WriteLine("****************************************************");

            double suma_notas = 0;
            int cantidad_cursos = 0;
            double nota_max = -1;
            double nota_min = 21;
            string curso_mayor = "";
            string curso_menor = "";
            string continuar = "s";
            string reporte_notas = "";

            while (continuar.ToLower() == "s")
            {
                Console.WriteLine("Curso Nro " + (cantidad_cursos + 1));

                Console.Write("Ingresar curso: ");
                string curso = Console.ReadLine();

                Console.Write("Ingrese nota [0-20]: ");
                double nota = double.Parse(Console.ReadLine());

                if (nota < 0 || nota > 20 || curso == "")
                {
                    Console.WriteLine("Error: La nota es entre 0 y 20 y el curso no puede estar vacío");
                }
                else
                {
                    suma_notas += nota;
                    cantidad_cursos++;

                    reporte_notas += $"{curso}: {nota}\n";

                    // Nota máxima
                    if (nota > nota_max)
                    {
                        nota_max = nota;
                        curso_mayor = curso;
                    }

                    // Nota mínima
                    if (nota < nota_min)
                    {
                        nota_min = nota;
                        curso_menor = curso;
                    }

                    Console.WriteLine("REGISTRO EXITOSO......!!!");
                }

                Console.Write("Desea continuar (s/n): ");
                continuar = Console.ReadLine();
            }

            Console.WriteLine("****************************************************");
            Console.WriteLine("\t REPORTE DE NOTAS");
            Console.WriteLine("****************************************************");

            if (cantidad_cursos > 0)
            {
                double promedio = suma_notas / cantidad_cursos;

                Console.WriteLine("Cursos:");
                Console.WriteLine(reporte_notas);
                Console.WriteLine("Cursos Evaluados: " + cantidad_cursos);
                Console.WriteLine("Promedio: " + promedio);
                Console.WriteLine("La nota máxima: " + curso_mayor + " " + nota_max);
                Console.WriteLine("La nota mínima: " + curso_menor + " " + nota_min);

                if (promedio >= 13)
                {
                    Console.WriteLine("Condición académica = APROBADO");
                }
                else if (promedio >= 10.5)
                {
                    Console.WriteLine("Condición académica: RECUPERACIÓN");
                }
                else
                {
                    Console.WriteLine("Condición académica: DESAPROBADO");
                }
            }
            else
            {
                Console.WriteLine("No se registraron cursos.");
            }
        }
    }
}
