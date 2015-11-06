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

        protected void btnReport_Click(object sender, EventArgs e)
        {
            LogicaNegocio.School school = new LogicaNegocio.School();
            // List<ModeloNegocio.Asesor> listUsuario = new List<ModeloNegocio.Asesor>();

            // NOW ASSIGN DATA TO A DATAGRID.
            DataGrid dg = new DataGrid();
            dg.DataSource = school.getReportAllSchool();
            dg.DataBind();

            // THE EXCEL FILE.
            string sFileName = "Escuelas-" + System.DateTime.Now.Date + "-.xls";
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