using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AccesoDatos
{
    public class TeacherTurn
    {
        private SqlConnection Conn;
        private SqlCommand Cmd;
        private SqlDataReader Dtr;
        private DataTable Dt;

        public TeacherTurn()
        {
            AccesoDatos.Conexion objConexion = new AccesoDatos.Conexion();
            Conn = objConexion.abrirConexion();
        }
        public int insertTeacherTurn(ModeloNegocio.TeacherTurn ObjTeacherTurn)
        {

            try
            {
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_ING_TEACHER_TURN";
                Cmd.Parameters.Add("@user_teacher_id", SqlDbType.Int).Value = ObjTeacherTurn.UserTeacheId;
                Cmd.Parameters.Add("@turn", SqlDbType.VarChar).Value = ObjTeacherTurn.Turn;


                Cmd.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;

                Cmd.ExecuteNonQuery();

                ObjTeacherTurn.Id = Convert.ToInt32(Cmd.Parameters["@id"].Value);

                Conn.Close();
                return ObjTeacherTurn.Id;
            }
            catch (Exception e)
            {
                // Console.WriteLine("{0} Problem insert.", e);
                //throw new Exception("Error en Acceso a Datos: InsertarMonto.", e);
                return 0;
            }
            //throw new NotImplementedException();


        }

        public DataTable getAllTeacherTurnForIdUser(int iduser)
        {
            Dt = new DataTable();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_GET_TEACHER_TURN_FOR_USER_ID";
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

        public bool deleteTeacherTurns(int idTeacher)
        {
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_ELIMINA_TEACHER_TURNS";
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
