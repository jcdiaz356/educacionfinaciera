using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AccesoDatos
{
    public class Content
    {
        private SqlConnection Conn;
        private SqlCommand Cmd;
        private SqlDataReader Dtr;

        public Content()
        {
            AccesoDatos.Conexion objConexion = new AccesoDatos.Conexion();
            Conn = objConexion.abrirConexion();
        }

        /// <summary>
        /// getContentId Metodo obtiene un Contenido según su ID
        /// </summary>
        /// <param name="id">Id del Contenido </param>
        /// <returns>Retorna un List ModeloNegocio.Content</returns>
        public ModeloNegocio.Content getContentId(int id)
        {
            try
            {
                ModeloNegocio.Content content = new ModeloNegocio.Content();
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.CommandText = "PA_GET_CONTENT_ID";

                Cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

  
                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {
                    //Lista.Add(new EntidadNegocio.UsuarioEN(Convert.ToInt32(Dtr["idusuario"]), Dtr["nombre"].ToString(), Dtr["usuario"].ToString(), Dtr["password"].ToString(), Convert.ToInt32(Dtr["permiso"])));
                    content.Id = Convert.ToInt32(Dtr["id"]);
                    content.Title = Convert.ToString(Dtr["title"]);
                    content.ContentNote = Convert.ToString(Dtr["content"]);

                    if (DBNull.Value.Equals(Dtr["image"]))
                    {
                        content.Image = null;
                    } else
                    {
                        content.Image = Dtr["image"].ToString() ;
                    }


                    if (DBNull.Value.Equals(Dtr["created_at"]))
                    {
                        content.Created_at = DateTime.Now;
                    }
                    else
                    {
                        content.Created_at = Convert.ToDateTime(Dtr["created_at"]);
                    }

                    if (DBNull.Value.Equals(Dtr["updated_at"]))
                    {
                        content.Updated_at = DateTime.Now;
                    }
                    else
                    {
                        content.Updated_at = Convert.ToDateTime(Dtr["updated_at"]);
                    }


                    ModeloNegocio.User user = new ModeloNegocio.User();
                    user.id = Convert.ToInt32(Dtr["iduser"]);
                    user.FullName = Convert.ToString(Dtr["user_name"]);
                    content.User=user;

                    ModeloNegocio.TypeContent typeContent = new ModeloNegocio.TypeContent();
                    typeContent.Id = Convert.ToInt32(Dtr["idtype"]);
                    typeContent.Name = Convert.ToString(Dtr["type_content_name"]);
                    content.typeContent=typeContent;
                    

                    AccesoDatos.Comment comment = new AccesoDatos.Comment();
                    List<ModeloNegocio.Comment> lista = new  List<ModeloNegocio.Comment>();
                    lista=comment.getAllCommentContentId(Convert.ToInt32(Dtr["id"]));
                    content.Comment = lista;


                    ModeloNegocio.TypeUser typeUser = new ModeloNegocio.TypeUser();
                    typeUser.Id = Convert.ToInt32(Dtr["idtype"]);
                    typeUser.Name = Convert.ToString(Dtr["type_content_name"]);

                }

                    


                Cmd.Parameters.Clear();
                Dtr.Close();
                Conn.Close();
                return content;

            }
            catch (Exception ex)
            {
                throw new Exception("Error en Acceso a Datos: LoginUsuario.", ex);
            }
        }

        public void getContentId()
        {

            throw new NotImplementedException();
        }

        public List<ModeloNegocio.Content> getAllContent(int registroAMostrar, int registroAEmpezar, int idType)
        {
            List<ModeloNegocio.Content> lista = new List<ModeloNegocio.Content>();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;

            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_LISTA_CONTENT";
                Cmd.Parameters.Add("@RegistrosAMostrar", SqlDbType.Int).Value = registroAMostrar;
                Cmd.Parameters.Add("@RegistrosAEmpezar", SqlDbType.Int).Value = registroAEmpezar;
                Cmd.Parameters.Add("@idType", SqlDbType.Int).Value = idType;
                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {
                    ModeloNegocio.Content content = new ModeloNegocio.Content();
                    content.Id = Convert.ToInt32(Dtr["id"]);
                    content.Title = Dtr["title"].ToString();
                    content.ContentNote = Dtr["content"].ToString();
                    //users.Type = Dtr["type"].ToString();
                    content.IdUser = Convert.ToInt32(Dtr["iduser"].ToString());
                    content.IdType = Convert.ToInt32(Dtr["idtype"].ToString());
                    content.Image = Dtr["image"].ToString();
                   


                    if (DBNull.Value.Equals(Dtr["created_at"]))
                    {
                        content.Created_at = DateTime.Now;
                    }
                    else
                    {
                        content.Created_at = Convert.ToDateTime(Dtr["created_at"]);
                    }

                    if (DBNull.Value.Equals(Dtr["updated_at"]))
                    {
                        content.Updated_at = DateTime.Now;
                    }
                    else
                    {
                        content.Updated_at = Convert.ToDateTime(Dtr["updated_at"]);
                    }


                    //ModeloNegocio.TypeUser typeUser = new ModeloNegocio.TypeUser();
                    //typeUser.Id = Convert.ToInt16(Dtr["type_user_id"]);
                    //typeUser.Name = Dtr["tipoUser"].ToString();
                    //content.typeUser = typeUser;

                    lista.Add(content);
                }
                Conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return lista;

        }




        public int countRowsContent(int idType)
        {
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            int total_rows = 0;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_COUNT_ROWS_CONTENT";
                Cmd.Parameters.Add("@idType", SqlDbType.Int).Value = idType;
                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {

                    total_rows = Convert.ToInt32(Dtr["total_rows"]);

                }
                Conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return total_rows;
        }

    }
}
