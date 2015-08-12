using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Admin_SeguiEditVisita : System.Web.UI.Page
    {
        public ModeloNegocio.VisitaIE visitaMN;
        public LogicaNegocio.VisitaIE visitaLN;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                visitaMN = new ModeloNegocio.VisitaIE();
                visitaMN.Id = Convert.ToInt32(Request.Params["visita_id"]);
                visitaLN = new LogicaNegocio.VisitaIE();
                visitaMN = visitaLN.getVisitaId(visitaMN.Id);
                txtFecha.Text = visitaMN.Fecha.ToString("yyyy-MM-dd"); ; 
                txtObservacion.Text = visitaMN.Observacion;
                TxtPendientes.Text = visitaMN.Pendientes;
                 
            }

        }

        protected void CmdGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}