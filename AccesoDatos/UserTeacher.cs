using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AccesoDatos
{
    public class UserTeacher
    {

         private SqlConnection Conn;
        private SqlCommand Cmd;
        private SqlDataReader Dtr;
        private DataTable Dt;

        public UserTeacher()
        {
            AccesoDatos.Conexion objConexion = new AccesoDatos.Conexion();
            Conn = objConexion.abrirConexion();
        }


        public int insertUserTeacher( ModeloNegocio.UserTeacher ObjUserTeacher)
        {

            try
            {
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_ING_ASESOR_TEACHER";
                Cmd.Parameters.Add("@user_teacher_id", SqlDbType.Int).Value = ObjUserTeacher.UserTeacheId;
                Cmd.Parameters.Add("@user_asesor_id", SqlDbType.Int).Value = ObjUserTeacher.UserAsesorId;


                Cmd.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;

                Cmd.ExecuteNonQuery();

                ObjUserTeacher.Id = Convert.ToInt32(Cmd.Parameters["@id"].Value);

                Conn.Close();
                return ObjUserTeacher.Id;
            }
            catch (Exception e)
            {
                // Console.WriteLine("{0} Problem insert.", e);
                //throw new Exception("Error en Acceso a Datos: InsertarMonto.", e);
                return 0;
            }
            //throw new NotImplementedException();


        }

        public DataTable getAllTeacherForIdUser(int iduser)
        {
            Dt = new DataTable();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_GET_TEACHER_FOR_USER_ID";
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

        public bool updateSelectTeacherForIduser(int iduser, int valUpdate)
        {
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_OBT_UPDATE_SELECT_USER";
                Cmd.Parameters.Add("@iduser", SqlDbType.Int).Value = iduser;
                Cmd.Parameters.Add("@update", SqlDbType.Int).Value = valUpdate;

                Cmd.ExecuteNonQuery();
                Conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return true;
        }

        public bool deleteTeachersForUserId(int iduser)
        {
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_OBT_ELIMINA_TEACHERS_USER_ID";
                Cmd.Parameters.Add("@userid", SqlDbType.Int).Value = iduser;
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
