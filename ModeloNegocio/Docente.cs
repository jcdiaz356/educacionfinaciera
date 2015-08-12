using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloNegocio
{
    public class Docente
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

        private String _type_contract;

        public String TypeContract
        {
            get { return _type_contract; }
            set { _type_contract = value; }
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

        //private virtual TypeUser _typeUser;

        public virtual TypeUser typeUser
        {
            get;
            set;

        }

        private int _school_id;

        public int School_id
        {
            get { return _school_id; }
            set { _school_id = value; }
        }

        private List<TeacherGrade> _teacherGrade;

        public List<TeacherGrade> TeacherGrade
        {
            get { return _teacherGrade; }
            set { _teacherGrade = value; }
        }

        private List<TeacherCourse> _teacherCourse;

        public List<TeacherCourse> TeacherCourses
        {
            get { return _teacherCourse; }
            set { _teacherCourse = value; }
        }

        private List<TeacherTurn> _teacherTurn;

        public List<TeacherTurn> TeacherTurns
        {
            get { return _teacherTurn; }
            set { _teacherTurn = value; }
        }
    }
}
