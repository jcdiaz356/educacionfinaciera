using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AccesoDatos
{
    public class MicroredDocente
    {
         private SqlConnection Conn;
        private SqlCommand Cmd;
        private SqlDataReader Dtr;
        private DataTable Dt;

        public MicroredDocente()
        {
            AccesoDatos.Conexion objConexion = new AccesoDatos.Conexion();
            Conn = objConexion.abrirConexion();
        }

        public int insertMicroredDocente(ModeloNegocio.MicroredDocente ObjMicroredDocentel)
        {

            try
            {

                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_ING_MICRORED_DOCENTE";

                Cmd.Parameters.Add("@docente_id", SqlDbType.Int).Value = ObjMicroredDocentel.Docente_id;
                Cmd.Parameters.Add("@microred_id", SqlDbType.Int).Value = ObjMicroredDocentel.Microred_id;
               

                Cmd.Parameters.Add("@microred_docente_id", SqlDbType.Int).Direction = ParameterDirection.Output;

                Cmd.ExecuteNonQuery();

                ObjMicroredDocentel.Id = Convert.ToInt32(Cmd.Parameters["@microred_docente_id"].Value);

                Conn.Close();
                return ObjMicroredDocentel.Id;
            }
            catch (Exception e)
            {
                // Console.WriteLine("{0} Problem insert.", e);
                //throw new Exception("Error en Acceso a Datos: InsertarMonto.", e);
                return 0;
            }
            //throw new NotImplementedException();


        }

        public List<ModeloNegocio.MicroredDocente> getAllMicroredDocenteForIdMicrored(int idMicrored)
        {
            List<ModeloNegocio.MicroredDocente> lista = new List<ModeloNegocio.MicroredDocente>();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_GET_MICRORED_DOCENTE_FOR_MICRORED_ID";

 

                Cmd.Parameters.Add("@microred_id", SqlDbType.Int).Value = idMicrored;
                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {
                    ModeloNegocio.MicroredDocente microredDocente = new ModeloNegocio.MicroredDocente();
                    microredDocente.Id = Convert.ToInt32(Dtr["id"]);
                    microredDocente.Docente_id = Convert.ToInt32(Dtr["docente_id"]);
                    microredDocente.Microred_id = Convert.ToInt32(Dtr["microred_id"]);
                    if (DBNull.Value.Equals(Dtr["created_at"])) microredDocente.Created_at = DateTime.Now; else microredDocente.Created_at = DateTime.Parse(Dtr["created_at"].ToString());


                    if (DBNull.Value.Equals(Dtr["updated_at"])) microredDocente.Updated_at = DateTime.Now; else microredDocente.Updated_at = DateTime.Parse(Dtr["updated_at"].ToString());

                    lista.Add(microredDocente);
                }
                Conn.Close();


            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return lista;

        }
    }
}
