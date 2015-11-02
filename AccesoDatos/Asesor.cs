using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModeloNegocio;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public class Asesor
    {
        private SqlConnection Conn;
        private SqlCommand Cmd;
        private SqlDataReader Dtr;
        private DataTable Dt;

        public Asesor()
        {
            AccesoDatos.Conexion objConexion = new AccesoDatos.Conexion();
            Conn = objConexion.abrirConexion();
        }

        public List<ModeloNegocio.Asesor> getAllAsesors(int registroAMostrar, int registroAEmpezar)
        {
            List<ModeloNegocio.Asesor> lista = new List<ModeloNegocio.Asesor>();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[otaku_bcp].PA_LISTA_USERS";
                Cmd.Parameters.Add("@RegistrosAMostrar", SqlDbType.Int).Value = registroAMostrar;
                Cmd.Parameters.Add("@RegistrosAEmpezar", SqlDbType.Int).Value = registroAEmpezar;
                Cmd.Parameters.Add("@tipoUser", SqlDbType.Int).Value = 7;
                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {
                    ModeloNegocio.Asesor users = new ModeloNegocio.Asesor();
                    users.id = Convert.ToInt32(Dtr["id"]);
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

        public List<ModeloNegocio.Asesor> getAllAsesors()
        {
            List<ModeloNegocio.Asesor> lista = new List<ModeloNegocio.Asesor>();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[otaku_bcp].PA_LISTA_ALL_USERS";
               
                Cmd.Parameters.Add("@tipoUser", SqlDbType.Int).Value = 7;
                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {
                    ModeloNegocio.Asesor users = new ModeloNegocio.Asesor();
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

        public ModeloNegocio.Asesor getAsesorId(int assesor_id)
        {
           
            Cmd = new SqlCommand();
            Cmd.Connection = Conn; 
            ModeloNegocio.Asesor asesor = new ModeloNegocio.Asesor();
            try
            {
               
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[otaku_bcp].PA_LISTA_USER_ID";
                Cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = assesor_id;
                
                Dtr = Cmd.ExecuteReader();
                
                while (Dtr.Read())
                {
                    
                    asesor.id = Convert.ToInt32(Dtr["id"]);
                    asesor.FullName = Dtr["name"].ToString();
                    asesor.Codigo = Dtr["codigo"].ToString();
                    asesor.Email = Dtr["email"].ToString();
                    asesor.Telefono = Dtr["telefono"].ToString();
                    asesor.Grupo = Dtr["grupo"].ToString();
                    asesor.Password = Dtr["password"].ToString();
                    asesor.Selection = Convert.ToByte(Dtr["selection"]);

                    //users.Type = Dtr["type"].ToString();
                    

                    if (DBNull.Value.Equals(Dtr["created_at"]))
                    {
                        asesor.FechaCreado = DateTime.Now;
                    }
                    else
                    {
                        asesor.FechaCreado = DateTime.Parse(Dtr["created_at"].ToString());
                    }

                    if (DBNull.Value.Equals(Dtr["updated_at"]))
                    {
                        asesor.FechaActualizado = DateTime.Now;
                    }
                    else
                    {
                        asesor.FechaActualizado = DateTime.Parse(Dtr["updated_at"].ToString());
                    }


                    ModeloNegocio.TypeUser typeUser = new ModeloNegocio.TypeUser();
                    typeUser.Id = Convert.ToInt16(Dtr["id_type"]);
                    typeUser.Name = Dtr["name_type_user"].ToString();

                    asesor.typeUser = typeUser;
                   
                    //lista.Add(users);
                }
                Conn.Close();

                return asesor;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return asesor;
            }
            
        }


        public ModeloNegocio.Asesor getAsesorCode(string code)
        {

            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            ModeloNegocio.Asesor asesor = new ModeloNegocio.Asesor();
            try
            {

                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[otaku_bcp].PA_LISTA_USER_CODE";
                Cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = code;

                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {

                    asesor.id = Convert.ToInt32(Dtr["id"]);
                    asesor.FullName = Dtr["name"].ToString();
                    asesor.Codigo = Dtr["codigo"].ToString();
                    asesor.Email = Dtr["email"].ToString();
                    asesor.Telefono = Dtr["telefono"].ToString();
                    asesor.Grupo = Dtr["grupo"].ToString();
                    asesor.Password = Dtr["password"].ToString();
                    asesor.Selection = Convert.ToByte(Dtr["selection"]);

                    //users.Type = Dtr["type"].ToString();


                    if (DBNull.Value.Equals(Dtr["created_at"]))
                    {
                        asesor.FechaCreado = DateTime.Now;
                    }
                    else
                    {
                        asesor.FechaCreado = DateTime.Parse(Dtr["created_at"].ToString());
                    }

                    if (DBNull.Value.Equals(Dtr["updated_at"]))
                    {
                        asesor.FechaActualizado = DateTime.Now;
                    }
                    else
                    {
                        asesor.FechaActualizado = DateTime.Parse(Dtr["updated_at"].ToString());
                    }


                    ModeloNegocio.TypeUser typeUser = new ModeloNegocio.TypeUser();
                    typeUser.Id = Convert.ToInt16(Dtr["id_type"]);
                    typeUser.Name = Dtr["name_type_user"].ToString();

                    asesor.typeUser = typeUser;

                    //lista.Add(users);
                }
                Conn.Close();

                return asesor;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return asesor;
            }

        }

        public bool setPasswordUser(int assesor_id, string email , string password )
        {

            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            //ModeloNegocio.Asesor asesor = new ModeloNegocio.Asesor();
            try
            {

                Security encriptaPassword = new Security();
                String passwordNewEncripta = encriptaPassword.Encrypt(password);

                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[otaku_bcp].PA_ING_PASSWORD_USER";
                Cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = assesor_id;
                Cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                Cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = passwordNewEncripta;


                Cmd.ExecuteReader();

               return true;

            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return false;
            }

        }
        public int insertAsesor(ModeloNegocio.Asesor ObjAsesor)
        {

            try
            {
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[otaku_bcp].PA_ING_ASESOR";
                Cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = ObjAsesor.Codigo;
                Cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = ObjAsesor.FullName;
                Cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = ObjAsesor.Telefono;
                Cmd.Parameters.Add("@grupo", SqlDbType.VarChar).Value = ObjAsesor.Grupo;
                Cmd.Parameters.Add("@id_type", SqlDbType.Int).Value = ObjAsesor.Type;

                Cmd.Parameters.Add("@user_assesor_id", SqlDbType.Int).Direction = ParameterDirection.Output;

                Cmd.ExecuteNonQuery();

                ObjAsesor.id = Convert.ToInt32(Cmd.Parameters["@user_assesor_id"].Value);

                Conn.Close();
                return ObjAsesor.id;
            }
            catch (Exception e)
            {
                // Console.WriteLine("{0} Problem insert.", e);
                //throw new Exception("Error en Acceso a Datos: InsertarMonto.", e);
                return 0;
            }
            //throw new NotImplementedException();

           
        }

        public bool insertSchool(ModeloNegocio.School ObjSchool)
        {
            throw new NotImplementedException();
        }

        public bool deleteAsesor(int iduser)
        {
            Cmd = new SqlCommand();
            Cmd.Connection = Conn; 
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[otaku_bcp].PA_OBT_ELIMINA_USER";
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

        public bool updateAsesor(ModeloNegocio.Asesor ObjAsesor)
        {
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[otaku_bcp].PA_OBT_UPDATE_ASESOR";
                Cmd.Parameters.Add("@iduser", SqlDbType.Int).Value = ObjAsesor.id;
                Cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = ObjAsesor.Codigo;
                Cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = ObjAsesor.FullName;
                Cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = ObjAsesor.Telefono;
                Cmd.Parameters.Add("@grupo", SqlDbType.VarChar).Value = ObjAsesor.Grupo;
                Cmd.ExecuteNonQuery();
                Conn.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return false;
            }

        }

        public int countRowsAsesores()
        {
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            int total_rows = 0;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[otaku_bcp].PA_COUNT_ROWS_ASESOR";

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
