using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Admin_SeguiViewVisita : System.Web.UI.Page
    {
        public ModeloNegocio.VisitaIE visitaMN;
        public LogicaNegocio.VisitaIE visitaLN;

        public ModeloNegocio.Asesor asesorMN;
        public LogicaNegocio.Asesor asesorLN;

        public ModeloNegocio.Director directorMN;
        public LogicaNegocio.Director directorLN;

        public ModeloNegocio.Docente docenteMN;
        public LogicaNegocio.Docente docenteLN;

        public ModeloNegocio.School schoolMN;
        public LogicaNegocio.School schoolLN;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 
                
                visitaMN = new ModeloNegocio.VisitaIE();
                visitaLN = new LogicaNegocio.VisitaIE();
                visitaMN.Id = Convert.ToInt32(Request.Params["visita_id"]);
                visitaMN = visitaLN.getVisitaId(visitaMN.Id);



                txtFecha.Text = visitaMN.Fecha.ToString("yyyy-MM-dd");

                asesorLN = new LogicaNegocio.Asesor();
                asesorMN = new ModeloNegocio.Asesor();
                asesorMN = asesorLN.getAsesorId(visitaMN.Asesor_id);
                txtAsesor.Text = asesorMN.FullName;


                directorLN = new LogicaNegocio.Director();
                directorMN = new ModeloNegocio.Director();
                directorMN=directorLN.getDirectorId(visitaMN.Director_id);
                txtDirector.Text = directorMN.FullName;


                docenteLN = new LogicaNegocio.Docente();
                docenteMN = new ModeloNegocio.Docente();
                docenteMN = docenteLN.getDocenteId(visitaMN.Docente_id);
                txtDocente.Text = docenteMN.FullName;


                schoolLN = new LogicaNegocio.School();
                schoolMN = new ModeloNegocio.School();
                 
                //schoolMN = schoolLN.getDocenteId(visitaMN.Docente_id);
                schoolMN = schoolLN.getSchool(visitaMN.School_id);

                txtSchool.Text = schoolMN.Nombre.ToString();
                txtMotivoVisita.Text = visitaMN.MotivoVisita;
                
                txtObservacion.Text = visitaMN.Observacion;
                TxtPendientes.Text = visitaMN.Pendientes;

            }
        }

        protected void CmdVolver_Click(object sender, EventArgs e)
        {
            string strRedirect;
            strRedirect = "Admin-SeguiVisitas.aspx?id=3";
            Response.Redirect(strRedirect, true);
        }
    }
}