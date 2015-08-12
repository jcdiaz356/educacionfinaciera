using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AccesoDatos
{
    public class TeacherCourse
    {
        private SqlConnection Conn;
        private SqlCommand Cmd;
        private SqlDataReader Dtr;
        private DataTable Dt;

        public TeacherCourse()
        {
            AccesoDatos.Conexion objConexion = new AccesoDatos.Conexion();
            Conn = objConexion.abrirConexion();
        }
        public int insertTeacherCourse(ModeloNegocio.TeacherCourse ObjTeacherCourse)
        {

            try
            {
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_ING_TEACHER_COURSE";
                Cmd.Parameters.Add("@user_teacher_id", SqlDbType.Int).Value = ObjTeacherCourse.UserTeacheId;
                Cmd.Parameters.Add("@course", SqlDbType.VarChar).Value = ObjTeacherCourse.Course;


                Cmd.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;

                Cmd.ExecuteNonQuery();

                ObjTeacherCourse.Id = Convert.ToInt32(Cmd.Parameters["@id"].Value);

                Conn.Close();
                return ObjTeacherCourse.Id;
            }
            catch (Exception e)
            {
                // Console.WriteLine("{0} Problem insert.", e);
                //throw new Exception("Error en Acceso a Datos: InsertarMonto.", e);
                return 0;
            }
            //throw new NotImplementedException();


        }

        public DataTable getAllTeacherCourseForIdUser(int iduser)
        {
            Dt = new DataTable();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_GET_TEACHER_COURSE_FOR_USER_ID";
                Cmd.Parameters.Add("@iduser", SqlDbType.Int).Value = iduser;
                Dtr = Cmd.ExecuteReader();
                Dt.Constraints.Clear();
                Dt.BeginLoadData();
                Dt.Load(Dtr);
                Dtr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return Dt;

        }


        public bool deleteTeacherCourse(int idTeacher)
        {
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_ELIMINA_TEACHER_COURSES";
                Cmd.Parameters.Add("@idTeacher", SqlDbType.Int).Value = idTeacher;
                Cmd.ExecuteNonQuery();
                Conn.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
                Console.WriteLine("{0} Exception caught.", e);
            }

        }
    }
}
