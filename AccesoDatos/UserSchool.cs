using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace AccesoDatos
{
        
    public class UserSchool
    {
        private SqlConnection Conn;
        private SqlCommand Cmd;
        private SqlDataReader Dtr;
        private DataTable Dt;

        public UserSchool()
        {
            AccesoDatos.Conexion objConexion = new AccesoDatos.Conexion();
            Conn = objConexion.abrirConexion();
        }

        public int insertUserSchool( ModeloNegocio.UserSchool ObjUserSchool)
        {

            try
            {
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_ING_ASESOR_SCHOOL";
                Cmd.Parameters.Add("@school_id", SqlDbType.Int).Value = ObjUserSchool.UserSchoolId;
                Cmd.Parameters.Add("@user_asesor_id", SqlDbType.Int).Value = ObjUserSchool.UserAsesorId;


                Cmd.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;

                Cmd.ExecuteNonQuery();

                ObjUserSchool.Id = Convert.ToInt32(Cmd.Parameters["@id"].Value);

                Conn.Close();
                return ObjUserSchool.Id;
            }
            catch (Exception e)
            {
                // Console.WriteLine("{0} Problem insert.", e);
                //throw new Exception("Error en Acceso a Datos: InsertarMonto.", e);
                return 0;
            }
            //throw new NotImplementedException();


        }


        public DataTable getAllSchoolForIdUser(int iduser)
        {
            Dt = new DataTable();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_GET_SCHOOL_FOR_USER_ID";
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

        public bool deleteUserSchool(int idUser)
        {
            return true;
        }

        public bool updateSelectSchoolForIduser(int iduser, int valUpdate)
        {
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_OBT_UPDATE_SELECT_SCHOOL";
                Cmd.Parameters.Add("@idschool", SqlDbType.Int).Value = iduser;
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

        public bool deleteSchoolsForUserId(int iduser)
        {
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_OBT_ELIMINA_SCHOOL_USER_ID";
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

        public DataTable getCountTeacherForSchool()
        {
            Dt = new DataTable();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_COUNT_TEACHER_FOR_SCHOOL";
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
