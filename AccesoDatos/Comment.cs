using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AccesoDatos
{
    public class Comment
    {
        private SqlConnection Conn;
        private SqlCommand Cmd;
        private SqlDataReader Dtr;

        public Comment()
        {
            AccesoDatos.Conexion objConexion = new AccesoDatos.Conexion();
            Conn = objConexion.abrirConexion();
        }

        /// <summary>
        /// getCommentId Metodo obtiene un Comentarios según su ID
        /// </summary>
        /// <param name="id">Id del Comentarios </param>
        /// <returns>Retorna un List ModeloNegocio.Comment</returns>
        public ModeloNegocio.Comment getCommentId(int id)
        {
            try
            {
                ModeloNegocio.Comment comment = new ModeloNegocio.Comment();
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandText = "SELECT  otaku_bcp.comment.comment, otaku_bcp.comment.id, otaku_bcp.comment.email_author, otaku_bcp.comment.created_at,  otaku_bcp.comment.updated_at , otaku_bcp.comment.id_content, otaku_bcp.comment.ip_author FROM otaku_bcp.comment WHERE otaku_bcp.comment.id = @id";

                Cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                Cmd.Parameters["@id"].Value = id;
                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {
                    //Lista.Add(new EntidadNegocio.UsuarioEN(Convert.ToInt32(Dtr["idusuario"]), Dtr["nombre"].ToString(), Dtr["usuario"].ToString(), Dtr["password"].ToString(), Convert.ToInt32(Dtr["permiso"])));
                    comment.Id = Convert.ToInt32(Dtr["id"]);
                    comment.CommentContent = Convert.ToString(Dtr["comment"]);
                    comment.EmailAuthor = Convert.ToString(Dtr["email_author"]);

                    

                    if (DBNull.Value.Equals(Dtr["created_at"]))
                    {
                        comment.Created_at = DateTime.Now;
                    }
                    else
                    {
                        comment.Created_at = Convert.ToDateTime(Dtr["created_at"]);
                    }


                    if (DBNull.Value.Equals(Dtr["created_at"]))
                    {
                        comment.Updated_at = DateTime.Now;
                    }
                    else
                    {
                        comment.Updated_at = Convert.ToDateTime(Dtr["updated_at"]);
                    }

                    

                    comment.IdCotent = Convert.ToInt16(Dtr["id_content"]);
                    comment.IpAuthor = Convert.ToString(Dtr["ip_author"]);

                }
                Cmd.Parameters.Clear();
                Dtr.Close();
                Conn.Close();
                return comment;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Acceso a Datos: LoginUsuario.", ex);
            }
        }



        /// <summary>
        /// getAllCommentContent Metodo obtiene todos los Comentarios de un contenido
        /// </summary>
        /// <param name="idContent">Id del contenido el cual se mostrará todos sus commentarios</param>
        /// <returns>Retorna un List ModeloNegocio.Comment</returns>
        public List<ModeloNegocio.Comment> getAllCommentContentId(int idContent)
        {
                List<ModeloNegocio.Comment> lista = new List<ModeloNegocio.Comment>();
                

            try
            {
                
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_GET_COMENT_CONTENT";
                Cmd.Parameters.Add("@idContent", SqlDbType.Int).Value = idContent;    

                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {
                    ModeloNegocio.Comment comment = new ModeloNegocio.Comment();
                    comment.Id = Convert.ToInt32(Dtr["id"]);
                    comment.CommentContent = Convert.ToString(Dtr["comment"]);
                    comment.EmailAuthor = Convert.ToString(Dtr["email_author"]);
                    comment.Created_at = Convert.ToDateTime(Dtr["created_at"]);
                    comment.Updated_at = Convert.ToDateTime(Dtr["updated_at"]);
                    comment.IdCotent = Convert.ToInt16(Dtr["id_content"]);
                    comment.IpAuthor = Convert.ToString(Dtr["ip_author"]);
                    lista.Add(comment);
                }

                //Cmd.Parameters.Clear();
                //Dtr.Close();
                Conn.Close();
                return lista;


            }
            catch (Exception ex)
            {
                throw new Exception("Error en Acceso a Datos: LoginUsuario.", ex);
            }
        }



        public int insertComment(ModeloNegocio.Comment ObjComment)
        {

            try
            {
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_ING_COMMENT";

                Cmd.Parameters.Add("@email_author", SqlDbType.VarChar).Value = ObjComment.EmailAuthor;
                Cmd.Parameters.Add("@comment", SqlDbType.Text).Value = ObjComment.CommentContent;
                Cmd.Parameters.Add("@id_content", SqlDbType.VarChar).Value = ObjComment.IdCotent;
                Cmd.Parameters.Add("@ip_author", SqlDbType.VarChar).Value = ObjComment.IpAuthor;

                Cmd.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;

                Cmd.ExecuteNonQuery();

                ObjComment.Id = Convert.ToInt32(Cmd.Parameters["@id"].Value);

                Conn.Close();
                return ObjComment.Id;
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
