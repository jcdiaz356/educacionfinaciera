using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AccesoDatos
{
    public class MicroredSchool
    {
        private SqlConnection Conn;
        private SqlCommand Cmd;
        private SqlDataReader Dtr;
        private DataTable Dt;

        public MicroredSchool()
        {
            AccesoDatos.Conexion objConexion = new AccesoDatos.Conexion();
            Conn = objConexion.abrirConexion();
        }

        public List<ModeloNegocio.MicroredSchool> getAllMicroredSchoolForIdMicrored(int idMicrored)
        {
            List<ModeloNegocio.MicroredSchool> lista = new List<ModeloNegocio.MicroredSchool>();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_GET_MICRORED_SCHOOL_FOR_MICRORED_ID";



                Cmd.Parameters.Add("@microred_id", SqlDbType.Int).Value = idMicrored;
                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {
                    ModeloNegocio.MicroredSchool microredSchool = new ModeloNegocio.MicroredSchool();
                    microredSchool.Id = Convert.ToInt32(Dtr["id"]);
                    microredSchool.School_id = Convert.ToInt32(Dtr["school_id"]);
                    microredSchool.Microred_id = Convert.ToInt32(Dtr["microred_id"]);

                    if (DBNull.Value.Equals(Dtr["created_at"])) microredSchool.Created_at = DateTime.Now ; else microredSchool.Created_at = DateTime.Parse(Dtr["created_at"].ToString());


                    if (DBNull.Value.Equals(Dtr["updated_at"])) microredSchool.Updated_at = DateTime.Now ; else microredSchool.Updated_at = DateTime.Parse(Dtr["updated_at"].ToString());


                   

                    lista.Add(microredSchool);
                }
                Conn.Close();


            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return lista;

        }

        public int insertMicroredSchool(ModeloNegocio.MicroredSchool ObjMicroredSchool)
        {

            try
            {

                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_ING_MICRORED_SCHOOL";

                Cmd.Parameters.Add("@school_id", SqlDbType.Int).Value = ObjMicroredSchool.School_id;
                Cmd.Parameters.Add("@microred_id", SqlDbType.Int).Value = ObjMicroredSchool.Microred_id;
               

                Cmd.Parameters.Add("@microred_school_id", SqlDbType.Int).Direction = ParameterDirection.Output;

                Cmd.ExecuteNonQuery();

                ObjMicroredSchool.Id = Convert.ToInt32(Cmd.Parameters["@microred_school_id"].Value);

                Conn.Close();
                return ObjMicroredSchool.Id;
            }
            catch (Exception e)
            {
                // Console.WriteLine("{0} Problem insert.", e);
                //throw new Exception("Error en Acceso a Datos: InsertarMonto.", e);
                return 0;
            }
            //throw new NotImplementedException();


        }
    }
}
