using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Admin_ListSubDirector : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LogicaNegocio.Director users = new LogicaNegocio.Director();
            List<ModeloNegocio.Director> listUsuario = new List<ModeloNegocio.Director>();

            //-------------Inicio Paginador

            UscPaginador.caragaPaginador(20, Convert.ToInt32(Request.Params["pagina"]), users.countRows(9));
            //---------------Fin Paginador

            listUsuario = users.getAllDirector(20, UscPaginador.RegistrosAEmpezar, 9);
            foreach (ModeloNegocio.Director director in listUsuario)
            {
                FilasListaDocente.Text += "<tr id='" + director.School_id + "'>";
                FilasListaDocente.Text += "<th scope=row>" + director.School_id + "</th>";
                FilasListaDocente.Text += "<td>" + director.Codigo + "</td>";
                FilasListaDocente.Text += "<td>" + director.FullName + "</td>";
                FilasListaDocente.Text += "<td>" + director.FechaCreado + "</td>";
                FilasListaDocente.Text += "<td>";
                FilasListaDocente.Text += "<a href='" + "Admin-EditSubDirector.aspx?subdirector_id=" + director.School_id + "&id=5'><span class='glyphicon glyphicon-pencil' aria-hidden='true' data-toggle='tooltip' data-placement='bottom' title='Editar Director'></span></a>";
                // FilasListaDocente.Text += "<a href='" + "#" + "'><span class='glyphicon glyphicon-user' aria-hidden='true' data-toggle='tooltip' data-placement='bottom' title='Ver datos de Asesor'></span></a>";
                FilasListaDocente.Text += "<a href='" + "#" + "' onClick=\"javascript:showMyModalSetTitle('Eliminar', 'Está seguro que desea eliminar a <b>" + director.FullName + "</b> ','" + director.School_id + "')\"'><span class='glyphicon glyphicon-remove' aria-hidden='true' data-toggle='tooltip' data-placement='bottom'   title='Eliminar Director'></span></a>";
                FilasListaDocente.Text += "<a href='" + "Admin-PasswordUser.aspx?id=5&user_id=" + director.School_id + "&password=subdirector'><span class='glyphicon glyphicon-lock' aria-hidden='true' data-toggle='tooltip' data-placement='bottom' title='Cambiar/Editar Pasword'></span></a>";
                FilasListaDocente.Text += "</td></tr>";
            }
        }
    }
}