using System;

namespace AppPersonaEstudiante
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Persona perso = new Persona("", "");
            Console.WriteLine("Nombre:" + perso.nombre);
            Console.WriteLine("Fecha de nacimiento:" + perso.nacimiento);

            Alumno al = new Alumno("", "");
            Console.WriteLine("Matricula:" + al.matricula);
            Console.WriteLine("Carrera:" + al.carrera);


           

          
        }
    }
}
