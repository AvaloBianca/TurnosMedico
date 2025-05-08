using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Listados
    {
        private List<Pacientes> turnos;
        private DataTable tabla;
        public DataTable Lista { get; set; }

        public Listados()
        {
            Lista = new DataTable();
            Lista.TableName = "Listados";
            Lista.Columns.Add("Nombre");
            Lista.Columns.Add("Apellido");
            Lista.Columns.Add("Celular");
            Lista.Columns.Add("Dni");

            LeerArchivo();
        }

        private void LeerArchivo()
        {
            if (System.IO.File.Exists("Listados.xml"))
            {
                Lista.ReadXml("Listados.xml");
            }
        }

        public void Insert(Pacientes Pacientes)
        {
            Lista.Rows.Add(); //agrego renglon vacio
            int NuevoRenglon = Lista.Rows.Count - 1;
            Lista.Rows[NuevoRenglon]["Nombre"] = Pacientes.nombrepaciente;
            Lista.Rows[NuevoRenglon]["Apellido"] = Pacientes.apellidopaciente;
            Lista.Rows[NuevoRenglon]["Celular"] = Pacientes.celularpaciente;
            Lista.Rows[NuevoRenglon]["Dni"] = Pacientes.dnipaciente;

            

            //tabla en el archivo
            Lista.WriteXml("Listados.xml");
        }
    }
}
