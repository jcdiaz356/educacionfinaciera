using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Presentacion
{
    public partial class ReportePorAsesor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable  NumSchoolForAsesor;
            double NumColegios, NumColAsesor, PorcColegios;
            LogicaNegocio.School colegios = new LogicaNegocio.School();
            NumColegios = colegios.countRowsSchool();
            lblNumColegios.Text = Convert.ToString(NumColegios);
            NumSchoolForAsesor = colegios.countSchoolForAsesor();
            foreach (DataRow fila1 in NumSchoolForAsesor.Rows)
            {
                NumColAsesor = Convert.ToInt32(fila1["NUMERO_ESCUELAS"]);
                PorcColegios = (NumColAsesor / NumColegios) * 100;
                lblNumSchoolForAsesor.Text += "<tr>";
                lblNumSchoolForAsesor.Text += "<td>" + fila1["ASESOR"].ToString() + "</td>";
                lblNumSchoolForAsesor.Text += "<td>" + fila1["NUMERO_ESCUELAS"].ToString() + "</td>";
                lblNumSchoolForAsesor.Text += "<td>" + String.Format("{0:0.00}", PorcColegios) + "</td>";
                lblNumSchoolForAsesor.Text += "</tr>";
            }
        }
    }
}