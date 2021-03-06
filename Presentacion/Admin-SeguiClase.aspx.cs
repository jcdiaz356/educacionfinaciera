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
    public partial class Admin_SeguiClase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
            LogicaNegocio.AconpanaClase aconpanaClase = new LogicaNegocio.AconpanaClase();
            List<ModeloNegocio.AconpanaClase> listAconpanaClase = new List<ModeloNegocio.AconpanaClase>();
            int NumRegistrosEmpezar;




            if (Request.Params["docente_id"]!= null)
            {
                int docente_id = Convert.ToInt32(Request.Params["docente_id"]);
                NumRegistrosEmpezar = 0;
                listAconpanaClase = aconpanaClase.getAllAconpanaClasePorDocente(docente_id, 200, NumRegistrosEmpezar);

            }
            else
            {
                //-------------Inicio Paginador

                UscPaginador.caragaPaginador(100, Convert.ToInt32(Request.Params["pagina"]), aconpanaClase.countRowsAconpanaClase());
                //---------------Fin Paginador

                NumRegistrosEmpezar = UscPaginador.RegistrosAEmpezar;
                listAconpanaClase = aconpanaClase.getAllAconpanaClase(100, UscPaginador.RegistrosAEmpezar);
            }
            

            foreach (ModeloNegocio.AconpanaClase Aconpana in listAconpanaClase)
            {
                ModeloNegocio.Asesor asesorMN = new ModeloNegocio.Asesor();
                LogicaNegocio.Asesor asesorLN = new LogicaNegocio.Asesor();

                ModeloNegocio.Docente docenteMN = new ModeloNegocio.Docente();
                LogicaNegocio.Docente docenteLN = new LogicaNegocio.Docente();

                asesorMN = asesorLN.getAsesorId(Aconpana.Asesor_id);
                docenteMN = docenteLN.getDocenteId(Aconpana.Docente_id);

                NumRegistrosEmpezar++;

                FilasLista.Text += "<tr id='" + Aconpana.Id + "'>";
                FilasLista.Text += "<th scope=row>" + NumRegistrosEmpezar + "</th>";
                FilasLista.Text += "<td>" + Aconpana.Id + "</td>";
                FilasLista.Text += "<td>" + asesorMN.FullName + "</td>";
                FilasLista.Text += "<td>" + docenteMN.FullName + "</td>";
                FilasLista.Text += "<td>" + Aconpana.Fecha.ToString("dd-MM-yyyy") + "</td>";
                FilasLista.Text += "<td>";
               // FilasLista.Text += "<a href='" + "Admin-Segui.aspx?asesor_id=" + Aconpana.Id + "'><span class='glyphicon glyphicon-pencil' aria-hidden='true' data-toggle='tooltip' data-placement='bottom' title='Editar seguimiento a clase'></span></a>";
                FilasLista.Text += "<a href='" + "Admin-SeguiViewClase.aspx?aconpana_id=" + Aconpana.Id + "&id=2'><span class='glyphicon glyphicon-zoom-in' aria-hidden='true' data-toggle='tooltip' data-placement='bottom' title='Ver  seguimiento a clase'></span></a>";
                FilasLista.Text += "<a href='" + "#" + "' onClick=\"javascript:showMyModalSetTitle('Eliminar', 'Está seguro que desea eliminar  <b>" + Aconpana.Id_Tema_Nombre_sesion + "</b> ','" + Aconpana.Id + "')\"'><span class='glyphicon glyphicon-remove' aria-hidden='true' data-toggle='tooltip' data-placement='bottom'   title='Eliminar  seguimiento a clase'></span></a>";

                FilasLista.Text += "</td></tr>";
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            LogicaNegocio.Docente LNDocente = new LogicaNegocio.Docente();
            ModeloNegocio.Docente MNDocente = new ModeloNegocio.Docente();

            MNDocente=LNDocente.getDocenteCode(txtCodDocente.Text);
            string strRedirect;
            strRedirect = "Admin-SeguiClase.aspx?docente_id=" + MNDocente.id;
            Response.Redirect(strRedirect, true);
        }

        protected void btnReport_Click(object sender, EventArgs e)
        {
            LogicaNegocio.AconpanaClase aconpanaClase = new LogicaNegocio.AconpanaClase();
           // List<ModeloNegocio.Asesor> listUsuario = new List<ModeloNegocio.Asesor>();
          
            // NOW ASSIGN DATA TO A DATAGRID.
            DataGrid dg = new DataGrid();
            dg.DataSource = aconpanaClase.getReportAllAconpanaClase();
            dg.DataBind();

            // THE EXCEL FILE.
            string sFileName = "Segui-Clase-" + System.DateTime.Now.Date + "-.xls";
            sFileName = sFileName.Replace("/", "");

            // SEND OUTPUT TO THE CLIENT MACHINE USING "RESPONSE OBJECT".
            Encoding encoding = Encoding.UTF8;
            Response.ClearContent();
            Response.Buffer = true;
            //Response.Charset = encoding.EncodingName;
            //Response.ContentEncoding = System.Text.Encoding.UTF8;
             
            Response.Charset = encoding.EncodingName ;
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