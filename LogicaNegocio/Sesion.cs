using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace LogicaNegocio
{
    public class Sesion
    {
        DataTable Sesiones;
        public List<ModeloNegocio.Sesion> getAllSesionsForTem(int tema_id)
        {
            List<ModeloNegocio.Sesion> lista = new List<ModeloNegocio.Sesion>();
            AccesoDatos.Sesiones sesionAD = new AccesoDatos.Sesiones();
            Sesiones = sesionAD.getAllSesionsForTem(tema_id);
            foreach (DataRow fila in Sesiones.Rows)
            {
                ModeloNegocio.Sesion sesionMN = new ModeloNegocio.Sesion();
                sesionMN.Id = int.Parse(fila["id"].ToString());
                sesionMN.NumSesion = fila["nrosesion"].ToString();
                lista.Add(sesionMN);
            }
            return lista;

        }


        public ModeloNegocio.Sesion getSesionId(int sesion_id)
        {
            AccesoDatos.Sesiones sesion = new AccesoDatos.Sesiones();

            return sesion.getSesionId(sesion_id);
        }
    }
}
