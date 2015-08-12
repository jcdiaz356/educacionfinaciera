using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LogicaNegocio
{
    public class Distrito
    {
        AccesoDatos.Distrito ObjDistritolAD;

        public DataTable getAllDistritos(int idProvincia)
        {
            ObjDistritolAD = new AccesoDatos.Distrito();
            return ObjDistritolAD.getAllDistritos(idProvincia);
        }
    }
}
