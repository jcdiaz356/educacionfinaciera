using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using AccesoDatos;

namespace LogicaNegocio
{
    public class Ugel
    {
        AccesoDatos.Ugel ObjUgelAD;

        public DataTable getAllUgels()
        {
            ObjUgelAD = new AccesoDatos.Ugel();
            return ObjUgelAD.getAllUgels();
        }
    }
}
