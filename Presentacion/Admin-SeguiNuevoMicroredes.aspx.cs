using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicaNegocio;
using ModeloNegocio;

namespace Presentacion
{
    public partial class Admin_SeguiNuevoMicroredes : System.Web.UI.Page
    {
        
        public LogicaNegocio.Asesor ObjAsesorLN;
        public LogicaNegocio.Microred ObjMicroredLN;
       
       // public LogicaNegocio.Microred ObjMicroredLN;
         

         
        public ModeloNegocio.Asesor ObjAsesorMN;
        public ModeloNegocio.Microred ObjMicroredMN;

         
        protected void Page_Load(object sender, EventArgs e)
        {
           


           if (!IsPostBack)
           {
                var dateAsString = DateTime.Now.ToString("yyyy-MM-dd");
                var timeAsString = DateTime.Now.ToString("hh:mm:ss");


               txtFecha.Text = dateAsString.ToString();
               txtInicio.Text = timeAsString.ToString();
               txtTermino.Text = timeAsString.ToString();


               //Configurar Entradas
               //txtCodigo.Attributes["placeholder"] = "Ingrese Código";
               //txtNombreEscuela.Attributes["placeholder"] = "Ingrese Nombres y Número de la Escuela";
               //txtDireccion.Attributes["placeholder"] = "Ingrese Dirección";
               //referencia.Attributes["placeholder"] = "Ingrese Referencia";
               ObjAsesorLN = new LogicaNegocio.Asesor();


               ddlAsesor.DataSource = ObjAsesorLN.getAllAsesors();
               ddlAsesor.DataValueField = "id";
               ddlAsesor.DataTextField = "FullName";
               ddlAsesor.DataBind();
           }
        }

        protected void CmdGuardar_Click(object sender, EventArgs e)
        {
            ObjMicroredLN = new LogicaNegocio.Microred();
            ObjMicroredMN = new ModeloNegocio.Microred();


            ObjMicroredMN.Fecha = Convert.ToDateTime(txtFecha.Text);
            ObjMicroredMN.User_id =  Convert.ToInt32(ddlAsesor.Text);

           
            
            //ObjMicroredMN.School_id = Convert.ToInt32(Request.Form[ddlSchool.UniqueID]);
           // ObjMicroredMN.Docente_id = Convert.ToInt32(Request.Form[ddlDocente.UniqueID]);

            ObjMicroredMN.MicroredName = txtMircrored.Text;
            ObjMicroredMN.Lugar_sesion = txtSesion.Text;
            ObjMicroredMN.H_inicio = Convert.ToDateTime(txtInicio.Text);
            ObjMicroredMN.H_termino = Convert.ToDateTime(txtTermino.Text);
            // ObjMicroredMN.Num_participantes = Convert.ToInt32(txtParticipante.Text);
            ObjMicroredMN.Num_participantes = Convert.ToInt32(Request.Form[txtParticipante.UniqueID]);
            ObjMicroredMN.Educ_financiera = txtEducacion.Text;
            ObjMicroredMN.Enfoques_edu = txtEnfoque.Text;
            ObjMicroredMN.Programacion_ped = txtProgramacion.Text;
            ObjMicroredMN.Habilidad_ped = txtHabilidades.Text;
            ObjMicroredMN.Trabajo_grupal = txtTrabajo.Text;
            ObjMicroredMN.Participativo = txtParticipativo.Text;
            ObjMicroredMN.Expositivo = txtExpositivo.Text;
            ObjMicroredMN.Dinamicas_ludicas = txtDinamicas.Text;
            ObjMicroredMN.Recursos_informaticos = txtRecursos.Text;
            ObjMicroredMN.Recursos_audiovisuales = txtAudiovisuales.Text;
            ObjMicroredMN.Materiales_didaticos = txtMateriales.Text;
            ObjMicroredMN.Observacion = txtObservacion.Text;
            int MicroredId = ObjMicroredLN.insertMicrored(ObjMicroredMN);

            string schoolsId=Request.Form[ddlSchool.UniqueID];
            string[] resSchoolsId = schoolsId.Split(',');
            foreach (string word in resSchoolsId)
            {
                //Console.WriteLine(word);
                LogicaNegocio.MicroredSchool ObjMicroredSchoolLN;
                ObjMicroredSchoolLN = new LogicaNegocio.MicroredSchool();

                ModeloNegocio.MicroredSchool ObjMicroredSchoolMN;
                ObjMicroredSchoolMN = new ModeloNegocio.MicroredSchool();

                ObjMicroredSchoolMN.Microred_id = MicroredId;
                ObjMicroredSchoolMN.School_id = Convert.ToInt32(word);
                
                ObjMicroredSchoolLN.insertMicroredSchool(ObjMicroredSchoolMN);
            }


            string docenteId = Request.Form[ddlDocente.UniqueID];
            string[] resDocenteId = docenteId.Split(',');
            foreach (string word in resDocenteId)
            {
                //Console.WriteLine(word);
                LogicaNegocio.MicroredDocente ObjMicroredDocenteLN;
                ObjMicroredDocenteLN = new LogicaNegocio.MicroredDocente();

                ModeloNegocio.MicroredDocente ObjMicroredSchoolMN;
                ObjMicroredSchoolMN = new ModeloNegocio.MicroredDocente();

                ObjMicroredSchoolMN.Microred_id = MicroredId;
                ObjMicroredSchoolMN.Docente_id = Convert.ToInt32(word);


                ObjMicroredDocenteLN.insertMicroredDocente(ObjMicroredSchoolMN);

            }
            


            
            string strRedirect;
            strRedirect = "Admin-SeguiMicroredes.aspx?id=1";
            Response.Redirect(strRedirect, true);
           
        }

       

       
    }
}