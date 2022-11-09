using capaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio
{
    public class Negocio
    {
        public bool probarConexion()
        {
            DatosConexion nuevaConexion;
            nuevaConexion = new DatosConexion();

            bool exitosa = nuevaConexion.Abrirconexion();
            nuevaConexion.Cerrarconexion();

            return exitosa;
        }
    }
}
