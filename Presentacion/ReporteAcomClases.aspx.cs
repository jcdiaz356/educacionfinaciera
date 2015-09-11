using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Presentacion
{
    public partial class ReporteAcomClases : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable NumVisitasForAsesor;
            int NumAcomp;
            double porcNumAcomp, NumAcompParcial;
            LogicaNegocio.AconpanaClase acompClases = new LogicaNegocio.AconpanaClase();
            NumAcomp = acompClases.countRowsAconpanaClase();
            lblNumAcomp.Text = Convert.ToString(NumAcomp);
            NumVisitasForAsesor = acompClases.getCountAcompForAgent();
            foreach (DataRow fila in NumVisitasForAsesor.Rows)
            {
                ModeloNegocio.Asesor asesorMN = new ModeloNegocio.Asesor();
                LogicaNegocio.Asesor asesorLN = new LogicaNegocio.Asesor();

                asesorMN = asesorLN.getAsesorId(Convert.ToInt32(fila["asesor_id"]));
                NumAcompParcial = Convert.ToInt32(fila["Cantidad"]);
                porcNumAcomp = (NumAcompParcial / NumAcomp) * 100;
                lblNumAcompaForAsesor.Text += "<tr>";
                lblNumAcompaForAsesor.Text += "<td>" + asesorMN.FullName + "</td>";
                lblNumAcompaForAsesor.Text += "<td>" + fila["Cantidad"].ToString() + "</td>";
                lblNumAcompaForAsesor.Text += "<td>" + String.Format("{0:0.00}", porcNumAcomp) + "</td>";
                lblNumAcompaForAsesor.Text += "</tr>";
            }
        }
    }
}