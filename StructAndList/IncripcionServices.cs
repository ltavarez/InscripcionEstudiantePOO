using System;
using System.Collections.Generic;
using System.Text;

namespace StructAndList
{
    class IncripcionServices
    {
        public static List<string> MateriasSeleccionada = new List<string>();
        public static void Inscribir(List<string> Estudiantes,List<string> materias,ref List<Inscripcion> Inscripciones)
        {

            MateriasSeleccionada = new List<string>();

            if (Estudiantes.Count > 0)
            {
                ListarEstudiantes(false);
                Console.WriteLine("Seleccione al estudiantes que desea inscribir");
                int index = Convert.ToInt32(Console.ReadLine());

                string nombreEstudiante = Estudiantes[index - 1];

                InscribirMateria(materias);

                Inscripcion nuevaInscripcion = new Inscripcion();

                nuevaInscripcion.NombreEstudiantes = nombreEstudiante;
                nuevaInscripcion.Materias = MateriasSeleccionada;

                Inscripciones.Add(nuevaInscripcion);
                Console.WriteLine("Inscricion completada");
                Console.ReadKey();
                Menu.MenuPrincipal();

            }
            else
            {
                Console.WriteLine("No hay estudiantes en el sistema");
                Console.ReadKey();
                Menu.MenuPrincipal();

            }


        }

        public static void InscribirMateria(List<string> Materias )
        {
            if (Materias.Count > 0)
            {
                ListarMaterias(false);
                Console.WriteLine("Seleccione la materia que desea inscribir");
                int indexMateria = Convert.ToInt32(Console.ReadLine());

                string materia = Materias[indexMateria - 1];

                if (IsValidMateria(materia))
                {

                    MateriasSeleccionada.Add(materia);
                    Console.WriteLine("Desea inscribir otra materia: s/n");
                    string other = Console.ReadLine();

                    if (other == "s")
                    {
                        InscribirMateria(Materias);
                    }

                }
                else
                {
                    Console.WriteLine("Ya selecciono esta materia");
                    Console.WriteLine("Desea inscribir otra materia: s/n");
                    string other = Console.ReadLine();

                    if (other == "s")
                    {
                        InscribirMateria(Materias);
                    }
                }



            }
            else
            {
                Console.WriteLine("No hay materias en el sistema");
                Console.ReadKey();
                Menu.MenuPrincipal();
            }
        }

        public static void ListarInscripciones(List<Inscripcion> Inscripciones)
        {

            foreach (Inscripcion item in Inscripciones)
            {
                int contador = 1;
                Console.WriteLine("El nombre del estudiante es: " + item.NombreEstudiantes);
                Console.WriteLine("Materias seleccionadas");

                foreach (string materia in item.Materias)
                {
                    Console.WriteLine(contador + "- " + materia);
                    contador++;
                }
            }

            Console.ReadKey();
            Menu.MenuPrincipal();
        }

        public static bool IsValidMateria(string materia)
        {
            bool isValid = true;

            foreach (string item in MateriasSeleccionada)
            {
                if (item == materia)
                {
                    isValid = false;
                    break;
                }
            }

            return isValid;


        }
    }
}
