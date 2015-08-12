using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModeloNegocio;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public class Distrito
    {
        private SqlConnection Conn;
        private SqlCommand Cmd;
        private SqlDataReader Dtr;
        private DataTable Dt;

        public Distrito()
        {
            AccesoDatos.Conexion objConexion = new AccesoDatos.Conexion();
            Conn = objConexion.abrirConexion();
        }

        public DataTable getAllDistritos(int idProvincia)
        {
            Dt = new DataTable();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_GET_DISTRITOS";
                Cmd.Parameters.Add("@idprovincia", SqlDbType.Int).Value = idProvincia;
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
