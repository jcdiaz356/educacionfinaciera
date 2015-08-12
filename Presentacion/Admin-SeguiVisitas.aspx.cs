using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Admin_SeguiVisitas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LogicaNegocio.VisitaIE visitaIE = new LogicaNegocio.VisitaIE();
            List<ModeloNegocio.VisitaIE> listVisitasIE = new List<ModeloNegocio.VisitaIE>();


            //-------------Inicio Paginador

            UscPaginador.caragaPaginador(100, Convert.ToInt32(Request.Params["pagina"]), visitaIE.countRowsVisitas());
            //---------------Fin Paginador
            int NumRegistrosEmpezar = UscPaginador.RegistrosAEmpezar;
            listVisitasIE = visitaIE.getAllVisitas(100, UscPaginador.RegistrosAEmpezar);
            foreach (ModeloNegocio.VisitaIE VisitasIE in listVisitasIE)
            {
                ModeloNegocio.Asesor asesorMN;
                LogicaNegocio.Asesor asesorLN;
                asesorLN = new LogicaNegocio.Asesor();
                asesorMN = new ModeloNegocio.Asesor();
                asesorMN = asesorLN.getAsesorId( VisitasIE.Asesor_id);

                NumRegistrosEmpezar++;
                 
               
                FilasLista.Text += "<tr id='" + VisitasIE.Id + "'>";
                FilasLista.Text += "<th scope=row>" + NumRegistrosEmpezar + "</th>";
                FilasLista.Text += "<td>" + asesorMN.FullName + "</td>";
                FilasLista.Text += "<td>" + VisitasIE.Fecha.ToString("dd-MM-yyyy")  + "</td>";
                FilasLista.Text += "<td>";
                //FilasLista.Text += "<a href='" + "Admin-SeguiEditVisita.aspx?visita_id=" + VisitasIE.Id + "'><span class='glyphicon glyphicon-pencil' aria-hidden='true' data-toggle='tooltip' data-placement='bottom' title='Editar seguimiento de Visitas a IE'></span></a>";
                FilasLista.Text += "<a href='" + "Admin-SeguiViewVisita.aspx?id=3&visita_id=" + VisitasIE.Id + "'><span class='glyphicon glyphicon glyphicon-zoom-in' aria-hidden='true' data-toggle='tooltip' data-placement='bottom' title='Ver visita a IE'></span></a>";
                FilasLista.Text += "<a href='" + "#" + "' onClick=\"javascript:showMyModalSetTitle('Eliminar', 'Está seguro que desea eliminar  <b>" + VisitasIE.Nombre + "</b> ','" + VisitasIE.Id + "')\"'><span class='glyphicon glyphicon-remove' aria-hidden='true' data-toggle='tooltip' data-placement='bottom'   title='Eliminar  seguimiento de Visita IE'></span></a>";

                FilasLista.Text += "</td></tr>";
            }
        }
    }
}