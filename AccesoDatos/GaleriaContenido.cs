using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AccesoDatos
{
    public class GaleriaContenido
    {

        private SqlConnection Conn;
        private SqlCommand Cmd;
        private SqlDataReader Dtr;
        private DataTable Dt;

        public GaleriaContenido()
        {
            AccesoDatos.Conexion objConexion = new AccesoDatos.Conexion();
            Conn = objConexion.abrirConexion();
        }

        public List<ModeloNegocio.GaleriaContenido> getAllGaleriaContenidoId(int idGaleria)
        {
            List<ModeloNegocio.GaleriaContenido> lista = new List<ModeloNegocio.GaleriaContenido>();


            try
            {

                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_GET_GALERIA_CONTENIDO";
                Cmd.Parameters.Add("@galeria_id", SqlDbType.Int).Value = idGaleria;

                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {
                    ModeloNegocio.GaleriaContenido galeriaContenido = new ModeloNegocio.GaleriaContenido();
                    galeriaContenido.Id = Convert.ToInt32(Dtr["id"]);
                    galeriaContenido.Description = Convert.ToString(Dtr["description"]);
                    galeriaContenido.Galeria_id = Convert.ToInt32(Dtr["galeria_id"]);
                    galeriaContenido.Name_galeria = Dtr["name_galeria"].ToString();

                    galeriaContenido.Created_at = Convert.ToDateTime(Dtr["created_at"]);
                    galeriaContenido.Updated_at = Convert.ToDateTime(Dtr["updated_at"]);
                    galeriaContenido.Source = Dtr["Source"].ToString();
                    lista.Add(galeriaContenido);
                }



                Conn.Close();
                return lista;


            }
            catch (Exception ex)
            {
                throw new Exception("Error en Acceso a Datos: LoginUsuario.", ex);
            }
        }



    }
}
