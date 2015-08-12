using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloNegocio
{
    public class MicroredSchool
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
        private int _school_id;

        public int School_id
        {
            get { return _school_id; }
            set { _school_id = value; }
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
