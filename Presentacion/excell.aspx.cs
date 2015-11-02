using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class excell : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LogicaNegocio.Asesor users = new LogicaNegocio.Asesor();
            List<ModeloNegocio.Asesor> listUsuario = new List<ModeloNegocio.Asesor>();
            //-------------Inicio Paginador

            //UscPaginador.caragaPaginador(20, Convert.ToInt32(Request.Params["pagina"]), users.countRowsAsesores());
            //---------------Fin Paginador
            listUsuario = users.getAllAsesors(20, 0);
            foreach (ModeloNegocio.Asesor Asesores in listUsuario)
            {
                FilasListaAsesores.Text += "<tr id='" + Asesores.id + "'>";
                FilasListaAsesores.Text += "<th scope=row>" + Asesores.id + "</th>";
                FilasListaAsesores.Text += "<td>" + Asesores.Codigo + "</td>";
                FilasListaAsesores.Text += "<td>" + Asesores.FullName + "</td>";
                FilasListaAsesores.Text += "<td>" + Asesores.FechaCreado + "</td>";
                FilasListaAsesores.Text += "<td>";
                //FilasListaAsesores.Text += "<a href='" + "Admin-EditAsesor.aspx?asesor_id=" + Asesores.id + "&id=1'><span class='glyphicon glyphicon-pencil' aria-hidden='true' data-toggle='tooltip' data-placement='bottom' title='Editar Asesor'></span></a>";
                // FilasListaAsesores.Text += "<a href='" + "#" + "'><span class='glyphicon glyphicon-user' aria-hidden='true' data-toggle='tooltip' data-placement='bottom' title='Ver datos de Asesor'></span></a>";
                //FilasListaAsesores.Text += "<a href='" + "#" + "' onClick=\"javascript:showMyModalSetTitle('Eliminar', 'Está seguro que desea eliminar a <b>" + Asesores.FullName + "</b> ','" + Asesores.id + "')\"'><span class='glyphicon glyphicon-remove' aria-hidden='true' data-toggle='tooltip' data-placement='bottom'   title='Eliminar Asesor'></span></a>";
                //FilasListaAsesores.Text += "<a href='" + "Admin-PasswordUser.aspx?id=1&user_id=" + Asesores.id + "&password=asesor'><span class='glyphicon glyphicon-lock' aria-hidden='true' data-toggle='tooltip' data-placement='bottom' title='Cambiar/Editar Pasword'></span></a>";
                FilasListaAsesores.Text += "</td></tr>";
            }
        }

        protected void cmdExportar_Click(object sender, EventArgs e)
        {
            LogicaNegocio.Asesor users = new LogicaNegocio.Asesor();
            List<ModeloNegocio.Asesor> listUsuario = new List<ModeloNegocio.Asesor>();
            //-------------Inicio Paginador





            listUsuario = users.getAllAsesors(20, 0);

            int dTotalPrice = 0;
            for (int i = 0; i <= listUsuario.Count - 1; i++)
            {
                //dTotalPrice += listUsuario.Count;  //.<Decimal>(2);
            }
            dTotalPrice = listUsuario.Count;
            // NOW ASSIGN DATA TO A DATAGRID.
            DataGrid dg = new DataGrid();
            dg.DataSource = listUsuario;
            dg.DataBind();

            // THE EXCEL FILE.
            string sFileName = "BooksList-" + System.DateTime.Now.Date + ".xls";
            sFileName = sFileName.Replace("/", "");

            // SEND OUTPUT TO THE CLIENT MACHINE USING "RESPONSE OBJECT".
            Response.ClearContent();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment; filename=" + sFileName);
            Response.ContentType = "application/vnd.ms-excel";
            EnableViewState = false;

            System.IO.StringWriter objSW = new System.IO.StringWriter();
            System.Web.UI.HtmlTextWriter objHTW = new System.Web.UI.HtmlTextWriter(objSW);

            dg.HeaderStyle.Font.Bold = true;     // SET EXCEL HEADERS AS BOLD.
            dg.RenderControl(objHTW);

            // STYLE THE SHEET AND WRITE DATA TO IT.
            Response.Write("<style> TABLE { border:dotted 1px #999; } " +
                "TD { border:dotted 1px #D5D5D5; text-align:center } </style>");
            Response.Write(objSW.ToString());

            // ADD A ROW AT THE END OF THE SHEET SHOWING A RUNNING TOTAL OF PRICE.
            Response.Write("<table><tr><td><b>Total: </b></td><td></td><td><b>" +
            dTotalPrice.ToString("N2") + "</b></td></tr></table>");

            Response.End();
        }

        protected void cmdExportar4_Click(object sender, EventArgs e)
        {
            LogicaNegocio.Asesor users = new LogicaNegocio.Asesor();
            List<ModeloNegocio.Asesor> listUsuario = new List<ModeloNegocio.Asesor>();
            //-------------Inicio Paginador


            //Creando instancia a un documento de excell
            IWorkbook workbook = new HSSFWorkbook();
            //Creando una hoja en el documento de excell
            ISheet hoja1 = workbook.CreateSheet("Lista Asesores");


            //Creando Formato para las celdas
            ICellStyle style = workbook.CreateCellStyle();
            style.Alignment = HorizontalAlignment.Center;//Left and right center
            style.VerticalAlignment = VerticalAlignment.Center;//Up and down the middle
            style.WrapText = true;//Word wrap
            style.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;//The next frame as a thin line frame
            style.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;//Left border
            style.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;//Right border
            style.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;//The upper frame
            style.FillForegroundColor = HSSFColor.Black.Index; //HSSFColor.YELLOW.index;//A yellow background color
            style.FillPattern = FillPattern.SolidForeground; // FillPatternType.SOLID_FOREGROUND;//Fill pattern for panchromatic
            IFont font = workbook.CreateFont();
            //font.FontName = "Pmingliu";
            font.Color = HSSFColor.White.Index;
            font.FontHeightInPoints = 12;
            font.Boldweight = short.MaxValue;//Bold
            style.SetFont(font);

            //---------------------Creando ancho de las columnas
            //hoja1.SetColumnWidth(0, (int)((20 + 0.72) * 256));//A
            //hoja1.SetColumnWidth(1, (int)((25 + 0.72) * 256));//B
            //hoja1.SetColumnWidth(2, (int)((15 + 0.72) * 256));//C

            hoja1.SetColumnWidth(0, (int)((5 + 0.72) * 256));//A
            hoja1.SetColumnWidth(1, (int)((15 + 0.72) * 256));//B
            hoja1.SetColumnWidth(2, (int)((75 + 0.72) * 256));//C
            hoja1.SetColumnWidth(3, (int)((35 + 0.72) * 256));//C

            //Creando una nueva fila en la hoja
            IRow filaEncabezado = hoja1.CreateRow(0);
            //Creando celdas en la fila
            ICell celdaEncabezado1 = filaEncabezado.CreateCell(0);
            ICell celdaEncabezado2 = filaEncabezado.CreateCell(1);
            ICell celdaEncabezado3 = filaEncabezado.CreateCell(2);
            ICell celdaEncabezado4 = filaEncabezado.CreateCell(3);

            //Estableciendo valores en cada celda
            celdaEncabezado1.SetCellValue("Nº");
            celdaEncabezado2.SetCellValue("CODIGO");
            celdaEncabezado3.SetCellValue("NOMBRE");
            celdaEncabezado4.SetCellValue("EMAIL");

            celdaEncabezado1.CellStyle = style;
            celdaEncabezado2.CellStyle = style;
            celdaEncabezado3.CellStyle = style;
            celdaEncabezado4.CellStyle = style;



            listUsuario = users.getAllAsesors(20, 0);

            int i = 0;
            foreach (ModeloNegocio.Asesor Asesores in listUsuario)
            {
                i++;
                IRow filaRegistro = hoja1.CreateRow(i);
                filaRegistro.CreateCell(0).SetCellValue(i);
                filaRegistro.CreateCell(1).SetCellValue(Asesores.Codigo);
                filaRegistro.CreateCell(2).SetCellValue(Asesores.FullName);
                filaRegistro.CreateCell(3).SetCellValue(Asesores.Email);
            }

            //IRow rowTotale = hoja1.CreateRow(i+2);
            //ICell cell = rowTotale.CreateCell(0);
            //cell.SetCellType(CellType.Formula);
            //cell.CellFormula =   // "SUM(A{1}:A{"+ i +"})";   


            MemoryStream file = new MemoryStream();
            workbook.Write(file);

            string saveAsFileName = string.Format("MembershipExport-{0:d}.xls", DateTime.Now).Replace("/", "-");
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("Content-Disposition", string.Format("attachment;filename={0}", saveAsFileName));
            Response.Clear();
            Response.BinaryWrite(file.GetBuffer());
            Response.End();

        }
    }
}