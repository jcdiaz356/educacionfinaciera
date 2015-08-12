using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloNegocio
{
    class Distrito
    {
        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private int _id_provincia;
        public int Id_provincia
        {
            get { return _id_provincia; }
            set { _id_provincia = value; }
        }
    }
}
