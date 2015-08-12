using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Admin_SeguiNuevoVisita : System.Web.UI.Page
    {
        public LogicaNegocio.Asesor ObjAsesorLN;
        public LogicaNegocio.VisitaIE ObjVisitaLN;
        // public LogicaNegocio.Microred ObjMicroredLN;



        public ModeloNegocio.Asesor ObjAsesorMN;
        public ModeloNegocio.VisitaIE ObjVisitaMN;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            


            if (!IsPostBack)
            {
                var dateAsString = DateTime.Now.ToString("yyyy-MM-dd");
                var timeAsString = DateTime.Now.ToString("hh:mm:ss");
                 txtFecha.Text = dateAsString.ToString();
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


            ObjVisitaLN = new LogicaNegocio.VisitaIE();
            ObjVisitaMN = new ModeloNegocio.VisitaIE();

 
  //otaku_bcp.visitas_ie.observacion,
  //otaku_bcp.visitas_ie.pendientes,
 
 


            ObjVisitaMN.Fecha = Convert.ToDateTime(txtFecha.Text);

            ObjVisitaMN.Nombre = "";
            ObjVisitaMN.Asesor_id = Convert.ToInt32(ddlAsesor.Text);
            ObjVisitaMN.School_id = Convert.ToInt32(Request.Form[ddlSchool.UniqueID]);
            

           

            if (chkDocente.Checked == true){
                ObjVisitaMN.Docente_id = Convert.ToInt32(Request.Form[ddlDocente.UniqueID]);
            }
            else
            {
                ObjVisitaMN.Docente_id = 0;
            }


            if (chkDirector.Checked == true)
            {
                ObjVisitaMN.Director_id = Convert.ToInt32(Request.Form[ddlDirector.UniqueID]);
            }
            else
            {
                ObjVisitaMN.Director_id = 0;
            }

            string strMotivoVisita="";

            if (chkA.Checked==true) {
                strMotivoVisita += "0:" + chkA.Text + "|" ;
            }

            if (chkB.Checked == true)
            {
                strMotivoVisita += "1:" + chkB.Text + "|";
            }

            if (chkC.Checked == true)
            {
                strMotivoVisita += "2:" + chkC.Text + "|";
            }

            if (chkD.Checked == true)
            {
                strMotivoVisita += "3:" + chkD.Text + "|";
            }

            ObjVisitaMN.MotivoVisita = strMotivoVisita;


            ObjVisitaMN.Pendientes = TxtPendientes.Text;
 
            ObjVisitaMN.Observacion = txtObservacion.Text;





            ObjVisitaLN.insertVisitas(ObjVisitaMN);
            string strRedirect;
            strRedirect = "Admin-SeguiVisitas.aspx?id=3";
            Response.Redirect(strRedirect, true);
        }
    }
}