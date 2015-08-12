using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloNegocio
{
    public class User
    {
        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        private String _codigo;
        public String Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private String _fullName;

        public String FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        private String _telefono;

        public String Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        private int _type;

        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }
        private String _email;

        public String Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private String _grupo;
        public String Grupo
        {
            get { return _grupo; }
            set { _grupo = value; }
        }

        private DateTime _fCreado;
        public DateTime FechaCreado
        {
            get { return _fCreado; }
            set { _fCreado = value; }
        }

        private DateTime _fActualizado;
        public DateTime FechaActualizado
        {
            get { return _fActualizado; }
            set { _fActualizado = value; }
        }

        private String _password;

        public String Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private byte _selection ;

        public byte Selection
        {
            get { return _selection; }
            set { _selection = value; }
        }

        private String _type_contract;

        public String TypeContract
        {
            get { return _type_contract; }
            set { _type_contract = value; }
        }

        //private virtual TypeUser _typeUser;

        public virtual TypeUser typeUser
        {
            get;
            set;

        }



    }
}

