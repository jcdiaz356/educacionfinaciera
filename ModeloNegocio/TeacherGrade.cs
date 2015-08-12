using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloNegocio
{
    public class TeacherGrade
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        int _userTeacheId;

        public int UserTeacheId
        {
            get { return _userTeacheId; }
            set { _userTeacheId = value; }
        }
        string _grade;

        public string Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }

        DateTime _created_at;

        public DateTime Created_at
        {
            get { return _created_at; }
            set { _created_at = value; }
        }
        DateTime _updated_at;

        public DateTime Updated_at
        {
            get { return _updated_at; }
            set { _updated_at = value; }
        }

        private string _seccion;

        public string Seccion
        {
            get { return _seccion; }
            set { _seccion = value; }
        }

        private int _num_alumnos;

        public int Num_alumnos
        {
            get { return _num_alumnos; }
            set { _num_alumnos = value; }
        }
    }
}
