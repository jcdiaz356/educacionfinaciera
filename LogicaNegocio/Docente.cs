using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicaNegocio
{
    public class Docente
    {

        public List<ModeloNegocio.Docente> getAllDocente(int registroAMostrar, int registroAEmpezar)
        {
            //LogicaNegocioa.UsuarioLN objListaUsuario = new LogicaNegocio.UsuarioLN();
            AccesoDatos.Docente docente = new AccesoDatos.Docente();

            return docente.getAllDocente(registroAMostrar, registroAEmpezar);

        }

        public List<ModeloNegocio.Docente> getAllDocente()
        {
            //LogicaNegocioa.UsuarioLN objListaUsuario = new LogicaNegocio.UsuarioLN();
            AccesoDatos.Docente docente = new AccesoDatos.Docente();

            return docente.getAllDocente();

        }
        public ModeloNegocio.Docente getDocenteId(int docente_id)
        {

            AccesoDatos.Docente docente = new AccesoDatos.Docente();

            return docente.getDocenteId(docente_id);

        }
        public int insertDocente(ModeloNegocio.Docente ObjDocente)
        {
            AccesoDatos.Docente docente = new AccesoDatos.Docente();

            return docente.insertDocente(ObjDocente);
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

        public void getDocente(ref ModeloNegocio.Docente ObjDocente)
        {
            AccesoDatos.User user = new AccesoDatos.User();
            ModeloNegocio.User ObjUser = new ModeloNegocio.User();
            ObjUser = user.getUser(ObjDocente.id);
            ObjDocente.FullName = ObjUser.FullName;
            ObjDocente.Codigo = ObjUser.Codigo;
            ObjDocente.Email = ObjUser.Email;
            ObjDocente.Telefono = ObjUser.Telefono;
            ObjDocente.FechaCreado = ObjUser.FechaCreado;
            ObjDocente.FechaActualizado = ObjUser.FechaActualizado;
            ObjDocente.typeUser = ObjUser.typeUser;
            ObjDocente.TypeContract = ObjUser.TypeContract;

            LogicaNegocio.UserSchool asesorSchool = new LogicaNegocio.UserSchool();
            List<ModeloNegocio.School> lista = new List<ModeloNegocio.School>();
            lista = asesorSchool.getAllSchoolForUser(ObjDocente.id);
            foreach (ModeloNegocio.School School_list in lista)
            {
                ObjDocente.School_id = School_list.id;
            }

            List<ModeloNegocio.TeacherGrade> lista1 = new List<ModeloNegocio.TeacherGrade>();
            LogicaNegocio.TeacherGrade teacherGrade = new LogicaNegocio.TeacherGrade();
            lista1 = teacherGrade.getAllTeacherGradeForUser(ObjDocente.id);
            ObjDocente.TeacherGrade = lista1;

            List<ModeloNegocio.TeacherCourse> lista2 = new List<ModeloNegocio.TeacherCourse>();
            LogicaNegocio.TeacherCourse teacherCourse = new LogicaNegocio.TeacherCourse();
            lista2 = teacherCourse.getAllTeacherCourseForUser(ObjDocente.id);
            ObjDocente.TeacherCourses = lista2;

            List<ModeloNegocio.TeacherTurn> lista3 = new List<ModeloNegocio.TeacherTurn>();
            LogicaNegocio.TeacherTurn teacherTurn = new LogicaNegocio.TeacherTurn();
            lista3 = teacherTurn.getAllTeacherTurnForUser(ObjDocente.id);
            ObjDocente.TeacherTurns = lista3;
        }


        public bool updateDocente(ModeloNegocio.Docente ObjDocente)
        {

            AccesoDatos.Docente docente = new AccesoDatos.Docente();
            return docente.updateDocente(ObjDocente);

        }


        public int countRowsDocentes()
        {
            AccesoDatos.Docente docente = new AccesoDatos.Docente();
            return docente.countRowsDocentes();

        }
    }
}
