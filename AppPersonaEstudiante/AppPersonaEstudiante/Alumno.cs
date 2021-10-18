using System;
using System.Collections.Generic;
using System.Text;

namespace AppPersonaEstudiante
{
    class Alumno : Persona

    {
        public string matricula;
        public string carrera;
        
       public Alumno( string matricula, string carrera)
        {
            this.matricula = matricula;
            this.carrera = carrera;
        }



    }
}
