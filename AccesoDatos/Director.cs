using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AccesoDatos
{
    public class Director
    {

        private SqlConnection Conn;
        private SqlCommand Cmd;
        private SqlDataReader Dtr;
        private DataTable Dt;

        public Director()
        {
            AccesoDatos.Conexion objConexion = new AccesoDatos.Conexion();
            Conn = objConexion.abrirConexion();
        }

        public List<ModeloNegocio.Director> getAllDirector(int registroAMostrar, int registroAEmpezar, int tipoUsuario)
        {
            List<ModeloNegocio.Director> lista = new List<ModeloNegocio.Director>();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_LISTA_USERS";
                Cmd.Parameters.Add("@RegistrosAMostrar", SqlDbType.Int).Value = registroAMostrar;
                Cmd.Parameters.Add("@RegistrosAEmpezar", SqlDbType.Int).Value = registroAEmpezar;
                Cmd.Parameters.Add("@tipoUser", SqlDbType.Int).Value = tipoUsuario;
                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {
                    ModeloNegocio.Director users = new ModeloNegocio.Director();
                    users.School_id = Convert.ToInt32(Dtr["id"]);
                    users.Codigo = Dtr["codigo"].ToString();
                    users.FullName = Dtr["name"].ToString();
                    //users.Type = Dtr["type"].ToString();
                    users.Email = Dtr["email"].ToString();

                    if (DBNull.Value.Equals(Dtr["created_at"]))
                    {
                        users.FechaCreado = DateTime.Now;
                    }
                    else
                    {
                        users.FechaCreado = DateTime.Parse(Dtr["created_at"].ToString());
                    }


                    ModeloNegocio.TypeUser typeUser = new ModeloNegocio.TypeUser();
                    typeUser.Id = Convert.ToInt16(Dtr["type_user_id"]);
                    typeUser.Name = Dtr["tipoUser"].ToString();

                    users.typeUser = typeUser;

                    lista.Add(users);
                }
                Conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return lista;

        }

        public List<ModeloNegocio.Director> getAllDirector(int tipoUsuario)
        {
            List<ModeloNegocio.Director> lista = new List<ModeloNegocio.Director>();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_LISTA_ALL_USER";

                Cmd.Parameters.Add("@tipoUser", SqlDbType.Int).Value = tipoUsuario;
                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {
                    ModeloNegocio.Director users = new ModeloNegocio.Director();
                    users.id = Convert.ToInt32(Dtr["id"]);
                    users.FullName = Dtr["name"].ToString();
                    //users.Type = Dtr["type"].ToString();
                    users.Email = Dtr["email"].ToString();

                    if (DBNull.Value.Equals(Dtr["created_at"]))
                    {
                        users.FechaCreado = DateTime.Now;
                    }
                    else
                    {
                        users.FechaCreado = DateTime.Parse(Dtr["created_at"].ToString());
                    }


                    ModeloNegocio.TypeUser typeUser = new ModeloNegocio.TypeUser();
                    typeUser.Id = Convert.ToInt16(Dtr["type_user_id"]);
                    typeUser.Name = Dtr["tipoUser"].ToString();

                    users.typeUser = typeUser;

                    lista.Add(users);
                }
                Conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return lista;

        }
        public ModeloNegocio.Director getDirectorId(int director_id)
        {

            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            ModeloNegocio.Director director = new ModeloNegocio.Director();
            try
            {

                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_LISTA_USER_ID";
                Cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = director_id;

                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {

                    director.id = Convert.ToInt32(Dtr["id"]);
                    director.FullName = Dtr["name"].ToString();
                    director.Codigo = Dtr["codigo"].ToString();
                    director.Email = Dtr["email"].ToString();
                    director.Telefono = Dtr["telefono"].ToString();
                   
                    director.Password = Dtr["password"].ToString();
                   

                    //users.Type = Dtr["type"].ToString();


                    if (DBNull.Value.Equals(Dtr["created_at"]))
                    {
                        director.FechaCreado = DateTime.Now;
                    }
                    else
                    {
                        director.FechaCreado = DateTime.Parse(Dtr["created_at"].ToString());
                    }

                    if (DBNull.Value.Equals(Dtr["updated_at"]))
                    {
                        director.FechaActualizado = DateTime.Now;
                    }
                    else
                    {
                        director.FechaActualizado = DateTime.Parse(Dtr["updated_at"].ToString());
                    }


                    ModeloNegocio.TypeUser typeUser = new ModeloNegocio.TypeUser();
                    typeUser.Id = Convert.ToInt16(Dtr["id_type"]);
                    typeUser.Name = Dtr["name_type_user"].ToString();

                    director.typeUser = typeUser;

                    //lista.Add(users);
                }
                Conn.Close();

                return director;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return director;
            }

        }
        public int insertDirector(ModeloNegocio.Director ObjDirector)
        {

            try
            {
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_ING_DOCENTE";
                Cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = ObjDirector.Codigo;
                Cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = ObjDirector.FullName;
                Cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = ObjDirector.Telefono;
                Cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = ObjDirector.Email;
                Cmd.Parameters.Add("@id_type", SqlDbType.Int).Value = ObjDirector.Type;
                Cmd.Parameters.Add("@type_contract", SqlDbType.VarChar).Value = "";

                Cmd.Parameters.Add("@user_docente_id", SqlDbType.Int).Direction = ParameterDirection.Output;

                Cmd.ExecuteNonQuery();

                ObjDirector.School_id = Convert.ToInt32(Cmd.Parameters["@user_docente_id"].Value);

                Conn.Close();
                return ObjDirector.School_id;
            }
            catch (Exception e)
            {
                // Console.WriteLine("{0} Problem insert.", e);
                //throw new Exception("Error en Acceso a Datos: InsertarMonto.", e);
                return 0;
            }
            //throw new NotImplementedException();


        }

        public bool updateDirector(ModeloNegocio.Director ObjDirector)
        {

            try
            {
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_UPDATE_DOCENTE";
                Cmd.Parameters.Add("@idTeacher", SqlDbType.Int).Value = ObjDirector.id;
                Cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = ObjDirector.Codigo;
                Cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = ObjDirector.FullName;
                Cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = ObjDirector.Telefono;
                Cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = ObjDirector.Email;
                Cmd.Parameters.Add("@id_type", SqlDbType.Int).Value = ObjDirector.Type;
                Cmd.Parameters.Add("@type_contract", SqlDbType.VarChar).Value = ObjDirector.TypeContract;

                Cmd.ExecuteNonQuery();



                Conn.Close();
                return true;
            }
            catch (Exception e)
            {
                // Console.WriteLine("{0} Problem insert.", e);
                //throw new Exception("Error en Acceso a Datos: InsertarMonto.", e);
                return false;
            }
            //throw new NotImplementedException();


        }

        public bool deleteTeacher(int iduser)
        {
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_OBT_ELIMINA_USER";
                Cmd.Parameters.Add("@iduser", SqlDbType.Int).Value = iduser;
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


        public int countRows(int tipoUsuario)
        {
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            int total_rows = 0;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_COUNT_ROWS_TYPE_USER";
                Cmd.Parameters.Add("@IdType", SqlDbType.Int).Value = tipoUsuario;
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
