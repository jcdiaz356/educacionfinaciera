using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloNegocio
{
    public class MicroredDocente
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private int _microred_id;

        public int Microred_id
        {
            get { return _microred_id; }
            set { _microred_id = value; }
        }
        private int _docente_id;

        public int Docente_id
        {
            get { return _docente_id; }
            set { _docente_id = value; }
        }
        private DateTime _created_at;

        public DateTime Created_at
        {
            get { return _created_at; }
            set { _created_at = value; }
        }
        private DateTime _updated_at;

        public DateTime Updated_at
        {
            get { return _updated_at; }
            set { _updated_at = value; }
        }


    }
}
