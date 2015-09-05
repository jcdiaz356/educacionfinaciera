using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AccesoDatos
{
    public class TeacherGrade
    {

        private SqlConnection Conn;
        private SqlCommand Cmd;
        private SqlDataReader Dtr;
        private DataTable Dt;

        public TeacherGrade()
        {
            AccesoDatos.Conexion objConexion = new AccesoDatos.Conexion();
            Conn = objConexion.abrirConexion();
        }
        public int insertTeacherGrade(ModeloNegocio.TeacherGrade ObjTeacherGrade)
        {

            try
            {
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_ING_TEACHER_GRADE";
                Cmd.Parameters.Add("@user_teacher_id", SqlDbType.Int).Value = ObjTeacherGrade.UserTeacheId;
                Cmd.Parameters.Add("@grade", SqlDbType.VarChar).Value = ObjTeacherGrade.Grade;
                Cmd.Parameters.Add("@seccion", SqlDbType.VarChar).Value = ObjTeacherGrade.Seccion;
                Cmd.Parameters.Add("@num_alumnos", SqlDbType.VarChar).Value = ObjTeacherGrade.Num_alumnos;


                Cmd.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;

                Cmd.ExecuteNonQuery();

                ObjTeacherGrade.Id = Convert.ToInt32(Cmd.Parameters["@id"].Value);

                Conn.Close();
                return ObjTeacherGrade.Id;
            }
            catch (Exception e)
            {
                // Console.WriteLine("{0} Problem insert.", e);
                //throw new Exception("Error en Acceso a Datos: InsertarMonto.", e);
                return 0;
            }
            //throw new NotImplementedException();


        }

        public DataTable getAllTeacherGradeForIdUser(int iduser)
        {
            Dt = new DataTable();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_GET_TEACHER_GRADE_FOR_USER_ID";
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

        public List<ModeloNegocio.TeacherGrade> getAllTeacherGradeSeccionForIdUser(int iduser)
        {
            List<ModeloNegocio.TeacherGrade> lista = new List<ModeloNegocio.TeacherGrade>();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_GET_TEACHER_GRADE_FOR_USER_ID";
                Cmd.Parameters.Add("@iduser", SqlDbType.Int).Value = iduser;
                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {
                    ModeloNegocio.TeacherGrade users = new ModeloNegocio.TeacherGrade();
                    users.Id = Convert.ToInt32(Dtr["id"]);
                    users.Grade = Dtr["grade"].ToString();
                    users.Seccion = Dtr["seccion"].ToString();
                    //users.Type = Dtr["type"].ToString();
                    users.Num_alumnos = Convert.ToInt32(Dtr["num_alumnos"]);
                    lista.Add(users);
                }
                Conn.Close();
                

            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return lista;

        }

        public ModeloNegocio.TeacherGrade getTeacherGradeId(int TeacherGrade_id)
        {

            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            ModeloNegocio.TeacherGrade teacherGrade = new ModeloNegocio.TeacherGrade();
            try
            {

                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_GET_TEACHER_GRADE_ID";
                Cmd.Parameters.Add("@teacher_grade_id", SqlDbType.Int).Value = TeacherGrade_id;

                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {

                    teacherGrade.Id = Convert.ToInt32(Dtr["id"]);
                    if (DBNull.Value.Equals(Dtr["grade"]))
                        teacherGrade.Grade = "";
                    else
                        teacherGrade.Grade =  Dtr["grade"].ToString();

                    if (DBNull.Value.Equals(Dtr["num_alumnos"])) teacherGrade.Num_alumnos = 0 ; else teacherGrade.Num_alumnos = Convert.ToInt32(Dtr["num_alumnos"]);
                    if (DBNull.Value.Equals(Dtr["seccion"])) teacherGrade.Seccion = ""; 
                    else teacherGrade.Seccion = Dtr["seccion"].ToString(); 
                    teacherGrade.UserTeacheId =Convert.ToInt32(Dtr["user_teacher_id"].ToString());
                    if (DBNull.Value.Equals(Dtr["created_at"])) teacherGrade.Created_at = DateTime.Now; else teacherGrade.Created_at = DateTime.Parse(Dtr["created_at"].ToString());
                    if (DBNull.Value.Equals(Dtr["updated_at"])) teacherGrade.Updated_at = DateTime.Now; else teacherGrade.Updated_at = DateTime.Parse(Dtr["updated_at"].ToString());


                }
                Conn.Close();

                return teacherGrade;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return teacherGrade;
            }

        }

        public bool deleteTeacherGrade(int idTeacher)
        {
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_ELIMINA_TEACHER_GRADE";
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

        public DataTable getCountGradesForTeachers()
        {
            Dt = new DataTable();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_COUNT_GRADES_FOR_TEACHER";
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
    }
}
