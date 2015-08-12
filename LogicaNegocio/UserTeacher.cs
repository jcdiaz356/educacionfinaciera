using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace LogicaNegocio
{
    public class UserTeacher
    {

        DataTable Teachers;
        public int insertUserTeacher(ModeloNegocio.UserTeacher ObjUserTeacher)
        {

            AccesoDatos.UserTeacher userTeacher = new AccesoDatos.UserTeacher();
            return userTeacher.insertUserTeacher(ObjUserTeacher);
        }

        public bool updateSelectTeacherForIduser(int idUser, int value)
        {
            AccesoDatos.UserTeacher userTeacher = new AccesoDatos.UserTeacher();
            return userTeacher.updateSelectTeacherForIduser(idUser, value);
        }

        public bool deleteTeachersForUserId(int iduser)
        {
            AccesoDatos.UserTeacher userSchool = new AccesoDatos.UserTeacher();
            return userSchool.deleteTeachersForUserId(iduser);
        }

        public List<ModeloNegocio.User> getAllTeacherForUser(int iduser)
        {
            //LogicaNegocioa.UsuarioLN objListaUsuario = new LogicaNegocio.UsuarioLN();
            List<ModeloNegocio.User> lista = new List<ModeloNegocio.User>();
            AccesoDatos.UserTeacher userTeacher = new AccesoDatos.UserTeacher();
            Teachers = userTeacher.getAllTeacherForIdUser(iduser);
            foreach (DataRow fila in Teachers.Rows)
            {
                ModeloNegocio.User teacher = new ModeloNegocio.User();
                teacher.id = int.Parse(fila["user_teacher_id"].ToString());
                teacher.FullName = fila["name"].ToString();
                lista.Add(teacher);
            }
            return lista;

        }
    }
}
