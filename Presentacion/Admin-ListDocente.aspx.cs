using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Admin_ListDocente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LogicaNegocio.Docente users = new LogicaNegocio.Docente();
            List<ModeloNegocio.Docente> listUsuario = new List<ModeloNegocio.Docente>();

            //-------------Inicio Paginador

            UscPaginador.caragaPaginador(20, Convert.ToInt32(Request.Params["pagina"]), users.countRowsDocentes());
            //---------------Fin Paginador

            listUsuario = users.getAllDocente(20, UscPaginador.RegistrosAEmpezar);
            foreach (ModeloNegocio.Docente Docentes in listUsuario)
            {
                FilasListaDocente.Text += "<tr id='" + Docentes.School_id + "'>";
                FilasListaDocente.Text += "<th scope=row>" + Docentes.School_id + "</th>";
                FilasListaDocente.Text += "<td>" + Docentes.Codigo + "</td>";
                FilasListaDocente.Text += "<td>" + Docentes.FullName + "</td>";
                FilasListaDocente.Text += "<td>" + Docentes.FechaCreado + "</td>";
                FilasListaDocente.Text += "<td>";
                FilasListaDocente.Text += "<a href='" + "Admin-EditDocente.aspx?docente_id=" + Docentes.School_id + "&id=2'><span class='glyphicon glyphicon-pencil' aria-hidden='true' data-toggle='tooltip' data-placement='bottom' title='Editar Docente'></span></a>";
               // FilasListaDocente.Text += "<a href='" + "#" + "'><span class='glyphicon glyphicon-user' aria-hidden='true' data-toggle='tooltip' data-placement='bottom' title='Ver datos de Asesor'></span></a>";
                FilasListaDocente.Text += "<a href='" + "#" + "' onClick=\"javascript:showMyModalSetTitle('Eliminar', 'Está seguro que desea eliminar a <b>" + Docentes.FullName + "</b> ','" + Docentes.School_id + "')\"'><span class='glyphicon glyphicon-remove' aria-hidden='true' data-toggle='tooltip' data-placement='bottom'   title='Eliminar Docente'></span></a>";
                FilasListaDocente.Text += "<a href='" + "Admin-PasswordUser.aspx?id=2&user_id=" + Docentes.School_id + "&password=docente'><span class='glyphicon glyphicon-lock' aria-hidden='true' data-toggle='tooltip' data-placement='bottom' title='Cambiar/Editar Pasword'></span></a>";
                FilasListaDocente.Text += "</td></tr>";
            }
        }
    }
}