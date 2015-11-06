using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
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

            UscPaginador.caragaPaginador(100, Convert.ToInt32(Request.Params["pagina"]), users.countRowsDocentes());
            int NumRegistrosEmpezar = UscPaginador.RegistrosAEmpezar;
            //---------------Fin Paginador

            listUsuario = users.getAllDocente(100, UscPaginador.RegistrosAEmpezar);
            foreach (ModeloNegocio.Docente Docentes in listUsuario)
            {
                NumRegistrosEmpezar++;
                FilasListaDocente.Text += "<tr id='" + Docentes.School_id + "'>";
                FilasListaDocente.Text += "<th scope=row>" + NumRegistrosEmpezar + "</th>";
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

        protected void btnReport_Click(object sender, EventArgs e)
        {
            LogicaNegocio.Docente docente = new LogicaNegocio.Docente();
            // List<ModeloNegocio.Asesor> listUsuario = new List<ModeloNegocio.Asesor>();

            // NOW ASSIGN DATA TO A DATAGRID.
            DataGrid dg = new DataGrid();
            dg.DataSource = docente.getReportAllDocente();
            dg.DataBind();

            // THE EXCEL FILE.
            string sFileName = "Docente-" + System.DateTime.Now.Date + "-.xls";
            sFileName = sFileName.Replace("/", "");

            // SEND OUTPUT TO THE CLIENT MACHINE USING "RESPONSE OBJECT".
            Encoding encoding = Encoding.UTF8;
            Response.ClearContent();
            Response.Buffer = true;
            //Response.Charset = encoding.EncodingName;
            //Response.ContentEncoding = System.Text.Encoding.UTF8;

            Response.Charset = encoding.EncodingName;
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("Windows-1252");
            Response.AddHeader("content-disposition", "attachment; filename=" + sFileName);
            Response.ContentType = "application/vnd.ms-excel";
            //Response.ContentType = "application/application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            //Response.AppendHeader("content-disposition", "attachment; filename=myfile.xlsx");
            EnableViewState = false;

            System.IO.StringWriter objSW = new System.IO.StringWriter();
            System.Web.UI.HtmlTextWriter objHTW = new System.Web.UI.HtmlTextWriter(objSW);

            dg.HeaderStyle.Font.Bold = true;     // SET EXCEL HEADERS AS BOLD.
            dg.HeaderStyle.ForeColor = Color.White;
            dg.HeaderStyle.BackColor = Color.Blue;




            dg.RenderControl(objHTW);

            // STYLE THE SHEET AND WRITE DATA TO IT.
            Response.Write("<style> TABLE { border:solid 1px #999; } " +
                "TD { border:solid 1px #000000; text-align:center } </style>");
            Response.Write(objSW.ToString());

            // ADD A ROW AT THE END OF THE SHEET SHOWING A RUNNING TOTAL OF PRICE.
            //Response.Write("<table><tr><td><b>Total: </b></td><td></td><td><b>" +
            //dTotalPrice.ToString("N2") + "</b></td></tr></table>");

            Response.End();
        }
    }
}