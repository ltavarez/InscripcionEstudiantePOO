using System;
using System.Collections.Generic;
using System.Text;

namespace StructAndList
{
    class Menu
    {
        public static List<string> Materias = new List<string>();
        public static List<string> Estudiantes = new List<string>();
        public static List<Inscripcion> Inscripciones = new List<Inscripcion>();

        public static IncripcionServices IncripcionServices = new IncripcionServices();
        public static EstudianteService EstudianteService = new EstudianteService();
        public static MateriaService MateriaService = new MateriaService();

        public static void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("Selecciona la opcion deseada: \n1-Mantenmientos materias \n2-Mantenimeintos estudiantes \n3-incribir \n4-listar inscripciones \n5-salir");
            int menu = Convert.ToInt32(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    MenuMaterias();
                    break;
                case 2:
                    MenuEstudiantes();
                    break;
                case 3:
                    IncripcionServices.Inscribir(Estudiantes,Materias,ref Inscripciones);
                    break;
                case 4:
                    IncripcionServices.ListarInscripciones(Inscripciones);
                    break;
                case 5:
                    Console.WriteLine("Gracias");
                    Console.ReadKey();
                    break;
            }
        }

        public static void MenuMaterias()
        {
            Console.Clear();
            Console.WriteLine("Selecciona la opcion deseada: \n1-agregar Materias \n2-editar Materias \n3-listar Materias \n 4- borrar Materias \n 5-volver atras");
            int menu = Convert.ToInt32(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    MateriaService.AgregarMaterias(ref Materias);
                    break;
                case 2:
                    MateriaService.EditarMaterias(ref Materias);
                    break;
                case 3:
                    MateriaService.ListarMaterias(Materias,true);
                    MenuMaterias();
                    break;
                case 4:
                    MateriaService.BorrarMaterias(ref Materias);
                    break;
                case 5:
                    MenuPrincipal();
                    break;
            }
        }

        public static void MenuEstudiantes()
        {
            Console.Clear();
            Console.WriteLine("Selecciona la opcion deseada: \n1-agregar estudiantes \n2-editar estudiantes \n3-listar estudiantes \n 4- borrar estudiantes \n 5-volver atras");
            int menu = Convert.ToInt32(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    EstudianteService.AgregarEstudiantes(ref Estudiantes);
                    break;
                case 2:
                    EstudianteService.EditarEstudiantes(ref Estudiantes);
                    break;
                case 3:
                   EstudianteService.ListarEstudiantes(Estudiantes,true);
                    MenuEstudiantes();
                    break;
                case 4:
                   EstudianteService.BorrarEstudiantes(ref Estudiantes);
                    break;
                case 5:
                    MenuPrincipal();
                    break;
            }
        }

    }
}
