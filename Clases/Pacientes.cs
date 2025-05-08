using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Pacientes
    {
        private string Nombre;
        private string Apellido;
        private string Dni;
        private string Celular;

        public string nombrepaciente
        {
            set { Nombre = value; }
            get { return Nombre; }

        }
        
        public string apellidopaciente
        {
            set { Apellido = value; }
            get { return Apellido; }
        }

        public string celularpaciente
        {
            set { Celular = value; }
            get { return Celular; }
             

        }

        public string dnipaciente
        {
            set { Dni = value; }
            get { return Dni; }
        }
        public Pacientes ()
        {

        }
        public Pacientes(string nombre, string apellido, string celular, string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Celular = celular;
            Dni = dni;

        }
    }

    
    

}
