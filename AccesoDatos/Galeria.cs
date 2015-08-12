using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AccesoDatos
{
    public class Galeria
    {
        private SqlConnection Conn;
        private SqlCommand Cmd;
        private SqlDataReader Dtr;
        private DataTable Dt;

        public Galeria()
        {
            AccesoDatos.Conexion objConexion = new AccesoDatos.Conexion();
            Conn = objConexion.abrirConexion();
        }

        public List<ModeloNegocio.Galeria> getAllGaleria(int registroAMostrar, int registroAEmpezar, int Type_id)
        {
            List<ModeloNegocio.Galeria> lista = new List<ModeloNegocio.Galeria>();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_LISTA_GALERIA";
                Cmd.Parameters.Add("@RegistrosAMostrar", SqlDbType.Int).Value = registroAMostrar;
                Cmd.Parameters.Add("@RegistrosAEmpezar", SqlDbType.Int).Value = registroAEmpezar;
                Cmd.Parameters.Add("@type_id", SqlDbType.Int).Value = Type_id;
                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {
                    ModeloNegocio.Galeria galeria = new ModeloNegocio.Galeria();
                    galeria.Id = Convert.ToInt32(Dtr["id"]);
                    galeria.Type_id = Convert.ToInt32(Dtr["type_id"]);
                    galeria.Name = Dtr["name"].ToString();
                    galeria.Description = Dtr["description"].ToString();
                    //users.Type = Dtr["type"].ToString();
                    //galeria.Image = Dtr["email"].ToString();

                    if (DBNull.Value.Equals(Dtr["image"]))
                    {
                        galeria.Image = Dtr["image"].ToString();
                    }
                    else
                    {
                        galeria.Image = Dtr["image"].ToString();
                    }
                    
                    if (DBNull.Value.Equals(Dtr["created_at"]))
                    {
                        galeria.Created_at = DateTime.Now;
                    }
                    else
                    {
                        galeria.Created_at = DateTime.Parse(Dtr["updated_at"].ToString());
                    }

                    if (DBNull.Value.Equals(Dtr["updated_at"]))
                    {
                        galeria.Updated_at = DateTime.Now;
                    }
                    else
                    {
                        galeria.Updated_at = DateTime.Parse(Dtr["updated_at"].ToString());
                    }


                     // galeria.GaleriaContenido

                    AccesoDatos.GaleriaContenido galeriaContenido = new AccesoDatos.GaleriaContenido();
                    List<ModeloNegocio.GaleriaContenido> listaGaleriaContenido = new List<ModeloNegocio.GaleriaContenido>();
                    listaGaleriaContenido = galeriaContenido.getAllGaleriaContenidoId(Convert.ToInt32(Dtr["id"]));
                    galeria.GaleriaContenido = listaGaleriaContenido;



                    lista.Add(galeria);
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
