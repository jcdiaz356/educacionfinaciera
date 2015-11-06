using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LogicaNegocio
{
    public class Asesor
    {

        public List<ModeloNegocio.Asesor> getAllAsesors(int registroAMostrar,int registroAEmpezar)
        {
            //LogicaNegocioa.UsuarioLN objListaUsuario = new LogicaNegocio.UsuarioLN();
            AccesoDatos.Asesor asesor = new AccesoDatos.Asesor();

            return asesor.getAllAsesors(registroAMostrar, registroAEmpezar);

        }

        public List<ModeloNegocio.Asesor> getAllAsesors()
        {
            //LogicaNegocioa.UsuarioLN objListaUsuario = new LogicaNegocio.UsuarioLN();
            AccesoDatos.Asesor asesor = new AccesoDatos.Asesor();
            return asesor.getAllAsesors();
        }

        public int insertAsesor(ModeloNegocio.Asesor ObjAsesor)
        {
            AccesoDatos.Asesor asesor = new AccesoDatos.Asesor();

            return asesor.insertAsesor(ObjAsesor);
        }

        public ModeloNegocio.Asesor getAsesorId(int assesor_id)
        {
            AccesoDatos.Asesor asesor = new AccesoDatos.Asesor();

            return asesor.getAsesorId(assesor_id);
        }


        public ModeloNegocio.Asesor getAsesorCode(string code)
        {
            AccesoDatos.Asesor asesor = new AccesoDatos.Asesor();
            return asesor.getAsesorCode(code);
        }

        public void getAsesor(ref ModeloNegocio.Asesor ObjAsesor)
        {
            AccesoDatos.User user = new AccesoDatos.User();
            ModeloNegocio.User ObjUser = new ModeloNegocio.User();
            ObjUser = user.getUser(ObjAsesor.id);
            ObjAsesor.FullName = ObjUser.FullName;
            ObjAsesor.Codigo = ObjUser.Codigo;
            ObjAsesor.Email = ObjUser.Email;
            ObjAsesor.Telefono = ObjUser.Telefono;
            ObjAsesor.FechaCreado = ObjUser.FechaCreado;
            ObjAsesor.FechaActualizado = ObjUser.FechaActualizado;
            ObjAsesor.typeUser = ObjUser.typeUser;
            ObjAsesor.Grupo = ObjUser.Grupo;

            List<ModeloNegocio.School> lista = new List<ModeloNegocio.School>();
            LogicaNegocio.UserSchool asesorSchool = new LogicaNegocio.UserSchool();
            lista = asesorSchool.getAllSchoolForUser(ObjAsesor.id);
            ObjAsesor.Schools = lista;

            List<ModeloNegocio.User> lista1 = new List<ModeloNegocio.User>();
            LogicaNegocio.UserTeacher asesorTeacher = new LogicaNegocio.UserTeacher();
            lista1 = asesorTeacher.getAllTeacherForUser(ObjAsesor.id);
            ObjAsesor.Teachers = lista1;
        }

        public bool setPasswordUser(int assesor_id, string email, string password)
        {
            AccesoDatos.Asesor asesor = new AccesoDatos.Asesor();

            return asesor.setPasswordUser( assesor_id,  email,  password);
        }

        public bool deleteAsesor(int iduser)
        {
            AccesoDatos.Asesor asesor;
            AccesoDatos.UserTeacher userTeacher;
            AccesoDatos.UserSchool userSchool;

            List<ModeloNegocio.School> lista = new List<ModeloNegocio.School>();
            List<ModeloNegocio.User> lista1 = new List<ModeloNegocio.User>();
            ModeloNegocio.Asesor Asesor = new ModeloNegocio.Asesor();

            LogicaNegocio.UserSchool asesorSchool = new LogicaNegocio.UserSchool();
            LogicaNegocio.UserTeacher asesorTeacher = new LogicaNegocio.UserTeacher();

            lista = asesorSchool.getAllSchoolForUser(iduser);
            lista1 = asesorTeacher.getAllTeacherForUser(iduser);

            foreach(ModeloNegocio.School schoolLista in lista)
            {
                userSchool = new AccesoDatos.UserSchool();
                userSchool.updateSelectSchoolForIduser(schoolLista.id, 0);
            }

            foreach (ModeloNegocio.User teacherLista in lista1)
            {
                userTeacher = new AccesoDatos.UserTeacher();
                userTeacher.updateSelectTeacherForIduser(teacherLista.id, 0);
            }
            //Asesor = asesor.getAsesorId(iduser);
            asesor = new AccesoDatos.Asesor();
            asesor.deleteAsesor(iduser);

            userTeacher = new AccesoDatos.UserTeacher();
            userTeacher.deleteTeachersForUserId(iduser);

            userSchool = new AccesoDatos.UserSchool();
            userSchool.deleteSchoolsForUserId(iduser);

            return true;
        }

        public bool updateAsesor (ModeloNegocio.Asesor ObjAsesor)
        {
            AccesoDatos.Asesor asesor = new AccesoDatos.Asesor();

            return asesor.updateAsesor(ObjAsesor);
        }

        public int countRowsAsesores()
        {
            AccesoDatos.Asesor asesor = new AccesoDatos.Asesor();
            return asesor.countRowsAsesores();
        }

        public DataTable getReportAllAsesor()
        {
            AccesoDatos.Asesor asesor = new AccesoDatos.Asesor();
            return asesor.getReportAllAsesor();
        }
    }
}
