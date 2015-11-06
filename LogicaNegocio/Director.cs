using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LogicaNegocio
{
   public  class Director
    {


       public List<ModeloNegocio.Director> getAllDirector(int registroAMostrar, int registroAEmpezar, int tipoUsuario)
        {
            //LogicaNegocioa.UsuarioLN objListaUsuario = new LogicaNegocio.UsuarioLN();
            AccesoDatos.Director director = new AccesoDatos.Director();

            return director.getAllDirector(registroAMostrar, registroAEmpezar, tipoUsuario);

        }

       public List<ModeloNegocio.Director> getAllDirector(int tipoUsuario)
        {
            //LogicaNegocioa.UsuarioLN objListaUsuario = new LogicaNegocio.UsuarioLN();
            AccesoDatos.Director director = new AccesoDatos.Director();

            return director.getAllDirector(tipoUsuario);

        }

       public ModeloNegocio.Director getDirectorId(int director_id)
       {

           AccesoDatos.Director docente = new AccesoDatos.Director();

           return docente.getDirectorId(director_id);

       }

        public int insertDirector(ModeloNegocio.Director ObjDirector)
        {

            AccesoDatos.Director docente = new AccesoDatos.Director();

            return docente.insertDirector(ObjDirector);
        }

        public bool deleteDocente(int idTeacher)
        {
            AccesoDatos.Docente docente;
            AccesoDatos.UserSchool userSchool;

            userSchool = new AccesoDatos.UserSchool();
            userSchool.deleteSchoolsForUserId(idTeacher);

            docente = new AccesoDatos.Docente();
            docente.deleteTeacher(idTeacher);
            return true;
        }

        public void getDirector(ref ModeloNegocio.Director ObjDirector)
        {
            AccesoDatos.User user = new AccesoDatos.User();
            ModeloNegocio.User ObjUser = new ModeloNegocio.User();
            ObjUser = user.getUser(ObjDirector.id);
            ObjDirector.FullName = ObjUser.FullName;
            ObjDirector.Codigo = ObjUser.Codigo;
            ObjDirector.Email = ObjUser.Email;
            ObjDirector.Telefono = ObjUser.Telefono;
            ObjDirector.FechaCreado = ObjUser.FechaCreado;
            ObjDirector.FechaActualizado = ObjUser.FechaActualizado;
            ObjDirector.typeUser = ObjUser.typeUser;
            //ObjDirector.TypeContract = ObjUser.TypeContract;

            LogicaNegocio.UserSchool asesorSchool = new LogicaNegocio.UserSchool();
            List<ModeloNegocio.School> lista = new List<ModeloNegocio.School>();
            lista = asesorSchool.getAllSchoolForUser(ObjDirector.id);
            foreach (ModeloNegocio.School School_list in lista)
            {
                ObjDirector.School_id = School_list.id;
            }

            List<ModeloNegocio.TeacherGrade> lista1 = new List<ModeloNegocio.TeacherGrade>();
            LogicaNegocio.TeacherGrade teacherGrade = new LogicaNegocio.TeacherGrade();
            lista1 = teacherGrade.getAllTeacherGradeForUser(ObjDirector.id);
            ObjDirector.TeacherGrade = lista1;

            List<ModeloNegocio.TeacherCourse> lista2 = new List<ModeloNegocio.TeacherCourse>();
            LogicaNegocio.TeacherCourse teacherCourse = new LogicaNegocio.TeacherCourse();
            lista2 = teacherCourse.getAllTeacherCourseForUser(ObjDirector.id);
            ObjDirector.TeacherCourses = lista2;

            List<ModeloNegocio.TeacherTurn> lista3 = new List<ModeloNegocio.TeacherTurn>();
            LogicaNegocio.TeacherTurn teacherTurn = new LogicaNegocio.TeacherTurn();
            lista3 = teacherTurn.getAllTeacherTurnForUser(ObjDirector.id);
            ObjDirector.TeacherTurns = lista3;
        }


        public bool updateDocente(ModeloNegocio.Director ObjDirector)
        {

            AccesoDatos.Director director = new AccesoDatos.Director();
            return director.updateDirector(ObjDirector);

        }


        public int countRows(int tipoUsuario)
        {
            AccesoDatos.Director docente = new AccesoDatos.Director();
            return docente.countRows(tipoUsuario);

        }

        public DataTable getReportAllDirector()
        {

            AccesoDatos.Director docente = new AccesoDatos.Director();
            return docente.getReportAllSubDirector();
        }

        public DataTable getReportAllSubDirector()
        {

            AccesoDatos.Director docente = new AccesoDatos.Director();
            return docente.getReportAllSubDirector();
        }
    }
   
}
