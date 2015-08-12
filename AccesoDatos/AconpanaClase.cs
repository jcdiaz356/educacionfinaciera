using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AccesoDatos
{
    public class AconpanaClase
    {

        private SqlConnection Conn;
        private SqlCommand Cmd;
        private SqlDataReader Dtr;
        private DataTable Dt;

        public AconpanaClase()
        {
            AccesoDatos.Conexion objConexion = new AccesoDatos.Conexion();
            Conn = objConexion.abrirConexion();
        }


        public List<ModeloNegocio.AconpanaClase> getAllAconpanaClase(int registroAMostrar, int registroAEmpezar)
        {
            List<ModeloNegocio.AconpanaClase> lista = new List<ModeloNegocio.AconpanaClase>();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_LISTA_ACONPANAMIENTO_CLASE";
                Cmd.Parameters.Add("@RegistrosAMostrar", SqlDbType.Int).Value = registroAMostrar;
                Cmd.Parameters.Add("@RegistrosAEmpezar", SqlDbType.Int).Value = registroAEmpezar;
                
                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {


                    ModeloNegocio.AconpanaClase aconpanaClase = new ModeloNegocio.AconpanaClase();
                    aconpanaClase.Id = Convert.ToInt32(Dtr["id"]);
                    aconpanaClase.Fecha = Convert.ToDateTime(Dtr["fecha"]);
                    aconpanaClase.Asesor_id = Convert.ToInt32(Dtr["asesor_id"]);
                    aconpanaClase.School_id = Convert.ToInt32(Dtr["school_id"] );
                    aconpanaClase.Docente_id = Convert.ToInt32(Dtr["docente_id"]);
                    aconpanaClase.Id_Grado_seccion = Dtr["id_grado_seccion"].ToString();
                    aconpanaClase.Id_sesion = Convert.ToInt32(Dtr["id_sesion"]);
                    aconpanaClase.Id_Tema_Nombre_sesion = Dtr["id_tema_nombre_sesion"].ToString();
                    aconpanaClase.Num_estudiante =Convert.ToInt32(Dtr["num_estudiante"]);

                    aconpanaClase.Sesion_planificado = Convert.ToInt32(Dtr["sesion_planificado"]);

                    aconpanaClase.Motivo = Dtr["motivo"].ToString();
                    aconpanaClase.Desarrollo_innovacion = Convert.ToInt32(Dtr["desarrollo_innovacion"]);
                    aconpanaClase.Recursos_informaticos = Dtr["recursos_informaticos"].ToString();
                    aconpanaClase.Recursos_audiovisuales = Dtr["recursos_audiovisuales"].ToString();
                    aconpanaClase.Materiales_didacticos = Dtr["materiales_didacticos"].ToString();
                    aconpanaClase.Dinamicas_utilizadas = Dtr["dinamicas_utilizadas"].ToString();
                    aconpanaClase.Otros = Dtr["otros"].ToString();
                    aconpanaClase.Asesor_intervino = Convert.ToInt32(Dtr["asesor_intervino"]);
                    aconpanaClase.Como_intervino = Dtr["como_intervino"].ToString();
                    aconpanaClase.Intervencion_colaboradores =Convert.ToInt32(Dtr["intervencion_colaboradores"]);

                    aconpanaClase.Colaborador = Dtr["colaborador"].ToString();
                    aconpanaClase.Como_intervino_colaborador = Dtr["como_intervino_colaborador"].ToString();
                    aconpanaClase.Participa_juego = Convert.ToInt32(Dtr["participa_juego"]);
                    aconpanaClase.Etapa = Dtr["etapa"].ToString();
                    aconpanaClase.Razon = Dtr["razon"].ToString();
                    aconpanaClase.Incidencia = Dtr["incidencia"].ToString();

                    aconpanaClase.Created_at = Convert.ToDateTime(Dtr["created_at"]);
                    aconpanaClase.Updated_at = Convert.ToDateTime(Dtr["updated_at"]);
                    



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




                    lista.Add(aconpanaClase);
                }
                Conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return lista;

        }


        public ModeloNegocio.AconpanaClase getAconpanaClaseId(int aconpanaClaseid)
        {

            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            ModeloNegocio.AconpanaClase aconpanaClase = new ModeloNegocio.AconpanaClase();
            try
            {
                
                //ModeloNegocio.AconpanaClase aconpanaClase = new ModeloNegocio.AconpanaClase();

                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_GET_ACOMPANA_CLASE_ID";
                Cmd.Parameters.Add("@acompana_id", SqlDbType.Int).Value = aconpanaClaseid;

                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {

                   
                    aconpanaClase.Id = Convert.ToInt32(Dtr["id"]);
                    aconpanaClase.Fecha = Convert.ToDateTime(Dtr["fecha"]);
                    aconpanaClase.Asesor_id = Convert.ToInt32(Dtr["asesor_id"]);
                    aconpanaClase.School_id = Convert.ToInt32(Dtr["school_id"]);
                    aconpanaClase.Docente_id = Convert.ToInt32(Dtr["docente_id"]);
                    aconpanaClase.Id_Grado_seccion = Dtr["id_grado_seccion"].ToString();
                    aconpanaClase.Id_sesion = Convert.ToInt32(Dtr["id_sesion"]);
                    aconpanaClase.Id_Tema_Nombre_sesion = Dtr["id_tema_nombre_sesion"].ToString();
                    aconpanaClase.Num_estudiante = Convert.ToInt32(Dtr["num_estudiante"]);

                    aconpanaClase.Sesion_planificado = Convert.ToInt32(Dtr["sesion_planificado"]);

                    aconpanaClase.Motivo = Dtr["motivo"].ToString();
                    aconpanaClase.Desarrollo_innovacion = Convert.ToInt32(Dtr["desarrollo_innovacion"]);
                    aconpanaClase.Recursos_informaticos = Dtr["recursos_informaticos"].ToString();
                    aconpanaClase.Recursos_audiovisuales = Dtr["recursos_audiovisuales"].ToString();
                    aconpanaClase.Materiales_didacticos = Dtr["materiales_didacticos"].ToString();
                    aconpanaClase.Dinamicas_utilizadas = Dtr["dinamicas_utilizadas"].ToString();
                    aconpanaClase.Otros = Dtr["otros"].ToString();
                    aconpanaClase.Asesor_intervino = Convert.ToInt32(Dtr["asesor_intervino"]);
                    aconpanaClase.Como_intervino = Dtr["como_intervino"].ToString();
                    aconpanaClase.Intervencion_colaboradores = Convert.ToInt32(Dtr["intervencion_colaboradores"]);

                    aconpanaClase.Colaborador = Dtr["colaborador"].ToString();
                    aconpanaClase.Como_intervino_colaborador = Dtr["como_intervino_colaborador"].ToString();
                    aconpanaClase.Participa_juego = Convert.ToInt32(Dtr["participa_juego"]);
                    aconpanaClase.Etapa = Dtr["etapa"].ToString();
                    aconpanaClase.Razon = Dtr["razon"].ToString();
                    aconpanaClase.Incidencia = Dtr["incidencia"].ToString();

                    //aconpanaClase.Created_at = Convert.ToDateTime(Dtr["created_at"]);
                    //aconpanaClase.Updated_at = Convert.ToDateTime(Dtr["updated_at"]);


                    if (DBNull.Value.Equals(Dtr["created_at"])) aconpanaClase.Created_at = DateTime.Now; else aconpanaClase.Created_at = DateTime.Parse(Dtr["created_at"].ToString());


                    if (DBNull.Value.Equals(Dtr["updated_at"])) aconpanaClase.Updated_at = DateTime.Now; else aconpanaClase.Updated_at = DateTime.Parse(Dtr["updated_at"].ToString());


                }
                Conn.Close();

                return aconpanaClase;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return aconpanaClase;
            }

        }
        public int insertAconpanaClase(ModeloNegocio.AconpanaClase ObjAconpanaClase)
        {

            try
            {
               
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.CommandText = "PA_ING_ACONPANA_CLASE";

                //Cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = ObjAconpanaClase.Fecha.ToString("dd/MM/yyyy");
                Cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = ObjAconpanaClase.Fecha.ToString("yyyy-MM-dd"); ;

                Cmd.Parameters.Add("@asesor_id", SqlDbType.Int).Value = ObjAconpanaClase.Asesor_id;
                Cmd.Parameters.Add("@docente_id", SqlDbType.Int).Value = ObjAconpanaClase.Docente_id;
                Cmd.Parameters.Add("@school_id", SqlDbType.Int).Value = ObjAconpanaClase.School_id;
                Cmd.Parameters.Add("@id_grado_seccion", SqlDbType.VarChar).Value = ObjAconpanaClase.Id_Grado_seccion;
                Cmd.Parameters.Add("@id_sesion", SqlDbType.Int).Value = ObjAconpanaClase.Id_sesion;
                Cmd.Parameters.Add("@id_tema_nombre_sesion", SqlDbType.Text).Value = ObjAconpanaClase.Id_Tema_Nombre_sesion;
                Cmd.Parameters.Add("@num_estudiante", SqlDbType.Int).Value = ObjAconpanaClase.Num_estudiante;
                Cmd.Parameters.Add("@sesion_planificado", SqlDbType.Int).Value = ObjAconpanaClase.Sesion_planificado;
                Cmd.Parameters.Add("@motivo", SqlDbType.Text).Value = ObjAconpanaClase.Motivo;
                Cmd.Parameters.Add("@desarrollo_innovacion", SqlDbType.Int).Value = ObjAconpanaClase.Desarrollo_innovacion;
                Cmd.Parameters.Add("@recursos_informaticos", SqlDbType.Text).Value = ObjAconpanaClase.Recursos_informaticos;
                Cmd.Parameters.Add("@recursos_audiovisuales", SqlDbType.Text).Value = ObjAconpanaClase.Recursos_audiovisuales;
                Cmd.Parameters.Add("@materiales_didacticos", SqlDbType.Text).Value = ObjAconpanaClase.Materiales_didacticos;
                Cmd.Parameters.Add("@dinamicas_utilizadas", SqlDbType.Text).Value = ObjAconpanaClase.Dinamicas_utilizadas;
                Cmd.Parameters.Add("@otros", SqlDbType.VarChar).Value = ObjAconpanaClase.Otros;
                Cmd.Parameters.Add("@asesor_intervino", SqlDbType.Int).Value = ObjAconpanaClase.Asesor_intervino;
                Cmd.Parameters.Add("@como_intervino", SqlDbType.VarChar).Value = ObjAconpanaClase.Como_intervino;
                Cmd.Parameters.Add("@intervencion_colaboradores", SqlDbType.Int).Value = ObjAconpanaClase.Intervencion_colaboradores;
                Cmd.Parameters.Add("@colaborador", SqlDbType.Text).Value = ObjAconpanaClase.Colaborador;
                Cmd.Parameters.Add("@como_intervino_colaborador", SqlDbType.Text).Value = ObjAconpanaClase.Como_intervino_colaborador;
                Cmd.Parameters.Add("@participa_juego", SqlDbType.Int).Value = ObjAconpanaClase.Participa_juego;
               
                Cmd.Parameters.Add("@etapa", SqlDbType.Text).Value = ObjAconpanaClase.Etapa;
                Cmd.Parameters.Add("@razon", SqlDbType.Text).Value = ObjAconpanaClase.Razon;
                Cmd.Parameters.Add("@incidencia", SqlDbType.Text).Value = ObjAconpanaClase.Incidencia;


                Cmd.Parameters.Add("@aconpana_clase_id", SqlDbType.Int).Direction = ParameterDirection.Output;

                Cmd.ExecuteNonQuery();

                ObjAconpanaClase.Id = Convert.ToInt32(Cmd.Parameters["@aconpana_clase_id"].Value);

                Conn.Close();
                return ObjAconpanaClase.Id;
            }
            catch (Exception e)
            {
                // Console.WriteLine("{0} Problem insert.", e);
                //throw new Exception("Error en Acceso a Datos: InsertarMonto.", e);
               return 0;
            }
            //throw new NotImplementedException();

             
        }


        public int countRowsAconpanaClase()
        {
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            int total_rows=0;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_COUNT_ROWS_ACONPANAMIENTO_CLASE";
               
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

        public bool deleteAconpanaClase(int idAconpanaClase)
        {
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_DELETE_ACONPANA_CLASE";
                Cmd.Parameters.Add("@idAconpanaClase", SqlDbType.Int).Value = idAconpanaClase;
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
    }
}
