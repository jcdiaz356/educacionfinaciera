﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
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
                FilasLista.Text += "<td>" + VisitasIE.Id + "</td>";
                FilasLista.Text += "<td>" + asesorMN.FullName + "</td>";
                FilasLista.Text += "<td>" + VisitasIE.Fecha.ToString("dd-MM-yyyy")  + "</td>";
                FilasLista.Text += "<td>";
                //FilasLista.Text += "<a href='" + "Admin-SeguiEditVisita.aspx?visita_id=" + VisitasIE.Id + "'><span class='glyphicon glyphicon-pencil' aria-hidden='true' data-toggle='tooltip' data-placement='bottom' title='Editar seguimiento de Visitas a IE'></span></a>";
                FilasLista.Text += "<a href='" + "Admin-SeguiViewVisita.aspx?id=3&visita_id=" + VisitasIE.Id + "'><span class='glyphicon glyphicon glyphicon-zoom-in' aria-hidden='true' data-toggle='tooltip' data-placement='bottom' title='Ver visita a IE'></span></a>";
                FilasLista.Text += "<a href='" + "#" + "' onClick=\"javascript:showMyModalSetTitle('Eliminar', 'Está seguro que desea eliminar  <b>" + VisitasIE.Nombre + "</b> ','" + VisitasIE.Id + "')\"'><span class='glyphicon glyphicon-remove' aria-hidden='true' data-toggle='tooltip' data-placement='bottom'   title='Eliminar  seguimiento de Visita IE'></span></a>";

                FilasLista.Text += "</td></tr>";
            }
        }

        protected void btnReport_Click(object sender, EventArgs e)
        {
            LogicaNegocio.VisitaIE aconpanaClase = new LogicaNegocio.VisitaIE();
            // List<ModeloNegocio.Asesor> listUsuario = new List<ModeloNegocio.Asesor>();

            // NOW ASSIGN DATA TO A DATAGRID.
            DataGrid dg = new DataGrid();
            dg.DataSource = aconpanaClase.getReportAllVisitasIE();
            dg.DataBind();

            // THE EXCEL FILE.
            string sFileName = "VisitasIE-" + System.DateTime.Now.Date + "-.xls";
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