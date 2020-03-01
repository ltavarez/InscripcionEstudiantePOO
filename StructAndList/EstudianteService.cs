using System;
using System.Collections.Generic;
using System.Text;

namespace StructAndList
{
    class EstudianteService
    {
        public static void AgregarEstudiantes(ref List<string> Estudiantes)
        {
            Console.WriteLine("Introduzca el nombre del estudiante");
            string nombre = Console.ReadLine();

            Estudiantes.Add(nombre);

            Menu.MenuEstudiantes();


        }

        public static void ListarEstudiantes( List<string> Estudiantes,bool Iswait)
        {

            int contador = 1;
            foreach (string item in Estudiantes)
            {
                Console.WriteLine(contador + "- " + item);
                contador++;
            }

            if (Iswait)
            {
                Console.ReadKey();
            }



        }

        public static void EditarEstudiantes(ref List<string> Estudiantes)
        {

            ListarEstudiantes(Estudiantes,false);

            Console.WriteLine("Seleccione el estudiante que desea editar");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el nuevo nombre del estudiante");
            string nombre = Console.ReadLine();

            Estudiantes[index - 1] = nombre;

            Menu.MenuEstudiantes();


        }

        public static void BorrarEstudiantes(ref List<string> Estudiantes)
        {

            ListarEstudiantes(Estudiantes,false);

            Console.WriteLine("Seleccione el estudiante que desea eliminar");
            int index = Convert.ToInt32(Console.ReadLine());

            Estudiantes.RemoveAt(index - 1);


            Menu.MenuEstudiantes();


        }
    }
}
