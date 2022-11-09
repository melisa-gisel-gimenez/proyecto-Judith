using capa_Datos;
using capa_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio
{
    public class NegLibros
    {
        AdministrarTablas DatosObjLibros = new AdministrarTablas();
        public int AbmLibros(string accion, Libros objlibros)
        {
            return DatosObjLibros.AbmLibros(accion, objlibros);
        }

        public DataSet listadoLibros(string cual)
        {
            return DatosObjLibros.listadoLibros(cual);
        }

    }
}
