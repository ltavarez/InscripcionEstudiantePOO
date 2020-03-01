using System;
using System.Collections.Generic;
using System.Text;

namespace StructAndList
{
    class MateriaService
    {
        public static void AgregarMaterias(ref List<string> Materias)
        {
            Console.WriteLine("Introduzca el nombre de la materia");
            string nombre = Console.ReadLine();

            Materias.Add(nombre);

            Menu.MenuMaterias();


        }

        public static void ListarMaterias(List<string> Materias,bool Iswait)
        {

            int contador = 1;
            foreach (string item in Materias)
            {
                Console.WriteLine(contador + "- " + item);
                contador++;
            }

            if (Iswait)
            {
                Console.ReadKey();
            }



        }

        public static void EditarMaterias(ref List<string> Materias)
        {

            ListarMaterias(Materias,false);

            Console.WriteLine("Seleccione el estudiante que desea editar");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el nuevo nombre de la materia");
            string nombre = Console.ReadLine();

            Materias[index - 1] = nombre;

            Menu.MenuMaterias();


        }

        public static void BorrarMaterias(ref List<string> Materias)
        {

            ListarMaterias(Materias,false);

            Console.WriteLine("Seleccione la materia que desea eliminar");
            int index = Convert.ToInt32(Console.ReadLine());

            Materias.RemoveAt(index - 1);


            Menu.MenuMaterias();


        }
    }
}
