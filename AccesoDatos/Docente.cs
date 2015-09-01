using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AccesoDatos
{
    public class Docente
    {
        private SqlConnection Conn;
        private SqlCommand Cmd;
        private SqlDataReader Dtr;
        private DataTable Dt;

        public Docente()
        {
            AccesoDatos.Conexion objConexion = new AccesoDatos.Conexion();
            Conn = objConexion.abrirConexion();
        }

        public List<ModeloNegocio.Docente> getAllDocente(int registroAMostrar, int registroAEmpezar)
        {
            List<ModeloNegocio.Docente> lista = new List<ModeloNegocio.Docente>();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_LISTA_USERS";
                Cmd.Parameters.Add("@RegistrosAMostrar", SqlDbType.Int).Value = registroAMostrar;
                Cmd.Parameters.Add("@RegistrosAEmpezar", SqlDbType.Int).Value = registroAEmpezar;
                Cmd.Parameters.Add("@tipoUser", SqlDbType.Int).Value = 4;
                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {
                    ModeloNegocio.Docente users = new ModeloNegocio.Docente();
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

        public List<ModeloNegocio.Docente> getAllDocente()
        {
            List<ModeloNegocio.Docente> lista = new List<ModeloNegocio.Docente>();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_LISTA_ALL_USER";
               
                Cmd.Parameters.Add("@tipoUser", SqlDbType.Int).Value = 4;
                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {
                    ModeloNegocio.Docente users = new ModeloNegocio.Docente();
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
        public ModeloNegocio.Docente getDocenteId(int docente_id)
        {

            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            ModeloNegocio.Docente docente = new ModeloNegocio.Docente();
            try
            {

                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_LISTA_USER_ID";
                Cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = docente_id;

                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {

                    docente.id = Convert.ToInt32(Dtr["id"]);
                    docente.FullName = Dtr["name"].ToString();
                    docente.Codigo = Dtr["codigo"].ToString();
                    docente.Email = Dtr["email"].ToString();
                    docente.Telefono = Dtr["telefono"].ToString();

                    docente.Password = Dtr["password"].ToString();


                    //users.Type = Dtr["type"].ToString();


                    if (DBNull.Value.Equals(Dtr["created_at"]))
                    {
                        docente.FechaCreado = DateTime.Now;
                    }
                    else
                    {
                        docente.FechaCreado = DateTime.Parse(Dtr["created_at"].ToString());
                    }

                    if (DBNull.Value.Equals(Dtr["updated_at"]))
                    {
                        docente.FechaActualizado = DateTime.Now;
                    }
                    else
                    {
                        docente.FechaActualizado = DateTime.Parse(Dtr["updated_at"].ToString());
                    }


                    ModeloNegocio.TypeUser typeUser = new ModeloNegocio.TypeUser();
                    typeUser.Id = Convert.ToInt16(Dtr["id_type"]);
                    typeUser.Name = Dtr["name_type_user"].ToString();

                    docente.typeUser = typeUser;

                    //lista.Add(users);
                }
                Conn.Close();

                return docente;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return docente;
            }

        }
        public int insertDocente(ModeloNegocio.Docente ObjDocente)
        {

            try
            {
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_ING_DOCENTE";
                Cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = ObjDocente.Codigo;
                Cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = ObjDocente.FullName;
                Cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = ObjDocente.Telefono;
                Cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = ObjDocente.Email;
                Cmd.Parameters.Add("@id_type", SqlDbType.Int).Value = ObjDocente.Type;
                Cmd.Parameters.Add("@type_contract", SqlDbType.VarChar).Value = ObjDocente.TypeContract;

                Cmd.Parameters.Add("@user_docente_id", SqlDbType.Int).Direction = ParameterDirection.Output;

                Cmd.ExecuteNonQuery();

                ObjDocente.School_id = Convert.ToInt32(Cmd.Parameters["@user_docente_id"].Value);

                Conn.Close();
                return ObjDocente.School_id;
            }
            catch (Exception e)
            {
                // Console.WriteLine("{0} Problem insert.", e);
                //throw new Exception("Error en Acceso a Datos: InsertarMonto.", e);
                return 0;
            }
            //throw new NotImplementedException();


        }

        public bool updateDocente(ModeloNegocio.Docente ObjDocente)
        {

            try
            {
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_UPDATE_DOCENTE";
                Cmd.Parameters.Add("@idTeacher", SqlDbType.Int).Value = ObjDocente.id;
                Cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = ObjDocente.Codigo;
                Cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = ObjDocente.FullName;
                Cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = ObjDocente.Telefono;
                Cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = ObjDocente.Email;
                Cmd.Parameters.Add("@id_type", SqlDbType.Int).Value = ObjDocente.Type;
                Cmd.Parameters.Add("@type_contract", SqlDbType.VarChar).Value = ObjDocente.TypeContract;

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
        

       public int countRowsStudents()
        {
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            int total_rows = 0;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_COUNT_ROWS_STUDENTS";

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

        public int countRowsDocentes()
        {
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            int total_rows = 0;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_COUNT_ROWS_DOCENTE";

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
