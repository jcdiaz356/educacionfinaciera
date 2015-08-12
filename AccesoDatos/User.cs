using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MySql.Data.MySqlClient;
using ModeloNegocio;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.IO;
namespace AccesoDatos
{
    public class User
    {
        private SqlConnection Conn;
        private SqlCommand Cmd;
        private SqlDataReader Dtr;
        private DataTable Dt;

        public User()
        {
            AccesoDatos.Conexion objConexion = new AccesoDatos.Conexion();
            Conn = objConexion.abrirConexion();
        }

        public List<ModeloNegocio.Asesor> getAllUsers()
        {
            List<ModeloNegocio.Asesor> lista = new List<ModeloNegocio.Asesor>();
            //List<Autos> LstAutos = new List<Autos>();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = "SELECT otaku_bcp.[user].id, otaku_bcp.[user].name, otaku_bcp.[user].email, otaku_bcp.[user].password, otaku_bcp.[user].id_type, otaku_bcp.type_user.name AS type_user_name FROM  otaku_bcp.type_user"  +
                               " INNER JOIN otaku_bcp.[user] ON (otaku_bcp.type_user.id = otaku_bcp.[user].id_type)";
            Dtr = Cmd.ExecuteReader();

            while (Dtr.Read())
            {
                ModeloNegocio.Asesor users = new ModeloNegocio.Asesor();
                users.id = Convert.ToInt32(Dtr["id"]);
                users.FullName = Dtr["name"].ToString();
                //users.Type = Dtr["type"].ToString();
                users.Email = Dtr["email"].ToString();

                ModeloNegocio.TypeUser typeUser = new ModeloNegocio.TypeUser();
                typeUser.Id = Convert.ToInt16(Dtr["id_type"]);
                typeUser.Name = Dtr["type_user_name"].ToString();

                users.typeUser = typeUser;

                lista.Add(users);
            }
            return lista;
        }


        public ModeloNegocio.Asesor loginUsuario(string email, string password)
        {
            try
            {
                ModeloNegocio.Asesor user = new ModeloNegocio.Asesor();
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandText = "select [user].id, [user].email,  [user].name, [user].password, [user].id_type, type_user.name AS name_type from [user] INNER JOIN type_user ON ([user].id_type = type_user.id) where email=@email and password=@password ";
                //String passWordEncriptado;
                //passWordEncriptado = encriptaPassword(password);


                //Cmd.Parameters.Add("@nombre", DbType.String);("@nombre", DbType.String)"@password", DbType.String)
                //Cmd.Parameters.Add(new SQLiteParameter {ParameterName="@nombre" , Value = Usuario });
                //Cmd.Parameters.Add(new SQLiteParameter { ParameterName = "@password", Value = Password });
                //Cmd.Parameters["@nombre"].Value = Usuario;
                //Cmd.Parameters.Add("@password",DbType.String );
                //Cmd.Parameters["@password"].Value = Password;

                Cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar, 250));
                Cmd.Parameters["@email"].Value = email;
                Cmd.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar, 250));
                Cmd.Parameters["@password"].Value = Encrypt(password);
                Dtr = Cmd.ExecuteReader();
                 
                while (Dtr.Read())
                {
                    //Lista.Add(new EntidadNegocio.UsuarioEN(Convert.ToInt32(Dtr["idusuario"]), Dtr["nombre"].ToString(), Dtr["usuario"].ToString(), Dtr["password"].ToString(), Convert.ToInt32(Dtr["permiso"])));

                    user.id = Convert.ToInt32(Dtr["id"]);
                    user.Email = Convert.ToString(Dtr["email"]);
                    user.FullName = Convert.ToString(Dtr["name"]);
                    user.Type  = Convert.ToInt32(Dtr["id_type"]);
                    user.Password = Convert.ToString(Dtr["password"]);

                    ModeloNegocio.TypeUser typeUser = new ModeloNegocio.TypeUser();

                    typeUser.Id = Convert.ToInt32(Dtr["id_type"]);
                    typeUser.Name = Convert.ToString(Dtr["name_type"]);

                    user.typeUser = typeUser;
                    
                      
                }

                Cmd.Parameters.Clear();
                Dtr.Close();
                Conn.Close();

                
                //Boolean ckecPassword1 = chekPassword(password,user.Password.ToString());


                
                    return user;
                
                    
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Acceso a Datos: LoginUsuario.", ex);
            }

        }




        private string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        private string Decrypt(string cipherText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

        public ModeloNegocio.User getUser(int iduser)
        {
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            SqlDataReader Reader;
            ModeloNegocio.User User= new ModeloNegocio.User();
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_GET_USER_ID";
                Cmd.Parameters.Add("@iduser", SqlDbType.Int).Value = iduser;
                Reader = Cmd.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        User.id = Reader.GetInt32(0);
                        User.FullName = Reader.GetString(1);
                        if (DBNull.Value.Equals(Reader.GetString(2)))
                        {
                            User.Codigo = "";
                        }
                        else
                        {
                            User.Codigo = Reader.GetString(2);
                        }
                        if (!Reader.IsDBNull(Reader.GetOrdinal("email")))
                        {
                            User.Email = Reader.GetString(3);
                        }
                        else
                        {
                            User.Email = "";
                        }
                        
                        if (DBNull.Value.Equals(Reader.GetString(4)))
                        {
                            User.Telefono = "";
                        }
                        else
                        {
                            User.Telefono = Reader.GetString(4);
                        }
                        
                        User.FechaCreado = Reader.GetDateTime(5);
                        User.FechaActualizado = Reader.GetDateTime(6);

                        ModeloNegocio.TypeUser typeUser = new ModeloNegocio.TypeUser();
                        typeUser.Id = Reader.GetInt32(7);
                        typeUser.Name = Reader.GetString(8);
                        User.typeUser = typeUser;

                        if (!Reader.IsDBNull(Reader.GetOrdinal("grupo")))
                        {
                            User.Grupo = Reader.GetString(9);
                        }
                        else
                        {
                            User.Grupo = "";
                        }
                        
                        //User.Selection = Reader.GetByte(10);
                        if (!Reader.IsDBNull(Reader.GetOrdinal("type_contract")))
                        {
                            User.TypeContract = Reader.GetString(11);
                        }
                        else
                        {
                            User.TypeContract = "";
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                Reader.Close();
                Conn.Close();
                return User;
            }
            catch (Exception e)
            {
                return User;
                Console.WriteLine("{0} Exception caught.", e);
            }
        }


    }
}
