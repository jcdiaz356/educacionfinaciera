using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AccesoDatos
{
    public class VisitaIE
    {

         private SqlConnection Conn;
        private SqlCommand Cmd;
        private SqlDataReader Dtr;
        private DataTable Dt;

        public VisitaIE()
        {
            AccesoDatos.Conexion objConexion = new AccesoDatos.Conexion();
            Conn = objConexion.abrirConexion();
        }

        public List<ModeloNegocio.VisitaIE> getAllVisitas(int registroAMostrar, int registroAEmpezar)
        {
            List<ModeloNegocio.VisitaIE> lista = new List<ModeloNegocio.VisitaIE>();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_LISTA_VISITAS_IE";
                Cmd.Parameters.Add("@RegistrosAMostrar", SqlDbType.Int).Value = registroAMostrar;
                Cmd.Parameters.Add("@RegistrosAEmpezar", SqlDbType.Int).Value = registroAEmpezar;

                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {


                    ModeloNegocio.VisitaIE visitasIE = new ModeloNegocio.VisitaIE();
                    visitasIE.Id = Convert.ToInt32(Dtr["id"]);
                    visitasIE.Fecha = Convert.ToDateTime(Dtr["fecha"]);
                    visitasIE.Asesor_id = Convert.ToInt32(Dtr["asesor_id"]);
                    visitasIE.School_id = Convert.ToInt32(Dtr["school_id"]);
                    visitasIE.Docente_id = Convert.ToInt32(Dtr["docente_id"]);
                    visitasIE.Director_id = Convert.ToInt32(Dtr["director_id"]);

                    visitasIE.MotivoVisita = Dtr["motivo_visita"].ToString();
                    visitasIE.Pendientes = Dtr["pendientes"].ToString();
                    visitasIE.Nombre = Dtr["name"].ToString();


                    visitasIE.Observacion = Dtr["observacion"].ToString();
                    visitasIE.Created_at = Convert.ToDateTime(Dtr["created_at"]);
                    visitasIE.Updated_at = Convert.ToDateTime(Dtr["updated_at"]);



                    lista.Add(visitasIE);
                }
                Conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return lista;

        }

        public ModeloNegocio.VisitaIE getVisitaId(int visita_id)
        {

            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            ModeloNegocio.VisitaIE visita = new ModeloNegocio.VisitaIE();
            try
            {

                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_GET_VISITA_ID";
                Cmd.Parameters.Add("@visita_id", SqlDbType.Int).Value = visita_id;

                Dtr = Cmd.ExecuteReader();

                while (Dtr.Read())
                {

                    visita.Id = Convert.ToInt32(Dtr["id"]);
                    visita.Fecha = DateTime.Parse(Dtr["fecha"].ToString());
                    visita.Asesor_id = Convert.ToInt32(Dtr["asesor_id"].ToString());

                    visita.School_id = Convert.ToInt32(Dtr["school_id"].ToString());

                    visita.Docente_id = Convert.ToInt32(Dtr["docente_id"].ToString());
                    visita.Director_id = Convert.ToInt32(Dtr["director_id"].ToString());
                    visita.MotivoVisita = Dtr["motivo_visita"].ToString();
                    visita.Observacion = Dtr["observacion"].ToString();
                    visita.Pendientes = Dtr["pendientes"].ToString();
                    visita.Nombre = Dtr["name"].ToString();
                    visita.Created_at = DateTime.Parse(Dtr["created_at"].ToString());
                    visita.Updated_at = DateTime.Parse(Dtr["updated_at"].ToString());


                }
                Conn.Close();

                return visita;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return visita;
            }

        }

        public int insertVisita(ModeloNegocio.VisitaIE ObjVisitaIE)
        {

            try
            {

                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.CommandText = "PA_ING_VISITA_IE";

                Cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = ObjVisitaIE.Fecha.ToString("yyyy-MM-dd");
                Cmd.Parameters.Add("@asesor_id", SqlDbType.Int).Value = ObjVisitaIE.Asesor_id;
                Cmd.Parameters.Add("@docente_id", SqlDbType.Int).Value = ObjVisitaIE.Docente_id;
                Cmd.Parameters.Add("@school_id", SqlDbType.Int).Value = ObjVisitaIE.School_id;
                 Cmd.Parameters.Add("@director_id", SqlDbType.Int).Value = ObjVisitaIE.Director_id;
                
                Cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = ObjVisitaIE.Nombre;
                Cmd.Parameters.Add("@motivo_visita", SqlDbType.Text).Value = ObjVisitaIE.MotivoVisita;

                Cmd.Parameters.Add("@pendientes", SqlDbType.Text).Value = ObjVisitaIE.Pendientes;
                Cmd.Parameters.Add("@observacion", SqlDbType.Text).Value = ObjVisitaIE.Observacion;
               


                Cmd.Parameters.Add("@visita_id", SqlDbType.Int).Direction = ParameterDirection.Output;

                Cmd.ExecuteNonQuery();

                ObjVisitaIE.Id = Convert.ToInt32(Cmd.Parameters["@visita_id"].Value);

                Conn.Close();
                return ObjVisitaIE.Id;
            }
            catch (Exception e)
            {
                // Console.WriteLine("{0} Problem insert.", e);
                //throw new Exception("Error en Acceso a Datos: InsertarMonto.", e);
                return 0;
            }
            //throw new NotImplementedException();


        }


        public int countRowsVisitas()
        {
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            int total_rows = 0;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_COUNT_ROWS_VISITAS_IE";

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

        public bool deleteVisitaIE(int idVisita)
        {
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.Parameters.Clear();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_DELETE_VISITAS_IE";
                Cmd.Parameters.Add("@idVisita", SqlDbType.Int).Value = idVisita;
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

        public DataTable getCountVisitsForAgent()
        {
            Dt = new DataTable();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_COUNT_VISIT_SCHOOL_FOR_ASESOR";
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

        public DataTable getCountVisitsForSchool()
        {
            Dt = new DataTable();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "PA_COUNT_VISIT_FOR_SCHOOL";
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

        public DataTable getReportAllVisitasIE()
        {
            Dt = new DataTable();
            Cmd = new SqlCommand();
            Cmd.Connection = Conn;
            try
            {
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "[otaku_bcp].PA_REPORT_ALL_VISITAS_IE";
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
