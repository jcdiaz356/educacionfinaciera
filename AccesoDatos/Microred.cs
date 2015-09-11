using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AccesoDatos
{
    public class Microred
    {
        private SqlConnection Conn;
        private SqlCommand Cmd;
        private SqlDataReader Dtr;
        private DataTable Dt;

        public Microred()
        {
            AccesoDatos.Conexion objConexion = new AccesoDatos.Conexion();
            Conn = objConexion.abrirConexion();
        }


        public List<ModeloNegocio.Microred> getAllMicroredes(int registroAMostrar, int registroAEmpezar)
        {
            List<ModeloNegocio.Microred> lista = new List<ModeloNegocio.Microred>();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_LISTA_MICROREDES";
                Cmd.Parameters.Add("@RegistrosAMostrar", SqlDbType.Int).Value = registroAMostrar;
                Cmd.Parameters.Add("@RegistrosAEmpezar", SqlDbType.Int).Value = registroAEmpezar;
                
                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {
                    ModeloNegocio.Microred microred = new ModeloNegocio.Microred();
                    microred.Id = Convert.ToInt32(Dtr["id"]);
                    microred.Fecha = Convert.ToDateTime(Dtr["fecha"]);
                    microred.User_id = Convert.ToInt32(Dtr["user_id"]);
                    microred.MicroredName = Dtr["microred"].ToString();
                    microred.Lugar_sesion = Dtr["lugar_sesion"].ToString();
                    microred.H_inicio =Convert.ToDateTime(Dtr["h_inicio"].ToString());
                    microred.H_termino = Convert.ToDateTime(Dtr["h_termino"].ToString());
                    microred.Num_participantes = Convert.ToInt32(Dtr["num_participantes"]);
                    microred.Educ_financiera = Dtr["educ_financiera"].ToString();
                    microred.Enfoques_edu = Dtr["enfoques_edu"].ToString();
                    microred.Programacion_ped = Dtr["programacion_ped"].ToString();
                    microred.Habilidad_ped = Dtr["habilidad_ped"].ToString();
                    microred.Trabajo_grupal = Dtr["trabajo_grupal"].ToString();
                    microred.Participativo = Dtr["participativo"].ToString();
                    microred.Expositivo = Dtr["expositivo"].ToString();
                    microred.Dinamicas_ludicas = Dtr["dinamicas_ludicas"].ToString();
                    microred.Recursos_informaticos = Dtr["recursos_informaticos"].ToString();
                    microred.Recursos_audiovisuales = Dtr["recursos_audiovisuales"].ToString();
                    microred.Materiales_didaticos = Dtr["materiales_didacticos"].ToString();
                    microred.Observacion = Dtr["observacion"].ToString();
                    microred.Created_at = Convert.ToDateTime(Dtr["created_at"]);
                    microred.Updated_at =Convert.ToDateTime(Dtr["updated_at"]);
                    



                    ////users.Type = Dtr["type"].ToString();
                    //microred.Email = Dtr["email"].ToString();

                    //if (DBNull.Value.Equals(Dtr["created_at"]))
                    //{
                    //    users.FechaCreado = DateTime.Now;
                    //}
                    //else
                    //{
                    //    users.FechaCreado = DateTime.Parse(Dtr["created_at"].ToString());
                    //}




                    lista.Add(microred);
                }
                Conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return lista;

        }

        public ModeloNegocio.Microred getMicroredId(int microred_id)
        {

            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            ModeloNegocio.Microred microred = new ModeloNegocio.Microred();
            try
            {

                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_GET_MICRORED_ID";
                Cmd.Parameters.Add("@microred_id", SqlDbType.Int).Value = microred_id;

                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {
                    
                    microred.Id = Convert.ToInt32(Dtr["id"]);
                    microred.Fecha = DateTime.Parse(Dtr["fecha"].ToString());
                    microred.User_id =  Convert.ToInt32(Dtr["user_id"]) ;

                    microred.MicroredName = Dtr["microred"].ToString();

                    microred.Lugar_sesion = Dtr["lugar_sesion"].ToString();
                    microred.H_inicio = DateTime.Parse(Dtr["h_inicio"].ToString());
                    microred.H_termino = DateTime.Parse(Dtr["h_termino"].ToString());
                    microred.Num_participantes = Convert.ToInt32(Dtr["num_participantes"]);
                    microred.Educ_financiera = Dtr["educ_financiera"].ToString();
                    microred.Enfoques_edu = Dtr["enfoques_edu"].ToString();
                    microred.Programacion_ped = Dtr["programacion_ped"].ToString();
                    microred.Habilidad_ped = Dtr["habilidad_ped"].ToString();
                    microred.Trabajo_grupal = Dtr["trabajo_grupal"].ToString();
                    microred.Participativo = Dtr["participativo"].ToString();
                    microred.Expositivo = Dtr["expositivo"].ToString();
                    microred.Dinamicas_ludicas = Dtr["dinamicas_ludicas"].ToString();
                    microred.Recursos_informaticos = Dtr["recursos_informaticos"].ToString();
                    microred.Recursos_audiovisuales = Dtr["recursos_audiovisuales"].ToString();
                    microred.Materiales_didaticos = Dtr["materiales_didacticos"].ToString();
                    microred.Observacion = Dtr["observacion"].ToString();


                    if (DBNull.Value.Equals(Dtr["created_at"])) microred.Created_at = DateTime.Now; else  microred.Created_at = DateTime.Parse(Dtr["created_at"].ToString());
                   

                    if (DBNull.Value.Equals(Dtr["updated_at"])) microred.Updated_at = DateTime.Now; else microred.Updated_at = DateTime.Parse(Dtr["updated_at"].ToString());
                    

                }
                Conn.Close();

                return microred;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return microred;
            }

        }
        public int insertMicrored(ModeloNegocio.Microred ObjMicrored)
        {

            try
            {
               
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_ING_MICRORED";
                
                //Cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = ObjMicrored.Fecha.ToString("dd/MM/yyyy");
                Cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = ObjMicrored.Fecha.ToString("yyyy-MM-dd");

                Cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = ObjMicrored.User_id;
                Cmd.Parameters.Add("@docente_id", SqlDbType.Int).Value = ObjMicrored.Docente_id;
                Cmd.Parameters.Add("@school_id", SqlDbType.Int).Value = ObjMicrored.School_id;
                Cmd.Parameters.Add("@microred", SqlDbType.VarChar).Value = ObjMicrored.MicroredName;
                Cmd.Parameters.Add("@lugar_sesion", SqlDbType.VarChar).Value = ObjMicrored.Lugar_sesion;
                Cmd.Parameters.Add("@h_inicio", SqlDbType.Time).Value = ObjMicrored.H_inicio.ToString("hh:mm:ss");
                Cmd.Parameters.Add("@h_termino", SqlDbType.Time).Value = ObjMicrored.H_termino.ToString("hh:mm:ss");
                Cmd.Parameters.Add("@num_participantes", SqlDbType.Int).Value = ObjMicrored.Num_participantes;
                Cmd.Parameters.Add("@educ_financiera", SqlDbType.VarChar).Value = ObjMicrored.Educ_financiera;
                Cmd.Parameters.Add("@enfoques_edu", SqlDbType.VarChar).Value = ObjMicrored.Enfoques_edu;
                Cmd.Parameters.Add("@programacion_ped", SqlDbType.VarChar).Value = ObjMicrored.Programacion_ped;
                Cmd.Parameters.Add("@habilidad_ped", SqlDbType.VarChar).Value = ObjMicrored.Habilidad_ped;
                Cmd.Parameters.Add("@trabajo_grupal", SqlDbType.VarChar).Value = ObjMicrored.Trabajo_grupal;
                Cmd.Parameters.Add("@participativo", SqlDbType.VarChar).Value = ObjMicrored.Participativo;
                Cmd.Parameters.Add("@expositivo", SqlDbType.VarChar).Value = ObjMicrored.Expositivo;
                Cmd.Parameters.Add("@dinamicas_ludicas", SqlDbType.VarChar).Value = ObjMicrored.Dinamicas_ludicas;
                Cmd.Parameters.Add("@recursos_informaticos", SqlDbType.VarChar).Value = ObjMicrored.Recursos_informaticos;
                Cmd.Parameters.Add("@recursos_audiovisuales", SqlDbType.VarChar).Value = ObjMicrored.Recursos_audiovisuales;
                Cmd.Parameters.Add("@materiales_didacticos", SqlDbType.VarChar).Value = ObjMicrored.Materiales_didaticos;
                Cmd.Parameters.Add("@observacion", SqlDbType.VarChar).Value = ObjMicrored.Observacion;

                Cmd.Parameters.Add("@microred_id", SqlDbType.Int).Direction = ParameterDirection.Output;

                Cmd.ExecuteNonQuery();

                ObjMicrored.Id = Convert.ToInt32(Cmd.Parameters["@microred_id"].Value);

                Conn.Close();
                return ObjMicrored.Id;
            }
            catch (Exception e)
            {
                // Console.WriteLine("{0} Problem insert.", e);
                //throw new Exception("Error en Acceso a Datos: InsertarMonto.", e);
               return 0;
            }
            //throw new NotImplementedException();

             
        }


        public int countRowsMicroredes() {
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            int total_rows=0;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_COUNT_ROWS_MICROREDES";
               
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

        public bool deleteMicrored(int idMicrored)
        {
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_DELETE_MICRORED";
                Cmd.Parameters.Add("@idmicrored", SqlDbType.Int).Value = idMicrored;
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

        public DataTable getCountMicroredesForAgent()
        {
            Dt = new DataTable();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_COUNT_MICROREDES_FOR_ASESOR";
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
