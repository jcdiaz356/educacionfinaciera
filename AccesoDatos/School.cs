using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModeloNegocio;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public class School
    {
        private SqlConnection Conn;
        private SqlCommand Cmd;
        private SqlDataReader Dtr;
        private DataTable Dt;

        public School()
        {
            AccesoDatos.Conexion objConexion = new AccesoDatos.Conexion();
            Conn = objConexion.abrirConexion();
           
        }
        public List<ModeloNegocio.School> getAllSchool(int registroAMostrar, int registroAEmpezar)
        {
            List<ModeloNegocio.School> lista = new List<ModeloNegocio.School>();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_LISTA_SCHOOLS";
                Cmd.Parameters.Add("@RegistrosAMostrar", SqlDbType.Int).Value = registroAMostrar;
                Cmd.Parameters.Add("@RegistrosAEmpezar", SqlDbType.Int).Value = registroAEmpezar;
                //Cmd.Parameters.Add("@tipoUser", SqlDbType.Int).Value = 7;
                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {
                    ModeloNegocio.School school = new ModeloNegocio.School();
                    school.id = Convert.ToInt32(Dtr["id"]);
                    school.Codigo = Dtr["codigo"].ToString();
                    school.Nombre = Dtr["nombre"].ToString();
                    
                    school.Ugel_id = Convert.ToInt32(Dtr["ugel_id"]);
                    if (DBNull.Value.Equals(Dtr["created_at"]))
                    {
                        school.FechaCreado = DateTime.Now;

                    }
                    else
                    {
                        school.FechaCreado = DateTime.Parse(Dtr["created_at"].ToString());
                    }
                    lista.Add(school);
                }
                Conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return lista;

        }

        public List<ModeloNegocio.School> getAllSchoolNoSelect()
        {
            List<ModeloNegocio.School> lista = new List<ModeloNegocio.School>();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_LISTA_SCHOOLS_NO_SELECT";

                //Cmd.Parameters.Add("@tipoUser", SqlDbType.Int).Value = 7;
                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {
                    ModeloNegocio.School school = new ModeloNegocio.School();
                    school.id = Convert.ToInt32(Dtr["id"]);
                    school.Codigo = Dtr["codigo"].ToString();
                    school.Nombre = Dtr["nombre"].ToString();

                    school.Ugel_id = Convert.ToInt32(Dtr["ugel_id"]);
                    if (DBNull.Value.Equals(Dtr["created_at"]))
                    {
                        school.FechaCreado = DateTime.Now;

                    }
                    else
                    {
                        school.FechaCreado = DateTime.Parse(Dtr["created_at"].ToString());
                    }
                    lista.Add(school);
                }
                Conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return lista;

        }

        public List<ModeloNegocio.School> getAllSchool()
        {
            List<ModeloNegocio.School> lista = new List<ModeloNegocio.School>();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_LISTA_ALL_SCHOOLS";
                
                //Cmd.Parameters.Add("@tipoUser", SqlDbType.Int).Value = 7;
                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {
                    ModeloNegocio.School school = new ModeloNegocio.School();
                    school.id = Convert.ToInt32(Dtr["id"]);
                    school.Codigo = Dtr["codigo"].ToString();
                    school.Nombre = Dtr["nombre"].ToString();

                    school.Ugel_id = Convert.ToInt32(Dtr["ugel_id"]);
                    if (DBNull.Value.Equals(Dtr["created_at"]))
                    {
                        school.FechaCreado = DateTime.Now;

                    }
                    else
                    {
                        school.FechaCreado = DateTime.Parse(Dtr["created_at"].ToString());
                    }
                    lista.Add(school);
                }
                Conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return lista;

        }


        public List<ModeloNegocio.Docente> getAllDocenteSchool(int idShool)
        {
            List<ModeloNegocio.Docente> lista = new List<ModeloNegocio.Docente>();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_GET_DOCENTE_SCHOOL";
                Cmd.Parameters.Add("@idschool", SqlDbType.Int).Value = idShool;

                //Cmd.Parameters.Add("@tipoUser", SqlDbType.Int).Value = 7;
                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {
                    ModeloNegocio.Docente docente = new ModeloNegocio.Docente();
                    docente.id = Convert.ToInt32(Dtr["id"].ToString());
                    docente.Codigo = Dtr["codigo"].ToString();
                    docente.FullName = Dtr["name"].ToString();

                    
                    lista.Add(docente);
                }
                Conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return lista;

        }

        public ModeloNegocio.Director getDirectorSchool(int idShool)
        {
            List<ModeloNegocio.Director> lista = new List<ModeloNegocio.Director>();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            ModeloNegocio.Director director = new ModeloNegocio.Director();
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_GET_DIRECTOR_SCHOOL";
                Cmd.Parameters.Add("@idschool", SqlDbType.Int).Value = idShool;

                //Cmd.Parameters.Add("@tipoUser", SqlDbType.Int).Value = 7;
                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {
                    
                    director.id = Convert.ToInt32(Dtr["id"].ToString());
                    director.Codigo = Dtr["codigo"].ToString();
                    director.FullName = Dtr["name"].ToString();


                    //lista.Add(director);
                }
                Conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return director;

        }
        public ModeloNegocio.School insertSchool(ModeloNegocio.School ObjSchool)
        {
            
            try
            {
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_INGSCHOOL";
                Cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = ObjSchool.Codigo;
                Cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = ObjSchool.Nombre;
                Cmd.Parameters.Add("@ugel_id", SqlDbType.Int).Value = ObjSchool.Ugel_id;
                Cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = ObjSchool.Telefono;
                Cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = ObjSchool.Direccion;
                Cmd.Parameters.Add("@distrito_id", SqlDbType.Int).Value = ObjSchool.Distrito_id;
                Cmd.Parameters.Add("@referencia", SqlDbType.VarChar).Value = ObjSchool.Referencia;
                Cmd.Parameters.Add("@director", SqlDbType.VarChar).Value = ObjSchool.Director;
                Cmd.Parameters.Add("@subdirector", SqlDbType.VarChar).Value = ObjSchool.Subdirector;
                Cmd.Parameters.Add("@latitud", SqlDbType.VarChar).Value = ObjSchool.Latitud;
                Cmd.Parameters.Add("@longitud", SqlDbType.VarChar).Value = ObjSchool.Longitud;
                Cmd.Parameters.Add("@numdochge", SqlDbType.Int).Value = ObjSchool.Num_Doc_hge;
                Cmd.Parameters.Add("@numdocini", SqlDbType.Int).Value = ObjSchool.Num_doc_inicial;
                Cmd.Parameters.Add("@numdocprim", SqlDbType.Int).Value = ObjSchool.Num_doc_primaria;
                Cmd.Parameters.Add("@numdocsec", SqlDbType.Int).Value = ObjSchool.Num_doc_secundaria;
                Cmd.Parameters.Add("@numalumini", SqlDbType.Int).Value = ObjSchool.Num_alum_ini;
                Cmd.Parameters.Add("@numalumprim", SqlDbType.Int).Value = ObjSchool.Num_alum_prim;
                Cmd.Parameters.Add("@numalumsec", SqlDbType.Int).Value = ObjSchool.Num_alum_sec;
                Cmd.Parameters.Add("@numaulas", SqlDbType.Int).Value = ObjSchool.Num_aulas;
                Cmd.Parameters.Add("@numseccprim", SqlDbType.Int).Value = ObjSchool.Num_secc_prim;
                Cmd.Parameters.Add("@numseccsec", SqlDbType.Int).Value = ObjSchool.Num_secc_sec;
                Cmd.Parameters.Add("@idschool", SqlDbType.Int).Direction = ParameterDirection.Output;
               
                Cmd.ExecuteNonQuery();

                ObjSchool.id = Convert.ToInt32(Cmd.Parameters["@idschool"].Value);

                Conn.Close();
                return ObjSchool;
            }
            catch (Exception e)
            {
               // Console.WriteLine("{0} Problem insert.", e);
                //throw new Exception("Error en Acceso a Datos: InsertarMonto.", e);
                return ObjSchool;
            }
            //throw new NotImplementedException();
            
            
        }

        public bool updateSchool(ModeloNegocio.School ObjSchool)
        {

            try
            {
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_OBT_UPDATE_SCHOOL";
                Cmd.Parameters.Add("@idschool", SqlDbType.Int).Value = ObjSchool.id;
                Cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = ObjSchool.Codigo;
                Cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = ObjSchool.Nombre;
                Cmd.Parameters.Add("@ugel_id", SqlDbType.Int).Value = ObjSchool.Ugel_id;
                Cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = ObjSchool.Telefono;
                Cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = ObjSchool.Direccion;
                Cmd.Parameters.Add("@distrito_id", SqlDbType.Int).Value = ObjSchool.Distrito_id;
                Cmd.Parameters.Add("@referencia", SqlDbType.VarChar).Value = ObjSchool.Referencia;
                Cmd.Parameters.Add("@director", SqlDbType.VarChar).Value = ObjSchool.Director;
                Cmd.Parameters.Add("@subdirector", SqlDbType.VarChar).Value = ObjSchool.Subdirector;
                Cmd.Parameters.Add("@latitud", SqlDbType.VarChar).Value = ObjSchool.Latitud;
                Cmd.Parameters.Add("@longitud", SqlDbType.VarChar).Value = ObjSchool.Longitud;
                Cmd.Parameters.Add("@numdochge", SqlDbType.Int).Value = ObjSchool.Num_Doc_hge;
                Cmd.Parameters.Add("@numdocini", SqlDbType.Int).Value = ObjSchool.Num_doc_inicial;
                Cmd.Parameters.Add("@numdocprim", SqlDbType.Int).Value = ObjSchool.Num_doc_primaria;
                Cmd.Parameters.Add("@numdocsec", SqlDbType.Int).Value = ObjSchool.Num_doc_secundaria;
                Cmd.Parameters.Add("@numalumini", SqlDbType.Int).Value = ObjSchool.Num_alum_ini;
                Cmd.Parameters.Add("@numalumprim", SqlDbType.Int).Value = ObjSchool.Num_alum_prim;
                Cmd.Parameters.Add("@numalumsec", SqlDbType.Int).Value = ObjSchool.Num_alum_sec;
                Cmd.Parameters.Add("@numaulas", SqlDbType.Int).Value = ObjSchool.Num_aulas;
                Cmd.Parameters.Add("@numseccprim", SqlDbType.Int).Value = ObjSchool.Num_secc_prim;
                Cmd.Parameters.Add("@numseccsec", SqlDbType.Int).Value = ObjSchool.Num_secc_sec;

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

        public bool deleteSchool(int idSchool)
        {
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_OBT_ELIMINA_SCHOOL";
                Cmd.Parameters.Add("@idschool", SqlDbType.Int).Value = idSchool;
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

        public void getSchool(ref ModeloNegocio.School ObjSchool)
        {
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            SqlDataReader Reader;
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_GET_SCHOOL_ID";
                Cmd.Parameters.Add("@idschool", SqlDbType.Int).Value = ObjSchool.id;
                Reader = Cmd.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        ObjSchool.id =  Convert.ToInt32(Reader["id"]);
                        ObjSchool.Nombre = Reader["nombre"].ToString();
                        if (DBNull.Value.Equals(Reader["codigo"]))
                        {
                            ObjSchool.Codigo = "";
                        }
                        else
                        {
                            ObjSchool.Codigo = Reader["codigo"].ToString();
                        }
                        if (DBNull.Value.Equals(Reader["telefono"]))
                        {
                            ObjSchool.Telefono = "";
                        }
                        else
                        {
                            ObjSchool.Telefono = Reader["telefono"].ToString();
                        }

                        if (DBNull.Value.Equals(Reader["direccion"]))
                        {
                            ObjSchool.Direccion = "";
                        }
                        else
                        {
                            ObjSchool.Direccion = Reader["direccion"].ToString();
                        }

                        if (DBNull.Value.Equals(Reader["distrito_id"]))
                        {
                            ObjSchool.Distrito_id = 0;
                        }
                        else
                        {
                            ObjSchool.Distrito_id = Convert.ToInt32(Reader["distrito_id"]);
                        }

                        if (DBNull.Value.Equals(Reader["referencia"]))
                        {
                            ObjSchool.Referencia = "";
                        }
                        else
                        {
                            ObjSchool.Referencia = Reader["referencia"].ToString();
                        }

                        if (DBNull.Value.Equals(Reader["director"]))
                        {
                            ObjSchool.Director = "";
                        }
                        else
                        {
                            ObjSchool.Director = Reader["director"].ToString();
                        }

                        if (DBNull.Value.Equals(Reader["subdirector"]))
                        {
                            ObjSchool.Subdirector = "";
                        }
                        else
                        {
                            ObjSchool.Subdirector = Reader["subdirector"].ToString();
                        }

                        if (DBNull.Value.Equals(Reader["ugel_id"]))
                        {
                            ObjSchool.Ugel_id = 0;
                        }
                        else
                        {
                            ObjSchool.Ugel_id = Convert.ToInt32(Reader["ugel_id"]);
                        }

                        if (DBNull.Value.Equals(Reader["nombre_ugel"]))
                        {
                            ObjSchool.Ugel = "";
                        }
                        else
                        {
                            ObjSchool.Ugel = Reader["nombre_ugel"].ToString();
                        }
                        if (DBNull.Value.Equals(Reader["latitud"]))
                        {
                            ObjSchool.Latitud = "";
                        }
                        else
                        {
                            ObjSchool.Latitud = Reader["latitud"].ToString();
                        }
                        if (DBNull.Value.Equals(Reader["longitud"]))
                        {
                            ObjSchool.Longitud = "";
                        }
                        else
                        {
                            ObjSchool.Longitud = Reader["longitud"].ToString();
                        }
                        if (DBNull.Value.Equals(Reader["num_alum_ini"]))
                        {
                            ObjSchool.Num_alum_ini = 0;
                        }
                        else
                        {
                            ObjSchool.Num_alum_ini = Convert.ToInt32(Reader["num_alum_ini"]);
                        }
                        if (DBNull.Value.Equals(Reader["num_alum_prim"]))
                        {
                            ObjSchool.Num_alum_prim = 0;
                        }
                        else
                        {
                            ObjSchool.Num_alum_prim = Convert.ToInt32(Reader["num_alum_prim"]);
                        }
                        if (DBNull.Value.Equals(Reader["num_alum_sec"]))
                        {
                            ObjSchool.Num_alum_sec = 0;
                        }
                        else
                        {
                            ObjSchool.Num_alum_sec = Convert.ToInt32(Reader["num_alum_sec"]);
                        }
                        if (DBNull.Value.Equals(Reader["num_aulas"]))
                        {
                            ObjSchool.Num_aulas = 0;
                        }
                        else
                        {
                            ObjSchool.Num_aulas = Convert.ToInt32(Reader["num_aulas"]);
                        }
                        if (DBNull.Value.Equals(Reader["num_doc_hge"]))
                        {
                            ObjSchool.Num_Doc_hge = 0;
                        }
                        else
                        {
                            ObjSchool.Num_Doc_hge = Convert.ToInt32(Reader["num_doc_hge"]);
                        }
                        if (DBNull.Value.Equals(Reader["num_doc_ini"]))
                        {
                            ObjSchool.Num_doc_inicial = 0;
                        }
                        else
                        {
                            ObjSchool.Num_doc_inicial = Convert.ToInt32(Reader["num_doc_ini"]);
                        }
                        if (DBNull.Value.Equals(Reader["num_doc_prim"]))
                        {
                            ObjSchool.Num_doc_primaria = 0;
                        }
                        else
                        {
                            ObjSchool.Num_doc_primaria = Convert.ToInt32(Reader["num_doc_prim"]);
                        }
                        if (DBNull.Value.Equals(Reader["num_doc_sec"]))
                        {
                            ObjSchool.Num_doc_secundaria = 0;
                        }
                        else
                        {
                            ObjSchool.Num_doc_secundaria = Convert.ToInt32(Reader["num_doc_sec"]);
                        }
                        if (DBNull.Value.Equals(Reader["num_secc_prim"]))
                        {
                            ObjSchool.Num_secc_prim = 0;
                        }
                        else
                        {
                            ObjSchool.Num_secc_prim = Convert.ToInt32(Reader["num_secc_prim"]);
                        }
                        if (DBNull.Value.Equals(Reader["num_secc_sec"]))
                        {
                            ObjSchool.Num_secc_sec = 0;
                        }
                        else
                        {
                            ObjSchool.Num_secc_sec = Convert.ToInt32(Reader["num_secc_sec"]);
                        }

                        ObjSchool.FechaCreado = Convert.ToDateTime(Reader["created_at"]);
                        ObjSchool.FechaActualizado = Convert.ToDateTime(Reader["updated_at"]);

                        
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                Reader.Close();
                Conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }

        public ModeloNegocio.School getSchool(int school_id)
        {
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            SqlDataReader Reader;

            ModeloNegocio.School ObjSchool = new ModeloNegocio.School();
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_GET_SCHOOL_ID";
                Cmd.Parameters.Add("@idschool", SqlDbType.Int).Value = school_id;
                Reader = Cmd.ExecuteReader();
                //if (Reader.HasRows)
                //{
                    while (Reader.Read())
                    {
                        ObjSchool.id = Convert.ToInt32(Reader["id"]);
                        //ObjSchool.Nombre = Reader["nombre"].ToString();

                        if (DBNull.Value.Equals(Reader["nombre"]))
                        {
                            ObjSchool.Nombre = "";
                        }
                        else
                        {
                            ObjSchool.Nombre = Reader["nombre"].ToString();
                        }


                        if (DBNull.Value.Equals(Reader["codigo"]))
                        {
                            ObjSchool.Codigo = "";
                        }
                        else
                        {
                            ObjSchool.Codigo = Reader["codigo"].ToString();
                        }


                        if (DBNull.Value.Equals(Reader["telefono"]))
                        {
                            ObjSchool.Telefono = "";
                        }
                        else
                        {
                            ObjSchool.Telefono = Reader["telefono"].ToString();
                        }

                        if (DBNull.Value.Equals(Reader["direccion"]))
                        {
                            ObjSchool.Direccion = "";
                        }
                        else
                        {
                            ObjSchool.Direccion = Reader["direccion"].ToString();
                        }

                        if (DBNull.Value.Equals(Reader["distrito_id"]))
                        {
                            ObjSchool.Distrito_id = 0;
                        }
                        else
                        {
                            ObjSchool.Distrito_id = Convert.ToInt32(Reader["distrito_id"]);
                        }

                        if (DBNull.Value.Equals(Reader["referencia"]))
                        {
                            ObjSchool.Referencia = "";
                        }
                        else
                        {
                            ObjSchool.Referencia = Reader["referencia"].ToString();
                        }

                        if (DBNull.Value.Equals(Reader["director"]))
                        {
                            ObjSchool.Director = "";
                        }
                        else
                        {
                            ObjSchool.Director = Reader["director"].ToString();
                        }

                        if (DBNull.Value.Equals(Reader["subdirector"]))
                        {
                            ObjSchool.Subdirector = "";
                        }
                        else
                        {
                            ObjSchool.Subdirector = Reader["subdirector"].ToString();
                        }

                        if (DBNull.Value.Equals(Reader["ugel_id"]))
                        {
                            ObjSchool.Ugel_id = 0;
                        }
                        else
                        {
                            ObjSchool.Ugel_id = Convert.ToInt32(Reader["ugel_id"]);
                        }

                        if (DBNull.Value.Equals(Reader["nombre_ugel"]))
                        {
                            ObjSchool.Ugel = "";
                        }
                        else
                        {
                            ObjSchool.Ugel = Reader["nombre_ugel"].ToString();
                        }
                        if (DBNull.Value.Equals(Reader["latitud"]))
                        {
                            ObjSchool.Latitud = "";
                        }
                        else
                        {
                            ObjSchool.Latitud = Reader["latitud"].ToString();
                        }
                        if (DBNull.Value.Equals(Reader["longitud"]))
                        {
                            ObjSchool.Longitud = "";
                        }
                        else
                        {
                            ObjSchool.Longitud = Reader["longitud"].ToString();
                        }
                        if (DBNull.Value.Equals(Reader["num_alum_ini"]))
                        {
                            ObjSchool.Num_alum_ini = 0;
                        }
                        else
                        {
                            ObjSchool.Num_alum_ini = Convert.ToInt32(Reader["num_alum_ini"]);
                        }
                        if (DBNull.Value.Equals(Reader["num_alum_prim"]))
                        {
                            ObjSchool.Num_alum_prim = 0;
                        }
                        else
                        {
                            ObjSchool.Num_alum_prim = Convert.ToInt32(Reader["num_alum_prim"]);
                        }
                        if (DBNull.Value.Equals(Reader["num_alum_sec"]))
                        {
                            ObjSchool.Num_alum_sec = 0;
                        }
                        else
                        {
                            ObjSchool.Num_alum_sec = Convert.ToInt32(Reader["num_alum_sec"]);
                        }
                        if (DBNull.Value.Equals(Reader["num_aulas"]))
                        {
                            ObjSchool.Num_aulas = 0;
                        }
                        else
                        {
                            ObjSchool.Num_aulas = Convert.ToInt32(Reader["num_aulas"]);
                        }
                        if (DBNull.Value.Equals(Reader["num_doc_hge"]))
                        {
                            ObjSchool.Num_Doc_hge = 0;
                        }
                        else
                        {
                            ObjSchool.Num_Doc_hge = Convert.ToInt32(Reader["num_doc_hge"]);
                        }
                        if (DBNull.Value.Equals(Reader["num_doc_ini"]))
                        {
                            ObjSchool.Num_doc_inicial = 0;
                        }
                        else
                        {
                            ObjSchool.Num_doc_inicial = Convert.ToInt32(Reader["num_doc_ini"]);
                        }
                        if (DBNull.Value.Equals(Reader["num_doc_prim"]))
                        {
                            ObjSchool.Num_doc_primaria = 0;
                        }
                        else
                        {
                            ObjSchool.Num_doc_primaria = Convert.ToInt32(Reader["num_doc_prim"]);
                        }
                        if (DBNull.Value.Equals(Reader["num_doc_sec"]))
                        {
                            ObjSchool.Num_doc_secundaria = 0;
                        }
                        else
                        {
                            ObjSchool.Num_doc_secundaria = Convert.ToInt32(Reader["num_doc_sec"]);
                        }
                        if (DBNull.Value.Equals(Reader["num_secc_prim"]))
                        {
                            ObjSchool.Num_secc_prim = 0;
                        }
                        else
                        {
                            ObjSchool.Num_secc_prim = Convert.ToInt32(Reader["num_secc_prim"]);
                        }
                        if (DBNull.Value.Equals(Reader["num_secc_sec"]))
                        {
                            ObjSchool.Num_secc_sec = 0;
                        }
                        else
                        {
                            ObjSchool.Num_secc_sec = Convert.ToInt32(Reader["num_secc_sec"]);
                        }

                        ObjSchool.FechaCreado = Convert.ToDateTime(Reader["created_at"]);
                        ObjSchool.FechaActualizado = Convert.ToDateTime(Reader["updated_at"]);


                    }
                //}
                //else
                //{
                //    Console.WriteLine("No rows found.");
                //}

                Reader.Close();
                Conn.Close();
                return ObjSchool;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return ObjSchool;
            }
        }


        public int countRowsSchool()
        {
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            int total_rows = 0;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_COUNT_ROWS_SCHOOL";

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

        public DataTable getCountSchoolForUgel()
        {
            Dt = new DataTable();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_COUNT_SCHOOL_FOR_UGEL";
                Dtr = Cmd.ExecuteReader();
                Dt.Constraints.Clear();
                Dt.BeginLoadData();
                Dt.Load(Dtr);
                Dtr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return Dt;

        }

        public DataTable getCountStudentsForSchool()
        {
            Dt = new DataTable();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_COUNT_STUDENTS_FOR_SCHOOL";
                Dtr = Cmd.ExecuteReader();
                Dt.Constraints.Clear();
                Dt.BeginLoadData();
                Dt.Load(Dtr);
                Dtr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return Dt;

        }

        public DataTable getCountSchoolForAsesor()
        {
            Dt = new DataTable();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_COUNT_SCHOOL_FOR_ASESOR";
                Dtr = Cmd.ExecuteReader();
                Dt.Constraints.Clear();
                Dt.BeginLoadData();
                Dt.Load(Dtr);
                Dtr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return Dt;

        }
  
    }
}
