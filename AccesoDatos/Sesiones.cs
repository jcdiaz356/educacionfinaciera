using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModeloNegocio;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public class Sesiones
    {
        private SqlConnection Conn;
        private SqlCommand Cmd;
        private SqlDataReader Dtr;
        private DataTable Dt;

        public Sesiones()
        {
            AccesoDatos.Conexion objConexion = new AccesoDatos.Conexion();
            Conn = objConexion.abrirConexion();
        }

        public DataTable getAllSesionsForTem(int tema_id)
        {
            Dt = new DataTable();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_GET_SESIONS_FOR_TEM";
                Cmd.Parameters.Add("@tema_id", SqlDbType.Int).Value = tema_id;
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



        public ModeloNegocio.Sesion getSesionId(int sesion_id)
        {
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            ModeloNegocio.Sesion sesion = new ModeloNegocio.Sesion();

            try
            {

                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_GET_SESIONES_ID";
                Cmd.Parameters.Add("@sesion_id", SqlDbType.Int).Value = sesion_id;

                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {

                    sesion.Id = Convert.ToInt32(Dtr["id"]);

                    sesion.NumSesion = Dtr["nrosesion"].ToString();
                    sesion.Tema_id = Convert.ToInt32(Dtr["tema_id"]);

                   // if (DBNull.Value.Equals(Dtr["created_at"])) sesion.Created_at = DateTime.Now; else sesion.Created_at = DateTime.Parse(Dtr["created_at"].ToString());


                   // if (DBNull.Value.Equals(Dtr["updated_at"])) sesion.Updated_at = DateTime.Now; else sesion.Updated_at = DateTime.Parse(Dtr["updated_at"].ToString());


                }
                Conn.Close();

                return sesion;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return sesion;
            }

        }
    }
}
