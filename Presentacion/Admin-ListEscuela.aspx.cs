using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Admin_ListEscuela : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LogicaNegocio.School school = new LogicaNegocio.School();
            List<ModeloNegocio.School> listSchool = new List<ModeloNegocio.School>();

            //-------------Inicio Paginador

            UscPaginador.caragaPaginador(20, Convert.ToInt32(Request.Params["pagina"]), school.countRowsSchool());
            int NumRegistrosEmpezar = UscPaginador.RegistrosAEmpezar;
            //---------------Fin Paginador

            listSchool = school.getAllSchool(20, UscPaginador.RegistrosAEmpezar);
            foreach (ModeloNegocio.School School in listSchool)
            {
                NumRegistrosEmpezar++;
                FilasListaSchool.Text += "<tr id='" + School.id + "'>";
                FilasListaSchool.Text += "<th scope=row>" + NumRegistrosEmpezar + "</th>";
                FilasListaSchool.Text += "<td>" + School.Codigo + "</td>";
                FilasListaSchool.Text += "<td>" + School.Nombre + "</td>";
                FilasListaSchool.Text += "<td>" + School.FechaCreado + "</td>";
                FilasListaSchool.Text += "<td>";
                FilasListaSchool.Text += "<a href='" + "Admin-EditEscuela.aspx?school_id=" + School.id + "&id=3'><span class='glyphicon glyphicon-pencil' aria-hidden='true' data-toggle='tooltip' data-placement='bottom' title='Editar Colegio'></span></a>";
               // FilasListaSchool.Text += "<a href='" + "#" + "'><span class='glyphicon glyphicon-user' aria-hidden='true' data-toggle='tooltip' data-placement='bottom' title='Ver datos de Colegio'></span></a>";
                FilasListaSchool.Text += "<a href='" + "#" + "' onClick=\"javascript:showMyModalSetTitle('Eliminar', 'Está seguro que desea eliminar a <b>" + School.Nombre + "</b> ','" + School.id + "')\"'><span class='glyphicon glyphicon-remove' aria-hidden='true' data-toggle='tooltip' data-placement='bottom'   title='Eliminar Escuela'></span></a>";
                FilasListaSchool.Text += "</td></tr>";
            }
        }
    }
}