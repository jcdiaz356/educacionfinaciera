using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace LogicaNegocio
{
    public class UserSchool
    {
        DataTable Schools; 

        public int insertUserSchool(ModeloNegocio.UserSchool ObjUserSchool)
        {

            AccesoDatos.UserSchool userSchool = new AccesoDatos.UserSchool();
            return userSchool.insertUserSchool(ObjUserSchool);
        }

        public bool updateSelectSchoolForIduser(int idSchool, int value)
        {
            AccesoDatos.UserSchool userSchool = new AccesoDatos.UserSchool();
            return userSchool.updateSelectSchoolForIduser(idSchool, value);
        }

        public bool deleteSchoolsForUserId(int iduser)
        {
            AccesoDatos.UserSchool userSchool = new AccesoDatos.UserSchool();
            return userSchool.deleteSchoolsForUserId(iduser);
        }

        public List<ModeloNegocio.School> getAllSchoolForUser(int iduser)
        {
            //LogicaNegocioa.UsuarioLN objListaUsuario = new LogicaNegocio.UsuarioLN();
            List<ModeloNegocio.School> lista = new List<ModeloNegocio.School>();
            AccesoDatos.UserSchool userSchool = new AccesoDatos.UserSchool();
            Schools = userSchool.getAllSchoolForIdUser(iduser);
            foreach (DataRow fila in Schools.Rows)
            {
                ModeloNegocio.School school = new ModeloNegocio.School();
                school.id = int.Parse(fila["school_id"].ToString());
                school.Nombre = fila["nombre"].ToString();
                lista.Add(school);
            }
            return lista;

        }

        public DataTable countTeacherForSchool()
        {

            AccesoDatos.UserSchool userSchoolAD = new AccesoDatos.UserSchool();
            return userSchoolAD.getCountTeacherForSchool();
        }
    }
}
