using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloNegocio
{
    public class Sesion
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        int _temaid;

        public int Tema_id
        {
            get { return _temaid; }
            set { _temaid = value; }
        }

        string _sesion;
        public string NumSesion
        {
            get { return _sesion; }
            set { _sesion = value; }
        }
    }
}
