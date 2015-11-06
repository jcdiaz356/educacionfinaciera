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
    public partial class Admin_ListDirector : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LogicaNegocio.Director users = new LogicaNegocio.Director();
            List<ModeloNegocio.Director> listUsuario = new List<ModeloNegocio.Director>();

            //-------------Inicio Paginador

            UscPaginador.caragaPaginador(20, Convert.ToInt32(Request.Params["pagina"]), users.countRows(8));
            int NumRegistrosEmpezar = UscPaginador.RegistrosAEmpezar;
            //---------------Fin Paginador

            listUsuario = users.getAllDirector(20, UscPaginador.RegistrosAEmpezar,8);
            foreach (ModeloNegocio.Director director in listUsuario)
            {
                NumRegistrosEmpezar++;
                FilasListaDocente.Text += "<tr id='" + director.School_id + "'>";
                FilasListaDocente.Text += "<th scope=row>" + director.School_id + "</th>";
                FilasListaDocente.Text += "<td>" + director.Codigo + "</td>";
                FilasListaDocente.Text += "<td>" + director.FullName + "</td>";
                FilasListaDocente.Text += "<td>" + director.FechaCreado + "</td>";
                FilasListaDocente.Text += "<td>";
                FilasListaDocente.Text += "<a href='" + "Admin-EditDirector.aspx?director_id=" + director.School_id + "&id=4'><span class='glyphicon glyphicon-pencil' aria-hidden='true' data-toggle='tooltip' data-placement='bottom' title='Editar Director'></span></a>";
                // FilasListaDocente.Text += "<a href='" + "#" + "'><span class='glyphicon glyphicon-user' aria-hidden='true' data-toggle='tooltip' data-placement='bottom' title='Ver datos de Asesor'></span></a>";
                FilasListaDocente.Text += "<a href='" + "#" + "' onClick=\"javascript:showMyModalSetTitle('Eliminar', 'Está seguro que desea eliminar a <b>" + director.FullName + "</b> ','" + director.School_id + "')\"'><span class='glyphicon glyphicon-remove' aria-hidden='true' data-toggle='tooltip' data-placement='bottom'   title='Eliminar Director'></span></a>";
                FilasListaDocente.Text += "<a href='" + "Admin-PasswordUser.aspx?id=4&user_id=" + director.School_id + "&password=director'><span class='glyphicon glyphicon-lock' aria-hidden='true' data-toggle='tooltip' data-placement='bottom' title='Cambiar/Editar Pasword'></span></a>";
                FilasListaDocente.Text += "</td></tr>";
            }
        }

        protected void btnReport_Click(object sender, EventArgs e)
        {
            LogicaNegocio.Director docente = new LogicaNegocio.Director();
            // List<ModeloNegocio.Asesor> listUsuario = new List<ModeloNegocio.Asesor>();

            // NOW ASSIGN DATA TO A DATAGRID.
            DataGrid dg = new DataGrid();
            dg.DataSource = docente.getReportAllDirector();
            dg.DataBind();

            // THE EXCEL FILE.
            string sFileName = "Director-" + System.DateTime.Now.Date + "-.xls";
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