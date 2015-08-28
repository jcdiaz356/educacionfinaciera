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
    public partial class Admin_ListAsesor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LogicaNegocio.Asesor users = new LogicaNegocio.Asesor();
            List<ModeloNegocio.Asesor> listUsuario = new List<ModeloNegocio.Asesor>();
            //-------------Inicio Paginador

            UscPaginador.caragaPaginador(20, Convert.ToInt32(Request.Params["pagina"]), users.countRowsAsesores());
            int NumRegistrosEmpezar = UscPaginador.RegistrosAEmpezar;
            //---------------Fin Paginador
            listUsuario = users.getAllAsesors(20, UscPaginador.RegistrosAEmpezar);
            foreach(ModeloNegocio.Asesor Asesores in listUsuario)
            {
                NumRegistrosEmpezar++;
                FilasListaAsesores.Text += "<tr id='" + Asesores.id + "'>";
                FilasListaAsesores.Text += "<th scope=row>" + NumRegistrosEmpezar + "</th>";
                FilasListaAsesores.Text += "<td>" + Asesores.Codigo + "</td>";
                FilasListaAsesores.Text += "<td>" + Asesores.FullName + "</td>";
                FilasListaAsesores.Text += "<td>" + Asesores.FechaCreado + "</td>";
                FilasListaAsesores.Text += "<td>";
                FilasListaAsesores.Text += "<a href='" + "Admin-EditAsesor.aspx?asesor_id=" + Asesores.id + "&id=1'><span class='glyphicon glyphicon-pencil' aria-hidden='true' data-toggle='tooltip' data-placement='bottom' title='Editar Asesor'></span></a>";
               // FilasListaAsesores.Text += "<a href='" + "#" + "'><span class='glyphicon glyphicon-user' aria-hidden='true' data-toggle='tooltip' data-placement='bottom' title='Ver datos de Asesor'></span></a>";
                FilasListaAsesores.Text += "<a href='" + "#" + "' onClick=\"javascript:showMyModalSetTitle('Eliminar', 'Está seguro que desea eliminar a <b>" + Asesores.FullName + "</b> ','" + Asesores.id + "')\"'><span class='glyphicon glyphicon-remove' aria-hidden='true' data-toggle='tooltip' data-placement='bottom'   title='Eliminar Asesor'></span></a>";
                FilasListaAsesores.Text += "<a href='" + "Admin-PasswordUser.aspx?id=1&user_id=" + Asesores.id + "&password=asesor'><span class='glyphicon glyphicon-lock' aria-hidden='true' data-toggle='tooltip' data-placement='bottom' title='Cambiar/Editar Pasword'></span></a>";
                FilasListaAsesores.Text += "</td></tr>";
            }
            
        }
    }
}