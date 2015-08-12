using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Admin_SeguiNuevoClase : System.Web.UI.Page
    {
        public LogicaNegocio.Asesor ObjAsesorLN;
        public LogicaNegocio.Docente ObjDocenteLN;
        public LogicaNegocio.School ObjSchoolLN;

        public LogicaNegocio.AconpanaClase ObjAconpanaClaseLN;
        // public LogicaNegocio.Microred ObjMicroredLN;



        public ModeloNegocio.Asesor ObjAsesorMN;
        public ModeloNegocio.Docente ObjDocenteMN;
        public ModeloNegocio.School ObjSchoolMN;
        public ModeloNegocio.AconpanaClase ObjAconpanaClaseMN;
        protected void Page_Load(object sender, EventArgs e)
        {
            var dateAsString = DateTime.Now.ToString("yyyy-MM-dd");
            var timeAsString = DateTime.Now.ToString("hh:mm:ss");


            txtFecha.Text = dateAsString.ToString();

            if (!IsPostBack)
            {
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


                ObjDocenteLN = new LogicaNegocio.Docente();
                ddlDocente.DataSource = ObjDocenteLN.getAllDocente();
                ddlDocente.DataValueField = "id";
                ddlDocente.DataTextField = "FullName";
                ddlDocente.DataBind();

                ObjSchoolLN = new LogicaNegocio.School();
                ddlSchool.DataSource = ObjSchoolLN.getAllSchool();
                ddlSchool.DataValueField = "id";
                ddlSchool.DataTextField = "Nombre";
                ddlSchool.DataBind();
            }

        }

        protected void cmdGuardar_Click(object sender, EventArgs e)
        {

            ObjAconpanaClaseMN = new ModeloNegocio.AconpanaClase();
            ObjAconpanaClaseLN = new LogicaNegocio.AconpanaClase();


            ObjAconpanaClaseMN.Fecha = Convert.ToDateTime(txtFecha.Text);
            ObjAconpanaClaseMN.Asesor_id = Convert.ToInt32(ddlAsesor.Text);

            ObjAconpanaClaseMN.Docente_id = Convert.ToInt32(Request.Form[ddlDocente.UniqueID]);
            ObjAconpanaClaseMN.School_id = Convert.ToInt32(Request.Form[ddlSchool.UniqueID]);

            //Request.Form[txtParticipante.UniqueID]

            ObjAconpanaClaseMN.Id_Grado_seccion = Convert.ToString(Request.Form[lblGradoSeccion.UniqueID]);
            ObjAconpanaClaseMN.Id_Tema_Nombre_sesion = Convert.ToString(Request.Form[ddlNombSesion.UniqueID]);
            ObjAconpanaClaseMN.Id_sesion = Convert.ToInt32(Request.Form[ddlSesion.UniqueID]);


            ObjAconpanaClaseMN.Num_estudiante = Convert.ToInt32(txtEstidianteAsistentes.Text);
            ObjAconpanaClaseMN.Sesion_planificado = Convert.ToInt32(rblPlanificado.SelectedValue);
            ObjAconpanaClaseMN.Motivo = txtMotivo.Text;
            ObjAconpanaClaseMN.Desarrollo_innovacion = Convert.ToInt32(rblInnovacion.SelectedValue);
            ObjAconpanaClaseMN.Recursos_informaticos = txtRecursosInformáticos.Text;
            ObjAconpanaClaseMN.Recursos_audiovisuales = txtRecursosAudiovisuales.Text;
            ObjAconpanaClaseMN.Materiales_didacticos = txtMaterialesDidactico.Text;
            ObjAconpanaClaseMN.Dinamicas_utilizadas = txtDinamicasUsadas.Text;
            ObjAconpanaClaseMN.Otros = TxtOtros.Text;
            ObjAconpanaClaseMN.Asesor_intervino = Convert.ToInt32(rblIntervino.SelectedValue);
            ObjAconpanaClaseMN.Como_intervino = rblComoIntervino.SelectedValue;
            ObjAconpanaClaseMN.Intervencion_colaboradores = Convert.ToInt32(rblOtrosColaboradores.SelectedValue);
            ObjAconpanaClaseMN.Colaborador = txtQuien.Text;
            ObjAconpanaClaseMN.Como_intervino_colaborador = txtComoIntervino.Text;

            ObjAconpanaClaseMN.Participa_juego = Convert.ToInt32(rblParticipaJuego.SelectedValue);
            ObjAconpanaClaseMN.Etapa = txtEtapa.Text;
            ObjAconpanaClaseMN.Razon = txtRazon.Text;
            ObjAconpanaClaseMN.Incidencia = txtInsidencia.Text;


            ObjAconpanaClaseLN.insertAconpanaClase(ObjAconpanaClaseMN);


            string strRedirect;
            strRedirect = "Admin-SeguiClase.aspx?id=1";
            Response.Redirect(strRedirect, true);




            

        }
    }
}