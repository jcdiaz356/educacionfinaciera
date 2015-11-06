using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicaNegocio;
using ModeloNegocio;
using System.Text;
using System.Drawing;

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

        protected void btnReport_Click(object sender, EventArgs e)
        {
            LogicaNegocio.Asesor asesor = new LogicaNegocio.Asesor();
            // List<ModeloNegocio.Asesor> listUsuario = new List<ModeloNegocio.Asesor>();

            // NOW ASSIGN DATA TO A DATAGRID.
            DataGrid dg = new DataGrid();
            dg.DataSource = asesor.getReportAllAsesor();
            dg.DataBind();

            // THE EXCEL FILE.
            string sFileName = "Asesor-" + System.DateTime.Now.Date + "-.xls";
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