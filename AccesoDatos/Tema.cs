using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModeloNegocio;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public class Tema
    {
        private SqlConnection Conn;
        private SqlCommand Cmd;
        private SqlDataReader Dtr;
        private DataTable Dt;

        public Tema()
        {
            AccesoDatos.Conexion objConexion = new AccesoDatos.Conexion();
            Conn = objConexion.abrirConexion();
        }

        public DataTable getAllTemsForGrade(string grade)
        {
            Dt = new DataTable();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_GET_TEMS_FOR_GRADE";
                Cmd.Parameters.Add("@grade", SqlDbType.VarChar).Value = grade;
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

        public ModeloNegocio.Tema getTemaId(int tema_id)
        {
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            ModeloNegocio.Tema tema = new ModeloNegocio.Tema();

            try
            {

                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_GET_TEMA_ID";
                Cmd.Parameters.Add("@tema_id", SqlDbType.Int).Value = tema_id;

                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {

                    tema.Id = Convert.ToInt32(Dtr["id"]);

                    tema.Name = Dtr["tema"].ToString();
                    tema.Grade = Dtr["grade"].ToString();

                    // if (DBNull.Value.Equals(Dtr["created_at"])) sesion.Created_at = DateTime.Now; else sesion.Created_at = DateTime.Parse(Dtr["created_at"].ToString());
                    // if (DBNull.Value.Equals(Dtr["updated_at"])) sesion.Updated_at = DateTime.Now; else sesion.Updated_at = DateTime.Parse(Dtr["updated_at"].ToString());
                }
                Conn.Close();

                return tema;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return tema;
            }

        }
    }
}
